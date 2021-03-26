using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GörselProgramlamaÖdevSon
{
    class StudentManager
    {
        ArrayList DataBase = new ArrayList();
        public void Add(Student student)
        {
            Console.WriteLine("öğrenci eklendi");
            DataBase.Add(student);
        }     
        public void Delete(Student student)
        {
            Console.WriteLine("öğrenci silindi");
            DataBase.Remove(student);
        }
        public void Yazdır(Student student)
        {
            foreach (var database in DataBase)
            {
                if (student == database)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.SurName);
                    Console.WriteLine(student.No);
                    Console.WriteLine(student.Department);
                    Console.WriteLine(student.Faculty);
                }
            }
        }
    }
}
