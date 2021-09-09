using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Practice
{
    class Demo
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HBQQ1KH2\SQLEXPRESS;Initial Catalog=Geeshmadb;Integrated Security=True");
        SqlDataAdapter dataadapter = null;
        DataSet data = null;

        public Demo()
        {
            dataadapter = new SqlDataAdapter("Select * from Product", connection);
            //initiate dataset
            data = new DataSet();
            dataadapter.Fill(data, "P");
        }
        public void GetAllRecords()
        {
            DataTable dataTable = data.Tables["P"];//returns datatable
            foreach(DataRow dr in dataTable.Rows)
            {
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr["Stock"]}");
            }
        }

        public void GetRow(int idx)
        {
            if (idx < data.Tables["P"].Rows.Count)
            {
                DataRow dr = data.Tables["P"].Rows[idx];
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr["Stock"]}");
            }
            else
            {
                Console.WriteLine("Invalid Row No");
            }
        }
    }

    }

