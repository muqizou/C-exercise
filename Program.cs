using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        public class Person
        {
            public string firstname;
            public string secondname;
            public string email;
            public DateTime birthday;

            public Person(string fn,string sn,string em, string bd)
            {
                firstname = fn;
                secondname = sn;
                email = em;
                birthday = DateTime.ParseExact(bd, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

        }
        static void Main(string[] args)
        {
            List<Person> informationlist = new List<Person>();
            while (true)
            {
                Console.Write("1.Enter information \n2.Show information\n");
                string get = Console.ReadLine();
                int temp;
                Int32.TryParse(get, out temp);
                if (temp == 1)
                {
                    Console.Write("Enter the firstname: ");

                    string input1 = Console.ReadLine();

                    Console.Write("Enter the secondname: ");

                    string input2 = Console.ReadLine();

                    Console.Write("Enter the email: ");

                    string input3 = Console.ReadLine();

                    Console.Write("Enter the year of birthday: ");

                    string input4 = Console.ReadLine();
                    int year;
                    Int32.TryParse(input4, out year);
                    Console.Write("Enter the month of birday: ");

                    string input5 = Console.ReadLine();
                    int month;
                    Int32.TryParse(input5, out month);
                    Console.Write("Enter the day of birthday: ");

                    string input6 = Console.ReadLine();
                    int date;
                    Int32.TryParse(input6, out date);

                    string dbtime = date.ToString()+"/"+ month.ToString() + "/" + year.ToString();

                    Person person = new Person(input1, input2, input3, dbtime);
                    informationlist.Add(person);
                    Console.Write("Information entered succesffully");
                    Console.ReadLine();


                }
                else if(temp == 2)
                {
                    DateTime thisDay = DateTime.Today;
                    
                    for (int i =0;i< informationlist.Count; i++)
                    {
                        System.Console.Write("\nName:" + informationlist[i].firstname + " " + informationlist[i].secondname );
                        System.Console.Write("\nEmail " + informationlist[i].email );
                        if (informationlist[i].birthday.Month == thisDay.Month && informationlist[i].birthday.Day == thisDay.Day)
                        {
                            System.Console.Write("\nToday is his birthday");

                        }
                        else
                        {
                            System.Console.Write("\nToday is not his birthday");
                        }
                        Console.Write("\n");


                    }
                    Console.Write("\nPress any key to continue");
                    string input2 = Console.ReadLine();
                }
                else
                {
                    Console.Write("Select again");
                    string input2 = Console.ReadLine();

                }
            }

            
        }
    }
}
