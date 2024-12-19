using System.Data;
using System.Data.SQLite;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private string databaseFile = "C:\\Users\\GS\\Desktop\\WinFormsApp\\Db\\mydatabase.db";
        private string? connectionString;
        string? selectedID;
        public Form1()
        {
            InitializeComponent();

            // Set the database connection string
            connectionString = $"Data Source={databaseFile};Version=3;";

            // Check and create the database file
            CreateDatabaseFile();
            LoadCarsIntoDataGridView();
        }


        private void CreateDatabaseFile()
        {
            if (!Directory.Exists("C:\\Users\\GS\\Desktop\\WinFormsApp\\Db"))
            {
                Directory.CreateDirectory("C:\\Users\\GS\\Desktop\\WinFormsApp\\Db");
            }
            if (!File.Exists(databaseFile))
            {
                try
                {
                    SQLiteConnection.CreateFile(databaseFile);
                    InitializeDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating database: {ex.Message}");
                }
            }
        }


        private void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Cars (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Brand TEXT NOT NULL,
                                        Model TEXT NOT NULL,
                                        Year INTEGER NOT NULL
                                    );";

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void ResetAutoIncrementToZero(SQLiteConnection conn)
        {
            string checkCountQuery = "SELECT COUNT(*) FROM Cars;";
            using (SQLiteCommand checkCmd = new SQLiteCommand(checkCountQuery, conn))
            {
                long count = (long)checkCmd.ExecuteScalar();
                if (count == 0) // If the table is empty
                {
                    // Set the autoincrement value to start at 0
                    string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Cars';";
                    using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                    {
                        resetCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void InsertCar(string brand, string model, int year)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "INSERT INTO Cars (Brand, Model, Year) VALUES (@Brand, @Model, @Year);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Year", year);

                    cmd.ExecuteNonQuery();
                }

            }

        }
        private void DeleteCar(string delId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "DELETE FROM Cars WHERE Id = @Id;";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", delId);

                    cmd.ExecuteNonQuery();
                }
                ResetAutoIncrementToZero(conn);
            }
        }
        private void LoadCarsIntoDataGridView()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string selectQuery = "SELECT * FROM Cars;";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, conn))
                {
                    DataTable carsTable = new DataTable();
                    adapter.Fill(carsTable);

                    // Assuming you have a DataGridView named dataGridView1
                    CarGrid.DataSource = carsTable;
                }
            }
        }

        private void SubmitEntryButton_Click(object sender, EventArgs e)
        {
            InsertCar(BrandEntryTextBox.Text, ModelEntryTextBox.Text, Convert.ToInt32(YearEntryTextBox.Text));
            LoadCarsIntoDataGridView();
            BrandEntryTextBox.Text = null;
            ModelEntryTextBox.Text = null;
            YearEntryTextBox.Text = null;
        }
        private void CarGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CarGrid.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = CarGrid.SelectedRows[0];

                // Example: Access data from columns by column names or indices
                selectedID = selectedRow.Cells["Id"].Value.ToString();  // Assuming there's a column named "ID"
            }
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            if(selectedID!=null)
            {
                DeleteCar(selectedID);
                LoadCarsIntoDataGridView();
            }
            else
            {
                MessageBox.Show("No row selected!");
            }
        }
    }
}
