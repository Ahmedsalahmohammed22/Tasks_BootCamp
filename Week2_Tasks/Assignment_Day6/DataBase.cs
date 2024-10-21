using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Day6
{
    internal static class DataBase
    {
        public static Dictionary<string , Appointment> AppList {  get; set; }
        public static Dictionary<int , Customer> CustomerList { get; set; }
        public static Dictionary<int , Assistant> AssistantList { get; set;}

        public enum Table
        {
            Appointment,
            Customer,
            Assistant   
        }
        public static bool Insert(Table table, object item)
        {
            switch (table)
            {
                case Table.Appointment:
                    if (item is Appointment appointment)
                    {
                        string key = $"{appointment.Date:yyyy-MM-dd}_{appointment.Time:HH:mm}";
                        if (!AppList.ContainsKey(key))
                        {
                            AppList.Add(key, appointment);
                            return true;
                        }
                        return false;
                    }
                    break;

                case Table.Customer:
                    if (item is Customer customer)
                    {
                        if (!CustomerList.ContainsKey(customer.Id))
                        {
                            CustomerList[customer.Id] = customer;
                            return true;
                        }
                        return false;
                    }
                    break;

                case Table.Assistant:
                    if (item is Assistant assistant)
                    {
                        if (!AssistantList.ContainsKey(assistant.Id))
                        {
                            AssistantList[assistant.Id] = assistant;
                            return true;
                        }
                        return false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid table type.");
                    return false;
            }
            return false;
        }

        public static bool  Update(Table table, object item , string key)
        {
            switch (table)
            {
                case Table.Appointment:
                    if (item is Appointment appointment)
                    {
                        if (AppList.ContainsKey(key))
                        {
                            AppList.Remove(key);
                            key = $"{appointment.Date:yyyy-MM-dd}_{appointment.Time:HH:mm}";
                            AppList[key] = appointment;
                            Console.WriteLine("Appointment updated");
                            return true;
                        }
                        return false;
                    }
                    break;

                case Table.Customer:
                    if (item is Customer customer)
                    {
                        if (CustomerList.ContainsKey(customer.Id))
                        {
                            CustomerList[customer.Id] = customer;
                            Console.WriteLine("Customer updated");

                            return true;
                        }
                        return false;
                    }
                    break;

                case Table.Assistant:
                    if (item is Assistant assistant)
                    {
                        if (AssistantList.ContainsKey(assistant.Id))
                        {
                            AssistantList[assistant.Id] = assistant;
                            Console.WriteLine("Assistant updated");
                            return true;
                        }
                        return false;
                    }
                    break;
            }
            return false;
        }
        public static bool Delete(Table table, object item) 
        {
            switch (table)
            {
                case Table.Appointment:
                    if (item is Appointment appointment)
                    {
                        string key = $"{appointment.Date:yyyy-MM-dd}_{appointment.Time:HH:mm}";
                        if (AppList.ContainsKey(key))
                        {
                            AppList.Remove(key);
                            Console.WriteLine("Appointment deleted.");
                            return true;
                        }
                        return false;
                    }
                    break;

                case Table.Customer:
                    if (item is Customer customer)
                    {
                        if (CustomerList.ContainsKey(customer.Id))
                        {
                            CustomerList.Remove(customer.Id);
                            Console.WriteLine("Customer deleted.");
                            return true;
                        }
                        return false;
                    }
                    break;

                case Table.Assistant:
                    if (item is Assistant assistant)
                    {
                        if (AssistantList.ContainsKey(assistant.Id))
                        {
                            AssistantList.Remove(assistant.Id);
                            Console.WriteLine("Assistant deleted.");
                            return true;
                        }
                        return false;
                    }
                    break;
            }
            return false;
        }

        public static Appointment? SelectAppointment(List<Appointment> appointments, DateTime date)
        {
            foreach (var appointment in appointments)
            {
                if (appointment.Date == date)
                {
                    return appointment;
                }
            }
            return null;
        }

        public static Customer? SelectCustomer(List<Customer> customers, int customerId)
        {
            foreach (var customer in customers)
            {
                if (customer.Id == customerId)
                {
                    return customer;
                }
            }
            return null;
        }

        public static Assistant? SelectAssistant(List<Assistant> assistants, int assistantId)
        {
            foreach (var assistant in assistants)
            {
                if (assistant.Id == assistantId)
                {
                    return assistant;
                }
            }
            return null;
        }


    }
}
