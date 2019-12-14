using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace DALStud
{
    public class StudsServ
    {
        private string path = "student.db";
        public IEnumerable<Student> students { get; set; }
        public void Add(Student st)
        {
            (students as List<Student>).Add(st);
        }
        public void Remove (string LastName)
        {
            List < Student > temp = students as List<Student>;
            temp.Remove(temp.Find(st => st.LastName.Equals(LastName)));
        }
        public StudsServ()
        {
            if (!File.Exists(path))
                students = new List<Student>();
            else
            {
                Load();
            }
        }
        private void Load()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                students = (List<Student>)bf.Deserialize(fs);
            }
        }
        public void Save()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, students);
            }
        }
    }

}
