namespace FTPClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            NIC myNIC = NIC.getNIC("Intel", "00-14-22-01-23-45", NICType.Ethernet);


            Console.WriteLine( myNIC.ToString());


            NIC anotherNIC = NIC.getNIC("AMD", "00-16-36-AB-CD-EF", NICType.TokenRing);

            // print myNIC not anotherNIC because create only one object in app ( singletone )
            Console.WriteLine( anotherNIC.ToString());
        }
    }
}
