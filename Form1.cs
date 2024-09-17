using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Formatting = Newtonsoft.Json.Formatting;

namespace WheelsWatchTech
{
    public partial class Form1 : Form
    {
        private IFirebaseConfig firebaseConfig;
        private IFirebaseClient firebaseClient;

        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "QZ0qqPlmn5iAIKKNVTuOvUpZFVsAJi1K0bBS2HOl",
            BasePath = "https://bzutrack-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        public DataGridView ResultGrid { get; private set; }

        public void loadform(object Form)
        {
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(fcon);
                MessageBox.Show("Connection to Firebase successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to Firebase: {ex.Message}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
      

        private void btnDownload_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdatedata_Click_1(object sender, EventArgs e)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                 StoreDataInFirebaseAsync(ds.Tables[0]);
            }
            else
            {
                MessageBox.Show("No data to save. Please load data first.");
            }
        }
        private async Task StoreDataInFirebaseAsync(DataTable dataTable)
        {
            if (firebaseClient != null)
            {
                try
                {
                    string path = "Busdata";  // Update with your actual Firebase path

                    // Define a mapping between original and desired column names
                    Dictionary<string, string> columnNameMapping = new Dictionary<string, string>
            {
                { "Column0", "BusIndex" },
                { "Column1", "BusNo" },
                { "Column2", "BusRoute" },
                { "Column3", "BusTime" }
                // Add more mappings as needed
            };

                    // Show loader form
                    using (var loaderForm = new loaderfoam(() =>
                    {
                        for (int row = 0; row < dataTable.Rows.Count; row++)
                        {
                            DataRow currentRow = dataTable.Rows[row];

                            // Extract busindex from the current row
                            string busindex = currentRow["Column0"].ToString();

                            // Convert the current row to a dictionary with mapped column names
                            Dictionary<string, object> rowData = new Dictionary<string, object>();

                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                // Use the mapped column name if it exists, otherwise use the original name
                                string columnName = columnNameMapping.ContainsKey(dataTable.Columns[col].ColumnName)
                                    ? columnNameMapping[dataTable.Columns[col].ColumnName]
                                    : dataTable.Columns[col].ColumnName;

                                rowData[columnName] = currentRow[col];
                            }

                            try
                            {
                                // Use Set method to set the data under the specified path with busindex as the key
                                SetResponse response = firebaseClient.Set($"{path}/{busindex}", rowData);

                                if (response == null)
                                {
                                    // Log an error or handle the failure in some way
                                    Console.WriteLine($"Error storing row {row + 1} in Firebase.");
                                }
                            }
                            catch (Exception ex)
                            {
                                // Log an error or handle the exception in some way
                                Console.WriteLine($"An error occurred while storing row {row + 1}: {ex.Message}");
                            }
                        }
                    }))
                    {
                        loaderForm.ShowDialog();
                    }

                    // Inform the user after all rows are stored (optional)
                    MessageBox.Show("Data is Stored in Firebase successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Firebase client not initialized.");
            }
        }

        


        private void btnloaddata_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Excel Workbook | *.xls;*.xlsx",
                ValidateNames = true
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream))
                        {
                            ds = reader.AsDataSet();
                            DataTable dt = ds.Tables[0];

                            // Assuming your DataGridView is named ResultGrid
                            DataGridView resultGrid = ResultGrid;

                            // Clear existing rows in the DataGridView
                            resultGrid.Rows.Clear();

                            // Iterate through each row in the DataTable
                            foreach (DataRow row in dt.Rows)
                            {
                                // Create an array to hold cell values for the row
                                object[] cellValues = new object[resultGrid.Columns.Count];

                                // Iterate through each column in the DataGridView
                                for (int i = 0; i < resultGrid.Columns.Count; i++)
                                {
                                    // Check if the column name exists in the DataTable
                                    if (dt.Columns.Contains(resultGrid.Columns[i].Name))
                                    {
                                        // Add the cell value from the DataTable to the array
                                        cellValues[i] = row[resultGrid.Columns[i].Name];
                                    }
                                    else
                                    {
                                        // If the column name doesn't exist, add an empty cell
                                        cellValues[i] = "";
                                    }
                                }

                                // Add the array of cell values to the DataGridView
                                resultGrid.Rows.Add(cellValues);
                            }
                        }
                    }
                }
            }
        }
    }
}
