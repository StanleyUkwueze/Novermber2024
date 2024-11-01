//build a Simple calculator
//Features:
//#1 Add 2 numbers
//#2 Subtract a number from another number
//#3 Multiply 2 numbers
//#4 Divide a number by another non-zero number
//Error Handling: Ensure that user provides valid inputs... valid inputs are valid numbers

//Opeartions: Addition, Subtraction, Division and Multiplication

static bool ValidateInput(string input)
{
    if(input.All(Char.IsDigit))
    {
        return true;
    }
    return false;
}

static double ActualOperation(string? operation, double number1, double number2)
{
    double result = 0;
    if (operation == "+")
    {
        result = number1 + number2;
    }
    else if (operation == "-")
    {
        result = number1 - number2;

    }
    else if (operation == "*")
    {

        result = number1 * number2;

    }
    else if (operation == "/")
    {
        result = (number1 / number2);
    }

    return result;
}

static bool IsValidOperator(string operation)
{
    if(operation == "+" || operation == "-" || operation == "*" || operation == "/")
    {
        return true;
    }
    return false;
}
var repeat = false;

do
{
    Console.WriteLine("Which operation do you want to perform? (+, -, *, /)");
    var isValidInPut = false;

    var operation = Console.ReadLine();

    while (!IsValidOperator(operation!))
    {
        Console.WriteLine("Kindly provide a valid operator (+, -, *, /)");

        operation = Console.ReadLine();
    }

    Console.WriteLine("Enter Your first Number");

    var input1 = Console.ReadLine();

    while (!ValidateInput(input1!))
    {
        Console.WriteLine("Enter a valid input");
        input1 = Console.ReadLine();
    }

    Console.WriteLine("Enter your second number");

    var input2 = Console.ReadLine();

    while(input2 == "0" && operation == "/")
    {
        Console.WriteLine("Enter a valid input (Cannot divide by 0)");
        input2 = Console.ReadLine();
    }

    while (!ValidateInput(input2))
    {
        Console.WriteLine("Enter a valid input");
        input2 = Console.ReadLine();
    }

    var number1 = Convert.ToDouble(input1);
    var number2 = Convert.ToDouble(input2);
    double result = ActualOperation(operation, number1, number2);

    Console.WriteLine($"The result of your operation is: {result}");

    Console.WriteLine("Do you want to perform another operation? (yes/no)");

    var choice = Console.ReadLine();

    if (choice!.ToLower() == "yes")
    {
        repeat = true;
    }
    else
    {
        repeat = false;
    }

} while (repeat);



