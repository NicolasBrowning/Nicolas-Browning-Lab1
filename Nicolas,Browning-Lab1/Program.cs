using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicolas_Browning_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadInteger("amount", 1, 100);

            /*string item = string.Empty;
            ReadString("item", ref item);
            Console.WriteLine(" you typed: " + item);
            */
            string speech = GetSpeech();
            List<string> words = Splitter(speech);
            int choice = 0;
            string[] menu = new string[] { "The Speech", "List of Words", "Show Histogram", "Search for Word", "Remove Word", "exit" };

            var counter = new Dictionary<string, int>();
            

            while (choice != 6)
            {
                ReadChoice("choice", menu, out choice);
                switch (choice - 1)
                {
                    case 0: 
                        Console.Clear(); 
                        Console.WriteLine("You've chosen option 1\n");
                        Console.WriteLine(speech);
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear(); 
                        Console.WriteLine("You've chosen option 2\n");
                        for (int i = 0; i < words.Count; i++)
                        {
                            Console.WriteLine(" " + words[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You've chosen option 3\n");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You've chosen option 4\n");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("You've chosen option 5\n");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Exiting...");
                        break;
                }
            }

            Console.ReadKey();
        }

        private static int ReadInteger(string promt, int min, int max)
        {
            Console.Write($"Give me a number between {min} and {max} for the {promt}...  ");
            int a;
            do
            {
                try////perfect loop for preventing crashes
                {
                    a = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\nThats not a number, do it right...  ");
                }
            } while (true);
            while (a > max || a < min)
            {
                Console.Write("\nInput exceeds expected range, retype input...  ");
                a = int.Parse(Console.ReadLine());
            }
            return a;
        }

        private static void ReadString(string promt, ref string value)
        {
            Console.Write($"Tell me your {promt}...  ");
            value = Console.ReadLine();
            while (string.IsNullOrEmpty(value))
            {
                Console.Write("\nMake sure you type something...  ");
                value = Console.ReadLine();
            }
        }

        private static void ReadChoice(string promt, string[]options, out int selection)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($" {i + 1}. {options[i]} ");
            }
            Console.Write($"\nSelect your {promt}. ");
            selection = ReadInteger(promt, 1, options.Length);
        }

        static string GetSpeech()
        {

            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
                "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
                "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
                "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
                "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
                "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
                "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
                "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
                "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
                "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
                "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
                "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
                "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
                "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";
            return text;
        }

        static List<string> Splitter(string speech)
        {
            int a = 0;
            string[] temp = speech.Split(new char[] { ' ' });
            List<string> words = new List<string>();
            while (words.Count != temp.Length)
            {
                words.Add(temp[a]);
                a++;
            }
            return words;
        }

        
    }
}
