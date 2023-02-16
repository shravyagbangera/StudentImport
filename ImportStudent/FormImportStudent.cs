using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImportStudent
{
    public partial class FormImportStudent : Form
    {


       SqlConnection Con;
       SqlCommand Cmd;
       DConnect Db=new DConnect();

        public FormImportStudent()
        {
            InitializeComponent();

            Con = new SqlConnection(Db.Getconnection());
        }

        private void button_Load_Click(object sender, EventArgs e)
        {

        //SqlCommand command = new SqlCommand("TRUNCATE TABLE Student", Con);


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "select file";
            openFileDialog.FileName = textBox1.Text;
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog.FileName;
                DataTable dataTable = new DataTable();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string[] headers = reader.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split(',');
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            row[i] = fields[i];
                        }
                        dataTable.Rows.Add(row);
                    }
                }
                DG1.DataSource = dataTable;
            }


        }
        private void FormImportStudent_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Text_Select(object sender, EventArgs e)
        {
            
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in DG1.Rows)
            {
                Con.Open();
                if (!row.IsNewRow)
                {
                    Cmd = new SqlCommand("INSERT INTO studentImport (StuID, FirstName, LastName,DOB, SSN, Adddress,City, State, Email,MaritalStatus) VALUES (@StuID, @FirstName, @LastName,@DOB, @SSN, @Adddress,@City, @State, @Email,@MaritalStatus)", Con);
                    Cmd.Parameters.AddWithValue("@StuID", row.Cells[0].Value);
                    Cmd.Parameters.AddWithValue("@FirstName", row.Cells[1].Value);
                    Cmd.Parameters.AddWithValue("@LastName", row.Cells[2].Value);
                    Cmd.Parameters.AddWithValue("@DOB", row.Cells[3].Value);
                    Cmd.Parameters.AddWithValue("@SSN", row.Cells[4].Value);
                    Cmd.Parameters.AddWithValue("@Adddress", row.Cells[5].Value);
                    Cmd.Parameters.AddWithValue("@City", row.Cells[6].Value);
                    Cmd.Parameters.AddWithValue("@State", row.Cells[7].Value);
                    Cmd.Parameters.AddWithValue("@Email", row.Cells[8].Value);
                    Cmd.Parameters.AddWithValue("@MaritalStatus", row.Cells[9].Value);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                }
            }



                MessageBox.Show("Record inserted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }


        

       
    }
    }




