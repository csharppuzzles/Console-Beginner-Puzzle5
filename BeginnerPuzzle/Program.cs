
using System.Runtime.CompilerServices;

static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Q: Have you ever farted in an elevator?");
    Console.WriteLine("Enter \"y\" for yes or \"n\" for no: ");
    string? input = Console.ReadLine();

    if (input != "" && input != null)
    {
        if (input.ToLower() == "y" || input.ToLower() == "yes") {

            Console.BackgroundColor = ConsoleColor.Red;                     // Change the BACKGROUND color of the console text
            Console.WriteLine("Warning: This is Reeeeeeally important!");
            Console.ResetColor();                                           // Put the console color back to normal.

            Console.WriteLine("How many people were in the elevator? :");
            int? fartVictimNum = Convert.ToInt32(Console.ReadLine());

            // Switch statement
            switch (fartVictimNum)
            {
                case < 0:
                    Console.WriteLine("Were they... Ghosts?");
                    break;
                case 1:
                    Console.WriteLine("Whoever that person was, they were disapointed in you...");
                    break;
                case 2:
                    Console.WriteLine("2 people? Well, everyone can blame each other.");
                    break;
                case 3:
                    Console.WriteLine($"{fartVictimNum} people in the elevator, how could you?");
                    break;
                default:
                    Console.WriteLine($"{fartVictimNum}!!! That's a target rich environment. Those poor people!");
                    break;
            }

        } else
        {
            Console.WriteLine("No? I don't believe you. Someone has probably done it to you though, right?");
        }

    } else
    {
        Console.WriteLine("Error. You can't just enter blank space");
    }

}


// Puzzle A - Workout of the day
// Write a program that provides a fitness exercise for the user to do, depending on what day of the week it is.
// Ask the user for the weekday.
//      "What day is it?: "
// Use a SWITCH statement to print out an exercise. The exercise should be different for each day.
// Make the console text a different COLOR for each day. NOT background color, make the text letter color different.
//      "Monday: 20 Sit ups"             (red text)
//      "Tuesday: 15 jumping jacks"     (blue text)
//      "Wednesday: 20 press ups"       (green text)
//      "Thursday: 10 burpees"          (yellow text)
//      ...
// Remember to convert the user's input to lowercase before comparison.
// Have a "default case" should the user not enter a weekday.


static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("What day is it?: ");
    string? input = Console.ReadLine();

    if (input != "" && input != null)
    {

        // Switch statement
        switch (input.ToLower())
        {
            case "monday":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Monday: 20 Sit ups");
                Console.ResetColor();
                break;
            case "tuesday":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tuesday: 15 jumping jacks");
                Console.ResetColor();
                break;
            case "wednesday":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wednesday: 20 press ups");
                Console.ResetColor();
                break;
            case "thursday":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Thursday: 10 burpees");
                Console.ResetColor();
                break;
            case "friday":
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Friday: 15min jog");
                Console.ResetColor();
                break;
            case "saturday":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Saturday: 20 barbell curls");
                Console.ResetColor();
                break;
            case "sunday":
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sunday: 15 min jog");
                Console.ResetColor();
                break;
            default:
                // This will run only if they don't type a day of the week
                Console.WriteLine($"20 bear crawls");
                break;
        }
    }
    else
    {
        Console.WriteLine("Error. You can't just enter blank space");
    }
}



static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    // Unicode colors
    string red = "\u001B[31m";
    string blue = "\u001B[34m";
    string green = "\u001B[32m";
    string reset = "\u001B[0m";

    Console.WriteLine("Choose a color: Red, Blue or Green: ");
    string? input = Console.ReadLine();

    if(input != null && input != "" && input.Length > 0)
    {
        string inputLowerCase = input.ToLower();            // This preserves the original input variable, incase we need it later.

        // This would override the input variable from now on. We could then just use "input" in the if statement but could not get the original back.
        //input = input.ToLower();                         

        if (inputLowerCase == "red" || inputLowerCase == "r")
        {
            Console.WriteLine($"{red} You chose Red... {reset} thanks!");
        }
        else if (inputLowerCase == "blue" || inputLowerCase == "b")
        {
            Console.WriteLine($"{blue} You chose Blue... {reset} thanks!");
        }
        else if (inputLowerCase == "green" || inputLowerCase == "g")
        {
            Console.WriteLine($"{green} You chose Green... {reset} thanks!");
        }
        else
        {
            Console.WriteLine("Sorry, no matching color...");
        }
    }
    else
    {
        Console.WriteLine("Sorry, I did not understand...");
    }

}


