using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ZadanieDomowe6
{
    public class Customer
    {
        private string _name;
        protected int _age;
        public bool isPreferred;
        public Customer(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Customer name!");
            _name = name;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set { _name = value; }
        }
        public string Address { get; set; }
        public int SomeValue { get; set; }
        public int ImportantCalculation()
        {
            return 1000;
        }
        public void ImportantVoidMethod()
        {
        }
        public enum SomeEnumeration
        {
            ValueOne = 1
        , ValueTwo = 2
        }
        public class SomeNestedClass
        {
            private string _someString;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1
            
            Type info = typeof(Customer);
            FieldInfo[] fields = info.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                                        .Where(f => f.GetCustomAttribute<CompilerGeneratedAttribute>() == null)
                                        .ToArray();

            Console.WriteLine("Fields: ");
            for (int i = 0; i < fields.Length; i++)
            {
                Console.WriteLine(fields[i].FieldType + ": " + fields[i].Name);
            }

            Console.WriteLine("\n-- Public: ");
            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i].IsPublic)
                    Console.WriteLine(fields[i].FieldType + ": " + fields[i].Name);
            }

            Console.WriteLine("\n-- Non Public: ");
            for (int i = 0; i < fields.Length; i++)
            {
                if (!fields[i].IsPublic)
                    Console.WriteLine(fields[i].FieldType + ": " + fields[i].Name);
            }


            MethodInfo[] methods = info.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                                        .Where(f => f.GetBaseDefinition().DeclaringType == info)
                                        .ToArray();
            Console.WriteLine("\nMethods: ");
            for (int i = 0; i < methods.Length; i++)
            {
                    Console.WriteLine(methods[i].ReturnType + ": "+methods[i].Name);
            }

            Type[] nestType = info.GetNestedTypes();
            Console.WriteLine("\nNested types: ");
            for (int i = 0; i < nestType.Length; i++)
            {
                Console.WriteLine(nestType[i].Name);
            }


            PropertyInfo[] properties = info.GetProperties();
            Console.WriteLine("\nProperties: ");
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i].Name);
            }


            MemberInfo[] members = info.GetMembers();
            Console.WriteLine("\nMembers: ");
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i].Name);
            }

            // Zadanie 2
            Console.WriteLine("\nZadanie 2");
            var customer = new Customer("Fred");
            Console.WriteLine("\nInitial value of Name property: {0}", customer.Name);
            PropertyInfo piName = info.GetProperty("Name");
            piName.SetValue(customer, "Bob");
            Console.WriteLine("New value of Name property: {0}", customer.Name);

            Console.WriteLine("\nInitial value of Address property: {0}", customer.Address);
            PropertyInfo piAddress = info.GetProperty("Address");
            piAddress.SetValue(customer, "Monaco");
            Console.WriteLine("New value of Address property: {0}", customer.Address);

            Console.WriteLine("\nInitial value of SomeValue property: {0}", customer.SomeValue);
            PropertyInfo piSomeValue = info.GetProperty("SomeValue");
            piSomeValue.SetValue(customer, 123);
            Console.WriteLine("New value of SomeValue property: {0}", customer.SomeValue);
        }
    }
}
