using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace project02
{
    internal class Program
    {
      static void Main(string[] args)
        {

          // Q1- Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print  both title and upperTitle to show that title did not change.

            Console.WriteLine("the answer of question 1");
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

           // Q2- Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()  to check if they point to the same object in memory.

            Console.WriteLine("the answer of question 2");
            string str1 = "clean code";
            string str2 = "clean code";
            bool areTheSameRef = ReferenceEquals(str1, str2);
            Console.WriteLine($"Are str1 and str2 the same ref in memory? {areTheSameRef}");



            // Q3- Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same  object.Print the final result.
            Console.WriteLine("the answer of question 3");

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("- updated");
            Console.WriteLine(sb);


            // Q4- Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".  Print the result.
            Console.WriteLine("the answer of question 4");
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);


            // Q5- Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
            Console.WriteLine("the answer of question 5");
            string title2 = "clean code";
            int pages = 464;
            string Result = $"Book: {title2} , pages : {pages} ";
            Console.WriteLine(Result);


            // Q6- Build the same sentence as above, but using string interpolation ($"..."). 
            Console.WriteLine("the answer of question 6");
            string Result2 = "Book: "+ title2 + ", pages:" + pages;
            Console.WriteLine(Result2);



            // Q7 - Build the same sentence again, but using string.Format(). 
            Console.WriteLine("the answer of question 7");
            string Result3 = string.Format("Book: {0} , pages: {1}",title2 ,pages );
            Console.WriteLine(Result3);




            //Q8- Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            Console.WriteLine("the answer of question 8");
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            };

            // Q9- Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.

            Console.WriteLine("the answer of question 9");
            bool isAvailable = true;
            if(pages>300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
        }
    }
}
