using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project1.Entities
{
    class Student_master
    {
        public int Stud_Code { set; get;}
        public string Stud_Name { set; get; }
        public int Dept_Code { set; get; }
        public string Stud_Dob { set; get; }
        public string Address { set; get; }
    }
}
