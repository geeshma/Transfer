using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Practice
{
    class Demo2
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HBQQ1KH2\SQLEXPRESS;Initial Catalog=Geeshmadb;Integrated Security=True");
        SqlDataAdapter dataadapter = null;
        DataSet data = null;
        SqlCommandBuilder cb;
        
         public  Demo2()
        {
        dataadapter = new SqlDataAdapter("Select * from Product", connection);
            cb = new SqlCommandBuilder(dataadapter);
            //initiate Dataset
            data = new DataSet();
            dataadapter.Fill(data, "P");
            data.Tables[0].PrimaryKey = new DataColumn[1] { data.Tables[0].Columns["Pid"] };
        }
        public void GetAllRecords()
        {

        }


    }
}
