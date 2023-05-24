namespace StudentCardLibrary
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public DateTime BDay { get; set; }
        public string Group { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateOnly RegistryDate { get; set; }

        public Student(string sur, string name, string otch, DateTime bday, string group, DateTime recdate)
        {
            Surname = sur;
            Name = name;
            Otchestvo = otch;
            BDay = bday;
            Group = group;
            ReceiptDate = recdate;
            RegistryDate = DateOnly.FromDateTime(DateTime.Now);
        }
        public override string ToString()
        {
            return new string($"{RegistryDate}\t{Surname} {Name} {Otchestvo}");
        }
    }
}