// Puzzle B - Color me in
// Re-write the above example program to use a SWITCH statement
// Use the unicode colors Cyan, Yellow and Magenta instead of red, blue and green.
// You might get confused with how to add "||" into the switch statement. Clue, it isn't "||".
// You should not need the null check for the switch as the default case should catch it.

static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");

    string cyan = "\u001B[36m";
    string yellow = "\u001B[33m";
    string magenta = "\u001B[35m";
    string reset = "\u001B[0m";

    Console.WriteLine("Choose a color: Cyan, Yellow or Magenta: ");
    string? input = Console.ReadLine();

    switch (input.ToLower())
    {
        case "cyan":
        case "c":
            Console.WriteLine($"{cyan} You chose Cyan... {reset} thanks!");
            break;
        case "yellow":
        case "y":
            Console.WriteLine($"{yellow} You chose Yellow... {reset} thanks!");
            break;
        case "magenta":
        case "m":
            Console.WriteLine($"{magenta} You chose Magenta... {reset} thanks!");
            break;
        default:
            Console.WriteLine("Sorry, no matching color...");
            break;
    }

    // The 'or' keyword is also acceptable
    /*
    switch (input.ToLower())
    {
        case "cyan" or "c":
            Console.WriteLine($"{cyan} You chose Cyan... {reset} thanks!");
            break;
        case "yellow" or "y":
            Console.WriteLine($"{yellow} You chose Yellow... {reset} thanks!");
            break;
        case "magenta" or "m":
            Console.WriteLine($"{magenta} You chose Magenta... {reset} thanks!");
            break;
        default:
            Console.WriteLine("Sorry, no matching color...");
            break;
    }
    */

}


static void ExampleC()
{
    Console.WriteLine("\nExample C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("2 ? 5 = ?");
    Console.WriteLine("Enter an operator and we will complete this sum...");
    Console.WriteLine("Enter \"+\" or \"-\" :");
    string? input = Console.ReadLine();


    switch (input)
    {
        case "+":
            int addAns = 2 + 5;
            Console.WriteLine($"2 + 5 = {addAns}");
            break;
        case "-":
            int minusAns = 2 - 5;
            Console.WriteLine($"2 - 5 = {minusAns}");
            break;
        default:
            Console.WriteLine("Error, enter only + or - ");
            break;
    }
}


// Puzzle C - Maths Switch
// Write a program using a switch statement, that allows the user to enter 2 numbers and choose the operator + - * /
// So the user could enter "2" then "*" then "7" in 3 separate input prompts.
// They will get the answer "2 * 7 = 14"

static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Enter a number :");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter \"+\" or \"-\" or \"*\" or \"/\":");
    string? operatorInput = Console.ReadLine();

    Console.WriteLine("Enter a second number :");
    int num2 = Convert.ToInt32(Console.ReadLine());

    switch (operatorInput)
    {
        case "+":
            int addAns = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {addAns}");
            break;
        case "-":
            int minusAns = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {minusAns}");
            break;
        case "*":
            int multiplyAns = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {multiplyAns}");
            break;
        case "/":
            int divideAns = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine($"{num1} / {num2} = {divideAns} remainder {remainder}");

            // You could also use a double for the division.
            double divideAns2 = (double)num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {divideAns2}");
            break;
        default:
            Console.WriteLine("Error, enter only + or - or * or / ");
        break;
    }

}




// Run the puzzles

ExampleA();
//PuzzleA();

ExampleB();
//PuzzleB();

ExampleC();
//PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter