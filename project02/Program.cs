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



            // Q10 - Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is 
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            Console.WriteLine("the answer of question 10 ");
            string title3 = "Refactoring";
            switch (title3)
            {
                case "clean code":
                    Console.WriteLine("Great Choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }



            // Q11 -Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a 
            // variable sizeLabel(same rule as question 8: long if pages > 300).
           
            Console.WriteLine("the answer of question 11 ");
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);


            // Q12- Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.

            Console.WriteLine("the answer of question 12 ");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            
            for(int i=0; i < books.Length; i++) {
                Console.WriteLine((i + 1) + "." + books[i]);
            
            }




            //Q13- Using the same books array, use a while loop to print every book title.

            Console.WriteLine("the answer of question 13 ");
            int x = 0;
            while (x < books.Length)
            {
                Console.WriteLine(books[x]);
                x++;
            }

            // Q-14 Write a do-while loop that prints "Checking book..." exactly 3 times. 
            Console.WriteLine("the answer of question 14 ");
            int z = 0;
            do
            {
                Console.WriteLine("Checking book...") ;
                z++;
                
            }while( z < 3);



            // Q15- Using the same books array, use a foreach loop to print every book title.
            Console.WriteLine("the answer of question 15 ");
            foreach(string book in books)
            {
                Console.WriteLine(book);
            }



            //Q16- Using the same books array, loop through it and print each title, but stop completely (break) once   you reach "Refactoring".

            Console.WriteLine("the answer of question 16 ");
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }


            // Q17- Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            Console.WriteLine("the answer of question 17 ");

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

        }
    }
}
