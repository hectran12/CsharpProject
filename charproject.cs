using System;
using System.Text;
namespace charproject
{
    class Program { 
    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                try
                {
                    bar(30);
                    AuthProject();
                    bar(30);
                    Menu();
                    bar(30);
                    Console.Write("Input number in menu: ");
                    int numberchoose;
                    numberchoose = Convert.ToInt32(Console.ReadLine());
                    bar(30);
                    string text;
                    Console.Write("Write your text: ");
                    text = Console.ReadLine();
                    bar(30);
                    if (numberchoose == 1)
                    {
                        lower(text);
                    }
                    else if (numberchoose == 2)
                    {
                        Upper(text);
                    }
                    else if (numberchoose == 3)
                    {
                        Digit(text);
                    }
                    else if (numberchoose == 4)
                    {
                        WhiteSpace(text);
                    }
                    else if (numberchoose == 5)
                    {
                        All(text);
                    }
                }
                catch
                {
                    Console.WriteLine("Error!");
                }
                bar(30);
                Console.Write("Enter để tiếp tục");
                Console.ReadLine();
                Console.Clear();
               
                
            }
           
        }
        /// <summary>
        /// all function
        /// </summary>
        /// <param name="text">text input</param>
        static void All (string text)
        {
            char[] arr = text.ToCharArray();
            int lower = 0, upper = 0, digit = 0, whitespace = 0, allo=0;
            string textok1 = "", textno1 = "";
            string textlower = "", textupper = "", textdigit = "", textwhitespace = "", textno="";
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                {
                    lower++;
                    textlower += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: lower]\n";
                } else if (char.IsUpper(arr[i]))
                {
                    upper++;
                    textupper += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: upper]\n";
                } else if (char.IsDigit(arr[i]))
                {
                    digit++;
                    textdigit += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: digit]\n";
                } else if (char.IsWhiteSpace(arr[i]))
                {
                    whitespace++;
                    textwhitespace += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: whitespace]\n";
                } else
                {
                    allo++;
                    textno += text[i];
                    textno1 += "[Char: " + text[i] + " local:" + i + " type: unknow]\n";
                }
            }
            Console.WriteLine("AllCount: " + text.Length);
            Console.WriteLine("AllCountLower: " + lower);
            Console.WriteLine("AllCountUpper: " + upper);
            Console.WriteLine("AllCountDigit: " + digit);
            Console.WriteLine("AllCountWhiteSpace: " + whitespace);
            Console.WriteLine("Allcountunknow: " + allo);
            Console.WriteLine("CharLower: " + textlower);
            Console.WriteLine("CharUpper: " + textupper);
            Console.WriteLine("CharDigit: " + textdigit);
            Console.WriteLine("CharWhiteSpace: " + textwhitespace);
            Console.WriteLine("CharUnknow: " + textno);
            Console.WriteLine(textok1 + textno1);
        }
        /// <summary>
        /// LOWER FUNCTION
        /// </summary>
        /// <param name="text">text input</param>
        static void lower(string text)
        {
            char[] arr = text.ToCharArray();
            int allt = 0, allo = 0;
            string textok = "", textno = "", textok1 = "", textno1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    allt++;
                    textok += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: lower]\n";
                }
                else
                {
                    allo++;
                    textno += text[i];
                    textno1 += "[Char: " + text[i] + " local:" + i + " type: unknow]\n";
                }
            }
            Console.WriteLine("AllCount: " + text.Length);
            Console.WriteLine("AllcountLower: " + allt);
            Console.WriteLine("Allcountunknow: "+ allo);
            Console.WriteLine("CharLower: " + textok);
            Console.WriteLine("CharUnknow: "+textno);
            Console.WriteLine(textok1 + textno1);
        }
        /// <summary>
        /// Upper FUNCTION
        /// </summary>
        /// <param name="text">text input</param>
        static void Upper(string text)
        {
            char[] arr = text.ToCharArray();
            int allt = 0, allo = 0;
            string textok = "", textno = "", textok1 = "", textno1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    allt++;
                    textok += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: Upper]\n";
                }
                else
                {
                    allo++;
                    textno += text[i];
                    textno1 += "[Char: "+text[i]+" local:" + i + " type: unknow]\n";
                }
            }
            Console.WriteLine("AllCount: " + text.Length);
            Console.WriteLine("AllcountUpper: " + allt);
            Console.WriteLine("Allcountunknow: " + allo);
            Console.WriteLine("CharUpper: " + textok);
            Console.WriteLine("CharUnknow: " + textno);
            Console.WriteLine(textok1 + textno1);
        }
        /// <summary>
        /// Digit FUNCTION
        /// </summary>
        /// <param name="text">text input</param>
        static void Digit(string text)
        {
            char[] arr = text.ToCharArray();
            int allt = 0, allo = 0;
            string textok = "", textno = "", textok1 = "", textno1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    allt++;
                    textok += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: Digit]\n";
                }
                else
                {
                    allo++;
                    textno += text[i];
                    textno1 += "[Char: " + text[i] + " local:" + i + " type: unknow]\n";
                }
            }
            Console.WriteLine("AllCount: " + text.Length);
            Console.WriteLine("AllcountDigit: " + allt);
            Console.WriteLine("Allcountunknow: " + allo);
            Console.WriteLine("CharDigit: " + textok);
            Console.WriteLine("CharUnknow: " + textno);
            Console.WriteLine(textok1 + textno1);
        }
        /// <summary>
        /// WhiteSpace FUNCTION
        /// </summary>
        /// <param name="text">text input</param>
        static void WhiteSpace(string text)
        {
            char[] arr = text.ToCharArray();
            int allt = 0, allo = 0;
            string textok = "", textno = "", textok1 = "", textno1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]))
                {
                    allt++;
                    textok += text[i];
                    textok1 += "[Char: " + text[i] + " local:" + i + " type: WhiteSpace]\n";
                }
                else
                {
                    allo++;
                    textno += text[i];
                    textno1 += "[Char: " + text[i] + " local:" + i + " type: unknow]\n";
                }
            }
            Console.WriteLine("AllCount: " + text.Length);
            Console.WriteLine("AllcountWhiteSpace: " + allt);
            Console.WriteLine("Allcountunknow: " + allo);
            Console.WriteLine("CharWhiteSpace: " + textok);
            Console.WriteLine("CharUnknow: " + textno);
            Console.WriteLine(textok1 + textno1);
        }
        /// <summary>
        /// infoment project
        /// </summary>
        static void AuthProject()
        {
            string nameauth, nameproject, description, version;
            nameauth = "Trong Hoa ( github: hexzzz2008)";
            nameproject = "Count char";
            description = "check numeric characters.";
            version = "0.0.1";
            Console.WriteLine("Auth: "+ nameauth);
            Console.WriteLine("Project: "+ nameproject);
            Console.WriteLine("Description: "+ description);
            Console.WriteLine("Verison: "+ version);
        }
        

        /// <summary>
        /// bar
        /// </summary>
        /// <param name="amount">amount print the screen</param>
        static void bar(int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Menu
        /// </summary>
        static void Menu()
        {
            string menu;
            menu = "Input [1] find all lower character in text\n";
            menu += "Input [2] find all upper character in text\n";
            menu += "Input [3] find all Digit character in text\n";
            menu += "Input [4] find all WhiteSpace character in text\n";
            menu += "Input [5] find all full function\n";
            Console.Write(menu);
        }


    }

}

