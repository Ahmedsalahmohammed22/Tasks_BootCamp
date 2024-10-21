namespace Event_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , string> dic1 = new Dictionary<string , string>();
            dic1.Add("Father", "Mohammed");
            dic1.Add("Mother", "Reem");
            dic1.Add("Brother", "Khaled");

            var employee1 = new Employee(1, "Ahmed salah", 60000, "Male", DateTime.Now , dic1);
            //Console.WriteLine(employee1);

            Dictionary<string, string> dic2 = new Dictionary<string, string>();
            dic2.Add("Father", "Mostafa");
            dic2.Add("Mother", "Rana");
            dic2.Add("Brother", "Wael");

            var employee2 = new Employee(1, "Ahmed mohammed", 10000, "Male", DateTime.Now , dic2);
            //Console.WriteLine(employee2);

            Club club = new Club("Elahly", "cairo", "Family");
            employee1.addemployee += club.Addinclub;
            Socialensurance socialensurance = new Socialensurance("12587", "ELNil Ensurance", DateTime.Now);
            employee1.addemployee += socialensurance.BeginSocialensurance;

            employee1.Onaddemployee();

            Club club2 = new Club("Zamalik", "cairo", "basic");
            employee2.addemployee += club2.Addinclub;
            Socialensurance socialensurance2 = new Socialensurance("12587", "United Ensurance", DateTime.Now);
            employee2.addemployee += socialensurance2.BeginSocialensurance;

            employee2.Onaddemployee();


        }
    }
}
