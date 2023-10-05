using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection? connection = null;
        SqlDataReader? reader = null;
        DataTable? table = null;




        //DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();


            connection = new SqlConnection("Data Source=STHQ0123-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;");
        }

        public void foo()
        {
            string commandText = txtCommand.Text;
            SqlCommand cmd = new SqlCommand(commandText, connection);
            connection.Open();
            table = new DataTable();
            reader = cmd.ExecuteReader();
            bool isColumn = true;
            do
            {
                while (reader.Read())
                {
                    if (isColumn)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.Columns.Add(reader.GetName(i));
                        }
                        isColumn = false;
                    }
                    DataRow row = table.NewRow();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }

                    table.Rows.Add(row);
                }

            } while (reader.NextResult());

            dataGridView1.DataSource = table;
        }


        //public void foo()
        //{
        //    dt.Columns.Add("Id", typeof(int));
        //    dt.Columns.Add("FistName", typeof(string));
        //    dt.Columns.Add("LastName", typeof(string));


        //    dt.Rows.Add(1, "Nazim", "Hesenov");
        //    dt.Rows.Add(2, "Nadir", "Nicatli");
        //    dt.Rows.Add(3, "Nadinc", "Elbeyov");

        //    dataGridView1.DataSource = dt;
        //}





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foo();
        }
    }
}