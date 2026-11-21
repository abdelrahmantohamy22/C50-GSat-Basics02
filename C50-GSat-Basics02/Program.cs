
namespace C50_GSat_Basics02
{
    internal class Book
    {
        //Q1

         public String title;
         public int pages;
        //Q2
        static void Main()
        {
            Book book = new Book();
            object obj = new Book();
           Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(obj));
            Console.WriteLine(book.GetType());
            //Q3
            //int pages = "464"; Logical Error
            int pages1 = 464;
            //Q4
            try {
                int x = 0;
                int y = 10 / x;
                Console.WriteLine(y);
            }
            catch(Exception ex) {  

                Console.WriteLine("Cannot divide by zero");
               }
            finally { 
                Console.WriteLine("Done");
                 

            }
            //Q5
            int pages = 300;
            double z=pages;
            Console.WriteLine(z);
            //Q6
            double price = 49.99;
            int priceInt = Convert.ToInt32(price);
            Console.WriteLine(priceInt);

            //Q7
            string pagetext= "464";
            int pageNumber = Convert.ToInt32(pagetext);
            Console.WriteLine(pageNumber);
            //Q8
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);
            string yeartext2 = "abc";
            int year2 = int.Parse(yeartext2);
            Console.WriteLine(year2);
            //Q9
            int pages3 = 464;
            string pagesText = pages3.ToString();
            Console.WriteLine(pagesText);
            Console.WriteLine(pages3.GetType());
            //Q10
            int copies=100;
            object obj1 = copies;
            int newCopies = (int)obj1;


        }



    }



}
