// Daniel Decoito
// 10-20-2022 2:34 PM
// Mini challenge 7 "Reverse it"
// ask user to input either digits, letters, or both then return thier input foward and reversed
// Peer reviewed by: Daniel Decoito - Really good app. worked well without issues and had good use of valadation along every choice. The Code itself was excellent, very concise. I really liked the use of difficulty input to dictate the random number range.

Console.Clear();
Int64 dataSelect = 0;
Int64 intParseCheck;
Int64 userNum;
int switchParseCheck;
string terminateGame = ".";
string charCheckInput = "Dan is Cool";
string numInput;
string switchInput;
bool endParse = true;
bool charBoolCheck = false;
bool switchCheck = true;


Console.WriteLine("Hello user, Lets play Reverse it. Choose to enter either a string of alphabetical characters, a series of intergers, or both alphabetical characters and intergers combined. ");

while (terminateGame != "")
{

    while (switchCheck)
    {
        Console.WriteLine("Press 1 for integer data \nPress 2 for string data \nPress 3 for alphabetical characters and intergers");
        switchInput = Console.ReadLine();
        if (int.TryParse(switchInput, out switchParseCheck))
        {
            dataSelect = switchParseCheck;
            switchCheck = false;
        }
        else
        {
            Console.WriteLine("Please enter 1 or 2.");
            switchCheck = true;
        }


        switch (dataSelect)
        {
            case 1:
                Console.WriteLine("Please enter a sequence of integers no more than 19 digits long.");
                numInput = Console.ReadLine();
                while (endParse == true)
                {
                    if (Int64.TryParse(numInput, out intParseCheck))
                    {
                        userNum = intParseCheck;
                        endParse = false;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorect input \nPlease enter a series of integers no more than 19 digits long.");
                        numInput = Console.ReadLine();
                    }
                }
                endParse = true;
                switchCheck = false;
                char[] intArray = numInput.ToCharArray();
                Console.WriteLine("Your Number");
                for (int i = 0; i < intArray.Length; i++)
                {

                    Console.Write(intArray[i]);

                }

                Console.WriteLine("");
                Console.WriteLine("----REVERESED----");

                for (int j = intArray.Length - 1; j > -1; j--)
                {
                    Console.Write(intArray[j]);

                }
                Console.WriteLine("");
                break;

            case 2:
                while (charBoolCheck == false)
                {
                    Console.Clear();
                    Console.WriteLine("Input only alpahbetical characters with no spaces");
                    charCheckInput = Console.ReadLine();
                    charBoolCheck = charCheckInput.All(Char.IsLetter);
                }

                Console.Clear();
                char[] charArray = charCheckInput.ToCharArray();
                Console.WriteLine("Your word");

                for (int k = 0; k < charArray.Length; k++)
                {
                    Console.Write(charArray[k]);
                }
                Console.WriteLine("");
                Console.WriteLine("----REVERESED----");

                for (int l = charArray.Length - 1; l > -1; l--)
                {
                    Console.Write(charArray[l]);
                }
                Console.WriteLine("");

                break;

            case 3:
                Console.Clear();

                Console.WriteLine("Enter in string data with or without spaces or numbers. Go wild.");
                charCheckInput = Console.ReadLine();

                char[] charIntArray = charCheckInput.ToCharArray();
                Console.Clear();
                Console.WriteLine("Your word");

                for (int m = 0; m < charIntArray.Length; m++)
                {
                    Console.Write(charIntArray[m]);
                }
                Console.WriteLine("");
                Console.WriteLine("----REVERESED----");

                for (int n = charIntArray.Length - 1; n > -1; n--)
                {
                    Console.Write(charIntArray[n]);
                }
                Console.WriteLine("");
                break;

            default:
                Console.Clear();
                switchCheck = true;
                Console.WriteLine("Incorect input");
                Console.WriteLine("Please");
                break;
        }
    }
    Console.WriteLine("\nPlay again??? \npress any key followed by enter to play again. \nIf you would like to end just press enter key.");
    terminateGame = Console.ReadLine();
    switchCheck = true;
    charBoolCheck = false;
}
Console.Clear();
Console.WriteLine("Thanks for Playing.");

