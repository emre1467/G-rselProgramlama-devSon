using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaÖdevSon
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { Name = "emre", SurName = "yiğit", Department = "ceng", Faculty = "mühendislik", No = 178 };
            Student d = new Student { Name = "emre", SurName = "yiğit", Department = "ceng", Faculty = "mühendislik", No = 178 };
            StudentManager studentManager = new StudentManager();
            studentManager.Add(s);
            studentManager.Add(d);
            studentManager.Yazdır(s);
            s.Add(1001);
            s.Add(1002);
            s.Delete(1002);
        }
    }
}
