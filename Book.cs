using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP_Assignment_7
{
    internal class Book
    {
        //Constructor
        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //Properties
        public string Name { get; set; }
        public double Price { get; set; }

        //Instance method
        public List<Book> BuyABook (List<Book> thosebooks)
        {
            List<Book> newList = new List<Book> ();
            bool end = false;
            while (!end)
            {
                Console.Write("Which Book you are interested in?: ");

                string bookName = Console.ReadLine();

                bool found = false;
                foreach (var i in thosebooks)
                {

                    if (i.Name.Contains(bookName))

                    {
                        Console.Write("Book found:" + i.Name + "\nAre you buying this book (Y/N)?:");


                        string ans = Console.ReadLine().ToUpper();

                        found = true;

                        if (ans.StartsWith('Y'))
                        {
                            newList.Add(i);

                            Console.WriteLine("Adding the book " + i.Name + " to your shopping cart.");
                        }
                    }
                }

                if (!found)
                    Console.WriteLine("The book you were looking for was not found.");
                    Console.Write("More books (Y/N) ?: ");

                string answer = Console.ReadLine();

                if (answer.StartsWith('n'))
                    end = true;
            }
            return newList;
        }
        
        public double CalcTotalPrice(List<Book> thosebooks)
        {
            double total = 0;
            if (thosebooks.Count != 0)
                foreach (var i in thosebooks)
                {
                    Console.WriteLine("{0}, {1}", i.Name, i.Price);
                    total += i.Price;
                }
            return total;

        }

    }
}
