while (true) {
    Console.WriteLine("Enter a date or type \"quit\" to quit:");
    string input = Console.ReadLine();

    if (input.ToLower() == "quit") {
        break;
    }
    
    else {
        try {
            DateTime enteredDate = DateTime.ParseExact(input, "dd/MM/yyyy", null);

            DateTime currentDate = DateTime.Now;

            if (enteredDate < currentDate)
            {
                TimeSpan difference = currentDate - enteredDate;
                Console.WriteLine($"{difference.Days} days have passed since {enteredDate:dd/MM/yyyy}.");
            }
            else if (enteredDate > currentDate)
            {
                TimeSpan difference = enteredDate - currentDate;
                Console.WriteLine($"{difference.Days} days remain until {enteredDate:dd/MM/yyyy}.");
            }
            else
            {
                Console.WriteLine($"{enteredDate:dd/MM/yyyy} is today.");
            }
        }
        catch (FormatException) {
            Console.WriteLine("Invalid format provided");
        }
    }
}