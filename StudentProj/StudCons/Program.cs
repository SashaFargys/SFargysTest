using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALStud;

namespace StudCons
{
    class Program
    {
        static void Main(string[] args)
        {
            StudsServ studsServ = new StudsServ();
            //studsServ.Add(new Student
            //{
            //    Name = "Ivan",
            //    LastName = "Ivanov",
            //    Age = 20
            //});
            //studsServ.Add(new Student
            //{
            //    Name = "I",
            //    LastName = "Iv",
            //    Age = 18
            //});
            //Random rnd = new Random();
            //foreach (Student item in studsServ.students)
            //{
            //    item.Addmark("C++", rnd.Next(1, 12));  
            //}
            foreach (Student item in studsServ.students)
            {
                Console.WriteLine(item);
            }
            studsServ.Save();
        }
    }
}
