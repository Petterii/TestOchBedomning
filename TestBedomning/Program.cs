using System;

namespace TestBedomning
{
    class Character {
        public string name;
        public int health;
        public int strenght;
        public int luck;

        private static Random rand = new Random();
        public Character() {
            health = rand.Next(100,200);
            luck = rand.Next(1,10);
            strenght = rand.Next(20, 50);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (menu()) { 
            
            }
        }

        private static bool menu()
        {
            Console.WriteLine("----MENY--------");
            Console.WriteLine("1. Hello World!");
            Console.WriteLine("2. Personlig Info.");
            Console.WriteLine("3. Change Color.");
            Console.WriteLine("4. Current time.");
            Console.WriteLine("5. Highest Value.");
            Console.WriteLine("6. Guessing Game(100).");
            Console.WriteLine("7. Save to file.");
            Console.WriteLine("8. Read From File.");
            Console.WriteLine("9. Uppgift 9 sqrt uphöjt + uphöjt.");
            Console.WriteLine("10. Multiplikationstabell.");
            Console.WriteLine("11. TwoArraySorting.");
            Console.WriteLine("12. PalindromTest.");
            Console.WriteLine("13. NumbersBetweenInputs.");
            Console.WriteLine("14. OddAndEven.");
            Console.WriteLine("15. AddAllUpp.");
            Console.WriteLine("16. PlayerAndEnemy.");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-------------------");
            Console.Write("Your choice: ");
            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine("Hello world"); break;
                case "2": PersonligInfo(); break;
                case "3": ChangeColor(); break;
                case "4": CurrentTime(); break;
                case "5": HighestValue(); break;
                case "6": GuessingNumber(); break;
                case "7": SavetoFile(); break;
                case "8": ReadFromFile(); break;
                case "9": RotUr(); break;
                case "10": Multiplikationstabell(); break;
                case "11": TwoArraySorting(); break;
                case "12": PalindromTest(); break;
                case "13": NumbersBetweenInputs(); break;
                case "14": OddAndEven(); break;
                case "15": AddAllUpp(); break;
                case "16": PlayerandEnemy(); break;



                default: return false;
            }
            Console.WriteLine();
            Console.WriteLine("Enter to continue.");
            Console.ReadLine();

            return true;
        }

        // Hälsa, tur och styrka initieras i Character konstruktorn
        private static void PlayerandEnemy()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Lets name 2 Characters.");
            Character player = new Character();
            Character enemy = new Character();

            Console.Write("Player name: ");
            player.name = Console.ReadLine();

            Console.Write("Enemy name: ");
            enemy.name = Console.ReadLine();

