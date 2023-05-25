using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentCardLibrary
{
    public class StorageInJson
    {
        public ObservableCollection<Student> students;
        public string path;

        public StorageInJson(string path)
        {
            this.path = path;
        }
        public StorageInJson(ObservableCollection<Student> students, string path)
        {
            this.students = students;
            this.path = path;
        }

        public ObservableCollection<Student>? Deserialize()
        {
            try
            {
                string json = File.ReadAllText(this.path);

                Student[]? stds = JsonSerializer.Deserialize<Student[]>(json);
                return new ObservableCollection<Student>(stds);
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public void Serialize()
        {
            students = new ObservableCollection<Student>(students.ToList());
            string json = JsonSerializer.Serialize(this.students);

            File.WriteAllText(this.path, json);
        }
    }
}
