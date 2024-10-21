namespace Assignment_Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase.AppList = new Dictionary<string, Appointment>();
            DataBase.CustomerList = new Dictionary<int, Customer>();
            DataBase.AssistantList = new Dictionary<int, Assistant>();

            var assistant = new Assistant
            {
                Id = 2,
                Name = "Ali Mohammed",
                Phone = "01023589850",
                Shift = "Morning",
                IsOnline = true,
                LastLoggedIn = DateTime.Now,
                Username = "Ali123",
                Password = "Assistant",
            };
            var customer = new Customer() 
            { 
                Id = 1, 
                Name = "Mohammed Khaled", 
                Age = 25, Address = "30 Hany Osman St", 
                Gender = "Male" 
            };
            var doctor = new Doctor() 
            {
                Id = 1,
                Name = "Dr. Ahmed",
                Phone = "01023589460",
                Shift = "Morning",
                IsOnline = true,
                LastLoggedIn = DateTime.Now,
                Username = "Ahmed123",
                Password = "Doctor",
                Department = "Cardiology",
                WorkingDays = new List<WorkingDays> { WorkingDays.Monday, WorkingDays.Wednesday } 
            };
            DateTime date = DateTime.Now;
            assistant.AddAppointment(date, customer, doctor, "Morning");
            var customer2 =  assistant.addNewCustomer("Waleed", "faisel", 25, "Male");
            assistant.AddToWaiting(customer2);

            DateTime newDate = DateTime.Now.AddDays(1);
            TimeOnly newTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1));
            assistant.ChangeAppointment(date, TimeOnly.FromDateTime(date), newDate, newTime);

            assistant.DeleteAppointment(newDate, newTime);
        }
    }
}
