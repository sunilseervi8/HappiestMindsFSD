using System.Collections;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
namespace Dictionaries
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }

    internal class Program
    {

        //Program() { }
        //public Program(string name, int id, string city, string address)
        //{
        //    this.Name = Name;
        //    this.Id = Id;
        //    this.City = City;
        //    this.Address = Address;
        //}


        static void Main(string[] args)
        {
            //Dictionary<int,string> dic = new Dictionary<int,string>();
            //dic.Add(1, "Hello");
            //dic.TryAdd(1, "hello world");
            //dic.Add(2, "hello world");
            //dic.TryAdd(3, "dictionary");


            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item);

            //}n 




            Dictionary<string, List<Customer>> branchCustomers = new Dictionary<string, List<Customer>>();

            List<Customer> list = new List<Customer>();
            list.Add(new Customer() { Name = "dhinesh", Id = 121, City = "chennai", Address = "CMBT" });
            list.Add(new Customer() { Name = "Sunil", Id = 122, City = "bangalore", Address = "Yelahanka" });
            list.Add(new Customer(){Name = "Rohit", Id = 122, City = "Hyderabad", Address = "Opal"});
            list.Add(new Customer() { Name = "Aishwariya", Id = 122, City = "Noida", Address = "noida" });
            list.Add(new Customer() { Name = "Chaitra", Id = 122, City = "bangalore", Address="bangalore" });


            var res = from customer in list
                      group customer by customer.City into g
                      select new { cusCity = g.Key, MyCustomer = g };


            foreach (var item in res)
            {
                branchCustomers.Add(item.cusCity, item.MyCustomer.ToList<Customer>());
            }





        }
    }
}

