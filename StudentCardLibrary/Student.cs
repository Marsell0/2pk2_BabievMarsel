namespace StudentCardLibrary
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public DateOnly BDay { get; set; }
        public string Group { get; set; }
        public DateOnly ReceiptDate { get; set; }
        public DateOnly RegistryDate { get; set; }

        public void AddStudent()
        {

        }
    }
}