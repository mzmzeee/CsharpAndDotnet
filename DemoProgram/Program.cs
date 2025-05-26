NicksCoolCalculator calculator = new(
    "Welcome to Nick's Cool Calculator!");
calculator.Start();

public sealed class NicksCoolCalculator
{
    private string _greeting;

    public NicksCoolCalculator(string greeting)
    {
        _greeting = greeting;
    }

    public void Start()
    {
        Console.WriteLine(_greeting);

        Dictionary<string, string> supportedOperators = new()
        {
            { "+", "Add" },
            { "/", "Divide" },
            {"-", "Subtract"},
            {"*" , "multiplie"},
            {"t","exit"}
        };

        while (true)
        {
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.WriteLine("Enter an operator:");
            string operatorChoice = Console.ReadLine();
            if (operatorChoice == "t") Environment.Exit(0);

            if (!supportedOperators.TryGetValue(
                operatorChoice,
                out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid operator choice.");
                continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine(
                $"Recall that doubles are on the range " +
                $"{double.MinValue} to {double.MaxValue}!");
            Console.WriteLine();

            Console.WriteLine("Enter the first double:");
            string firstNumberInput = Console.ReadLine();
            if (!double.TryParse(firstNumberInput, out double firstNumber))
            {
                Console.WriteLine(
                    $"{firstNumberInput} could not be parsed as an double!");
                continue;
            }

            Console.WriteLine("Enter the second double:");
            string secondNumberInput = Console.ReadLine();
            if (!double.TryParse(secondNumberInput, out double secondNumber))
            {
                Console.WriteLine($"{secondNumberInput} could not be parsed as a double.");
                continue;
            }

            double result;
            try
            {
                result = operatorChoice switch
                {
                    "+" => firstNumber + secondNumber,
                    "/" => firstNumber / secondNumber,
                    "-" => firstNumber - secondNumber,
                    "*" => firstNumber * secondNumber,
                    _ => throw new NotSupportedException(
                        $"Arithmetic is not currently supported " +
                        $"for operator {operatorChoice}.")
                };
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"There was an unhandled exception: {ex.Message}");
                continue;
            }

            Console.WriteLine($"The result is: {result:f1}");
        }
    }
}