using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Person
    {
        public string FName;
        public string LName;
        public string Address;
        public long PhoneNumber;

        public string Result()
        {
            return " Name is: " + FName + " " + LName + "\n Address: " + Address + "\n Phone: " + PhoneNumber;
        }
    }

    public class AddressBook
    {
        public List<Person> person = new List<Person>(); //creating a list
        public AddressBook()  // Address book method
        {
            string json = File.ReadAllText(@"E:\BridgeLabzAssignment\Day28_Problems\AddressBook\AddressBook\Example.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
                person = new List<Person>();
        }

        public void Display()  // display Method
        {
            if (person.Count == 0)
            {
                Console.WriteLine("Please add Some Contact list First");
            }
            Console.WriteLine("Welcome to Program");
            foreach (Person per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void addPerson(Person p)   //Adding Contact list of persons
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"E:\BridgeLabzAssignment\Day28_Problems\AddressBook\AddressBook\Example.json", jsonData);
        }
    }
}


