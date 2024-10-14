namespace StudentLibrary
{
    public class Student
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }

        public Student(int id , string name , int age , string email , string phone , string subject , string department )
        {
            this.Id = id ;
            this.Name = name;   
            this.Age = age ;
            this.Email = email ;
            this.Phone = phone ;
            this.Subject = subject;
            this.Department = department ;
        }

        public string DisplayInfo()
        {
            return $"ID: {Id}\nName: {Name}\nAge: {Age}\nEmail: {Email}\nPhone: {Phone}\nSubject: {Subject}\nDepartment: {Department}";
        }
    }
}
