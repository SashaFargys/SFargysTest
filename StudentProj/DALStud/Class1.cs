using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALStud
{
    [Serializable]
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

       public List <Mark> Marks { get; set; }
        public Student()
        {
            Marks = new List<Mark>();
        }
        public override string ToString()
        {
            string rate = String.Empty;
            if(Marks!=null)
            {
                foreach (var item in Marks)
                {
                    rate += (item as Mark).ToString() + Environment.NewLine;
                }
            }
            return $"{LastName}  {Name} , {Age} {rate}";
        }
        public void Addmark(string subject, int mark)
        {
            if (!Marks.Exists(m => m.Subject.Equals(subject)))
                Marks.Add(new Mark
                { Subject = subject, Rating = mark });
        }

    }
    [Serializable]
    public class Mark
    {
        public int Rating { get; set; }
        public string Subject { get; set; }
        public override string ToString()
        {
            return $"{Subject}  - -  {Rating}";
        }
    }

}
