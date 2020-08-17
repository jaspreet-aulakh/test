using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

/*
 
//INHERITANCE
            //Chef = superclass
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            //Italian Chef = subclass
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();

//GUESSING GAME
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false; //whether user out of guesses or not

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You're out of guess. Sorry, you lose!");
            }
            else
            {
                Console.WriteLine("Congratulations, you win!");
            }

//CONSTRUCTORS
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of The Rings", "Tolkein", 700);

            Console.WriteLine(book2.title);

//EXCEPTION HANDLING
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally //always gonna get executed no matter what
            {

            }
    
    //MADLIBS
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are "+ color);
            Console.WriteLine(pluralNoun +" are blue");
            Console.WriteLine("I Love "+ celebrity);

            Console.ReadLine();


 //STRING BUILDER (efficient memory)
            StringBuilder newString = new StringBuilder();

            //methods
            //to add smtg to the string
            newString.Append('-', 6);
            newString.Append(" Here is a title! ");
            newString.Append('-', 6);

            //start new line in the output
            newString.AppendLine();
            newString.Append("And here is a paragraph!");

            //replace smtg in the string
            newString.Replace("And here is a paragraph!", "Whoops!!");

            //remove first space all the way to the 30th space
            newString.Remove(0, 30);

            //insert number 30
            newString.Insert(0, 30);
            Console.WriteLine(newString);

            //More optimal way by chaining

            StringBuilder anotherString = new StringBuilder("Hi Jaspreet ");

            //put all in one. append then append a new string in the next line
            anotherString.Append("How are you? ").AppendLine().Append("I am great");
            Console.WriteLine(anotherString);

 * //STRING CLASS
    string someText = "Daniel is teaching about strings";

    Console.WriteLine(someText.ToLower());
    Console.WriteLine(someText.ToUpper());

    //take out white space
    Console.WriteLine(someText.Trim());

    //to find substring in the string
    Console.WriteLine(someText.IndexOf("about"));
    Console.WriteLine(someText.LastIndexOf("i"));

    //start at a certain place in the string
    Console.WriteLine(someText.Substring(2, 4));
    //replace a part of the string
    Console.WriteLine(someText.Replace("Jaspreet", "John"));
    //insert in a certain spot 
    Console.WriteLine(someText.Insert(6, " Nielsen"));

    //check if the string is null/empty or not
    Console.WriteLine(String.IsNullOrEmpty(someText));
    Console.WriteLine(String.IsNullOrWhiteSpace(someText));

    //When user enter data, always receive as string
    string stringNum = "1991";
    //Throws an exeption if null is empty
    int intNum = int.Parse(stringNum);
    //Returns 0 if null/empty
    int intNum2 = Convert.ToInt32(stringNum);
    //To convert it back to a string
    string stringNum2 = intNum.ToString();


//DATETIME
// parameters : (year, month, day, hour, min, sec);
    var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
    Console.WriteLine(date1);

    var date2 = DateTime.Now;
    var date3 = DateTime.UtcNow;
    var date4 = DateTime.Today;
    Console.WriteLine(date2);
    Console.WriteLine(date3);
    Console.WriteLine(date4);

 //Adding or Subtracting days/time
    var tomorrow = date2.AddDays(1);
    Console.WriteLine(tomorrow);

 //DateTime formats
    Console.WriteLine(date2.ToLongDateString());
    Console.WriteLine(date2.ToShortDateString());
    Console.WriteLine(date2.ToLongTimeString());
    Console.WriteLine(date2.ToLongTimeString());

 //Custom DateTime format
    Console.WriteLine(date2.ToString());
    Console.WriteLine(date2.ToString("yy-MM-dd"));

 //ARRAY
    string[] names = new string[4] { "J", "Jas", "Jassy", "Jaspreet" };
    Console.WriteLine(names[1]);

 //RECTANGULAR ARRAY
    var namesList = new string[4, 2]
    {
        { "J", "21y"},
        { "Jas", "34y"},
        { "Jassy", "22y"},
        { "Jaspreet", "25y"}
    };
    Console.WriteLine(namesList[1,0]);

    var namesList2 = new string[2, 2, 3]
    {
         {
              { "J", "21y", "eye color is brown"},
              { "Jas", "34y", "eye color is blue"}
          },
          {
               { "Jassy", "21y", "eye color is brown"},
               { "Jaspreet", "34y", "eye color is blue"}
           },
         };
    Console.WriteLine(namesList2[1,0,1]);

    //JAGGED ARRAY
    var namesList3 = new int[4][];
    namesList3[0] = new int[2];
   namesList3[1] = new int[3];
    namesList3[2] = new int[1];
     namesList3[3] = new int[3];
    
    namesList3[0][0] = 5;
    namesList3[0][1] = 3;

            Console.WriteLine(namesList[1,0]);

//FOR LOOP
    for (int i =0; i< 10; i++)
    {
       Console.WriteLine("Loop nr "+i);
    }

//FOREACH LOOP
    string[] names = new string[4] { "Jas", "J", "Jassy", "Jaspreet" };
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }

//WHILE LOOP
    int num1 = 0;

    while (num1< 10)
    {
        Console.WriteLine("Loop nr "+num1);
        num1++;
    }

//DOWHILE LOOP
    int num2 = 0;
    do
    {
        Console.WriteLine("Loop nr " + num2);
        num2++;
     } while (num2<10);
*/

/*ENNUM AND STRUCT
 
    //autoIncreament, better assign 
    public enum ProductCodes
    {
        //constants (enum data type = integer)
        milk = 0,
        juice = 1,
        tea = 2
    }

  //use 'var' as shortcut instead of ProductCodes
    ProductCodes test = ProductCodes.milk;
    Console.WriteLine((int)test);

    int test2 = 1;
    Console.WriteLine((ProductCodes)test2);

  //enum -> string
    Console.WriteLine(test.ToString());
            
  //string -> enum
    string test3 = "tea";
    ProductCodes getProduct;
    bool checkParse = Enum.TryParse(test3, out getProduct);
    Console.WriteLine(getProduct);
*/