            Console.WriteLine("Player name " + player.name + " , health: " + player.health +", strenght: "+ player.strenght+ " , luck: " + player.luck);
            Console.WriteLine("Enemy name " + enemy.name + " , health: " + enemy.health +", strenght: " + enemy.strenght + " , luck: " + enemy.luck);

        }

        private static void AddAllUpp()
        {
            Console.WriteLine("Write a few numbers with seprating with , :");

            string text = Console.ReadLine();
            string[] arrayText = text.Split(",");
            int[] arrayInts = new int[arrayText.Length];

            for (int i = 0; i < arrayText.Length; i++)
            {
                arrayInts[i] = Int32.Parse(arrayText[i]);
            }

            int result = 0;
            for (int i = 0; i < arrayInts.Length; i++) {
                result = result + arrayInts[i];
            }

            Console.WriteLine("The sum of the numbers are : " + result);
        }

        private static void OddAndEven()
        {
            Console.WriteLine("Write a few numbers with seprating with , :");

            string text = Console.ReadLine();
            string[] arrayText = text.Split(",");
            int[] arrayInts = new int[arrayText.Length];

            for (int i = 0; i < arrayText.Length; i++) {
                arrayInts[i] = Int32.Parse(arrayText[i]);
            }

            int temp;
            for (int j = 0; j <= arrayInts.Length - 2; j++)
            {
                for (int i = 0; i <= arrayInts.Length - 2; i++)
                {
                    if ((arrayInts[i] % 2) == 1)
                    {
                        temp = arrayInts[i + 1];
                        arrayInts[i + 1] = arrayInts[i];
                        arrayInts[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted after odd and even numbers: ");
            foreach(int i in arrayInts)
            {
                Console.Write(i+",");
            }

        }

        private static void NumbersBetweenInputs()
        {
            Console.WriteLine();
            Console.Write("Write value 1: ");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.Write("Write value 2: ");
            int input2 = Int32.Parse(Console.ReadLine());

            int temp;
            if (input1 > input2){
                temp = input1;
                input1 = input2;
                input2 = temp;
            }
            Console.WriteLine("Numbers between these two values are:");
            for (int i = input1; i < input2; i++) {
                Console.Write(i+",");
            }
            Console.WriteLine();

        }

        private static void PalindromTest()
        {
            Console.WriteLine("Palindrome Test");
            Console.WriteLine("Lets check if your word is palindrome.");
            Console.Write("Your word: ");

            String text = Console.ReadLine().ToLower();
            
            bool isPalindrome = false;
            int j = text.Length-1;
            for (int i = 0; i <= j;i++) {
                if (!text[i].Equals(text[j])) {
                    isPalindrome = false;
                    break;
                }
                    
                isPalindrome = true;
                j--;
            }
            if(isPalindrome)
                Console.WriteLine("PALINDROME grats!");
            else
                Console.WriteLine("Sad, not a palindrome!");




        }

        private static void TwoArraySorting()
        {
            Random rand = new Random();
            int[] ua = new int[10];

            for (int i = 0; i < 10; i++) {
                ua[i] = rand.Next(0,100);
            }
            Console.WriteLine();
            Console.WriteLine("Unsorted:");
            foreach (int s in ua)
                Console.Write(s + " ");

            int temp;
            for (int j = 0; j <= ua.Length - 2; j++)
            {
                for (int i = 0; i <= ua.Length - 2; i++)
                {
                    if (ua[i] > ua[i + 1])
                    {
                        temp = ua[i + 1];
                        ua[i + 1] = ua[i];
                        ua[i] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sorted:");
            foreach (int s in ua)
                Console.Write(s + " ");
        }

        private static void Multiplikationstabell()
        {
            Console.WriteLine("Multiplikations Tabell");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("     " + i);
               
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++) {
                Console.Write("| " + i);

                    for (int j = 0; j < 10; j++) {
                    if(i*j >= 10) // jämna ut lite när det blir tvåsiffrigt. Finns ett mellanslag mindre på ena.
                        Console.Write("| " + i * j + "  "); // one space less.
                    else
                        Console.Write("| "+i*j +"   "); 

                }
                Console.WriteLine();
            }
        }

        private static void RotUr()
        {
            Console.Write("Write a decimal number: ");

            double input = double.Parse(Console.ReadLine());

            input = Math.Sqrt(input);
            input = Math.Pow(input,2);
            input = Math.Pow(input, 10);

            Console.WriteLine("Final result after useing SquareRoot, power of 2 and power of 10: " + input);

        }

        private static void ReadFromFile()
        {
            string text = "";
            try {
               text = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"\WriteLines.txt");
            }
            catch { Console.WriteLine("Couldnt find file."); 
            }
            Console.WriteLine("Text in the File WriteLines.txt");
            Console.WriteLine(text);
        }

        private static void SavetoFile()
        {
            Console.WriteLine("Write something to store in a file called Writeline.txt : ");
            string text= Console.ReadLine();

            System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"\WriteLines.txt", text);

            Console.WriteLine("File saved.");

        }

        private static void GuessingNumber()
        {
            Random rand = new Random();
            int secretNr = rand.Next(0,100);
            Console.WriteLine("Secret numbers has been generated. Time for you to guess.");
            bool stillGuessing = true;
            while (stillGuessing)
            {
                Console.Write("Your guess: ");
                int guess = Int32.Parse(Console.ReadLine());

                if (guess == secretNr)
                {
                    stillGuessing = false;
                    Console.WriteLine("Correct! the number was: " + secretNr);
                }
                else if (guess > secretNr)
                    Console.WriteLine(guess + " was to HIGH!");
                else 
                    Console.WriteLine(guess + " was to LOW!");
                
            }

        }

        private static void HighestValue()
        {
            Console.WriteLine("Write Values and I tell you the highest.");
            Console.Write("Value 1: ");
            int value1 = Int32.Parse(Console.ReadLine());
            Console.Write("Value 2: ");
            int value2 = Int32.Parse(Console.ReadLine());
            int result = 0;
            if (value1 > value2)
                result = value1;
            else
                result = value2;

            Console.WriteLine("The highest of the 2 values is "+result);

        }

        private static void CurrentTime()
        {
            String time = DateTime.Now.ToString("h:mm:ss tt");

            Console.WriteLine("Current time: "+time);

        }

        private static void ChangeColor()
        {
            if (Console.ForegroundColor != ConsoleColor.Blue)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.White;
        }

        private static void PersonligInfo()
        {
            Console.Write("Firstname: ");
            String firstName = Console.ReadLine();
            Console.Write("Lastname: ");
            String lastName = Console.ReadLine();
            Console.Write("Age: ");
            String age = Console.ReadLine();

            Console.WriteLine("Your name is " + firstName + " " + lastName + " and your " + age + " years old");

        }
    }
}
