using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    interface IStudentRepository
    {
        void AddStudent(Student student);
        Student GetStudent(int Stud_Code);
        void DeleteStudent(int Stud_Code);
        List<Student> GetallStudents();
        void UpdateStudent(Student student);

    }
}
