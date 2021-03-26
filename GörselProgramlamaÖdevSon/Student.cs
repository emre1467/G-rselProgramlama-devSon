using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaÖdevSon
{
    public class Student:LessonsManager
    {
        public string  Name { get; set; }
        public string SurName { get; set; }
        public int No { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
    }
}
