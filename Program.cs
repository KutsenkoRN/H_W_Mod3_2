using System.Globalization;
using System.Text;

namespace H_W_Mod_3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ContactCollection contacts = new ContactCollection();
            contacts.AddContact(new Contact("0994084946", "Іван"), new CultureInfo("en-US"));
            contacts.AddContact(new Contact("0982607475", "Ivan"));
            contacts.AddContact(new Contact("0684090690", "Natalie"), new CultureInfo("uk-UA"));
            contacts.AddContact(new Contact("0684090790", "Anna"), new CultureInfo("uk-UA"));
            contacts.AddContact(new Contact("0984191791", "Andrew"), new CultureInfo("en-US"));
            contacts.AddContact(new Contact("0630574896", "057Stas"));
            contacts.AddContact(new Contact("0687647355", "Олексій"), new CultureInfo("uk-UA"));
            contacts.AddContact(new Contact("0674085599", "Віка"), new CultureInfo("uk-UA"));

            foreach (var contact in contacts.SortedContacts)
            {
                Console.WriteLine(contact.Key);
                foreach (var c in contact.Value)
                {
                    Console.WriteLine($"{c}");
                }

                Console.WriteLine();
            }
        }
    }
}