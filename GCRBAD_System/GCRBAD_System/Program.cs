using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GCRBAD_System
{
    //Don't change the method delcarations from this class
    //You are not allowed to declare variable in Program class and then use it in methods

    public class Program
    {
        static void Main(string[] args)
        {
            //You can write code to test your method here.

            Console.ReadLine();
        }      
      
        // Marks : 16
        public static Dictionary<string, List<Customer>> GetCustomerDetails(MySqlConnection cn)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }

        // Marks : 17
        public static void LoadGasRefillHistory(Dictionary<string, List<Customer>> dict_stateCusts, FileStream fs)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }

        // Marks : 17
        public static string CustomerRequestToRefillCylinder(Customer customer, MySqlConnection cn)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }     

        // Marks : 15                             
        public static int DeliverCylindersToCustomers(List<Customer> customers, int maxDeliveryQuota)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }

        // Marks : 15
        public static void CreateXmlReportForCustomers(List<Customer> customers, string xmlReportPath)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }

        // Marks : 10
        public static SortedSet<Customer> SortCustomers(List<Customer> customers)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }

        // Marks : 10
        public static void SerializeSortedCustomers(SortedSet<Customer> sortedCustomers, FileStream fs)
        {
            //delete this line and then write your code here
            throw new NotImplementedException();
        }    
    }
}
