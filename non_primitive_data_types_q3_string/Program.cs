namespace non_primitive_data_types_q3_string;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        //Create a program so that it concatenates three strings and then outputs the result in uppercase.
        //Hint: You can use the ToUpper() method to convert a string to uppercase.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 1: ");
        string s1 = "hello ";
        string s2 = "world, ";
        string s3 = "coder school!!";
        Console.WriteLine(s1.ToUpper() + s2.ToUpper() + s3.ToUpper());


        //Part 2
        //Create a program so that it concatenates three strings and then outputs the result in lowercase.
        //Hint: You can use the ToLower() method to convert a string to lowercase.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 2: ");
        string s1u = "HELLO ";
        string s2u = "WOLRD, ";
        string s3u = "CODER SCHOOL!!";
        Console.WriteLine(s1u.ToLower() + s2u.ToLower() + s3u.ToLower());

        //Part 3
        //Write a program to find the length of a string.
        //Hint: You can use the Length property to find the length of a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 3: ");
        string s1Length = "HELLO ";
        Console.WriteLine("Length: " + s1Length.Length);

        //Part 4
        //Write a program to find the index of a character in a string.
        //Hint: You can use the IndexOf() method to find the index of a character in a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 4: ");
        string s1GetIndex = "CODER SCHOOL!!";
        Console.WriteLine("Index of O: " + s1GetIndex.IndexOf('O'));


        //Part 5
        //Write a program to find the index of a character in a string starting from a specified position.
        //Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 5: ");
        string s2GetIndex = "CODER SCHOOL!!";
        Console.WriteLine("Index of O start from 2nd position: " + s2GetIndex.IndexOf('O', 2));

        //Part 6
        //Write a program to count the occurrences of a specific character in a string.
        //Hint: You can use the Count() method to count the occurrences of a specific character in a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 6: ");
        string s1Count = "CODER SCHOOL!!";
        Console.WriteLine("occurrences of O in the string: " + s1Count.Count(delegate (char character)
        {
            return character == 'O';
        }));

        //Part 7
        //Write a program to replace a character in a string with another character.
        //Hint: You can use the Replace() method to replace a character in a string with another character.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 7: ");
        string s1Replace = "CODER SCHOOL!!";
        Console.WriteLine("replace O with I: " + s1Replace.Replace('O', 'I'));

        //Part 8
        //Write a program to remove a character from a string.
        //Hint: You can use the Remove() method to remove a character from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 8: ");
        string s1Remove = "CODER SCHOOL!!";
        Console.WriteLine("remove character in string: " + s1Remove.Remove(6, 3));

        //Part 9
        //Write a program to replace all occurrences of a specific character in a string with another character.
        //Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 9: ");
        string s2Replace = "CODER SCHOOL!!";
        Console.WriteLine("replace C with Q: " + s2Replace.Replace('C', 'Q'));

        //Part 10
        //Write a program to extract a substring from a string.
        //Hint: You can use the Substring() method to extract a substring from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 10: ");
        string s1Substring = "CODER SCHOOL!!";
        Console.WriteLine("Substring from a string: " + s1Substring.Substring(5));

        //Part 11
        //Write a program to extract a substring from a string starting from a specified position.
        //Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 11: ");
        string s2Substring = "CODER SCHOOL!!";
        Console.WriteLine("Substring with length from a string: " + s2Substring.Substring(6, 3));

        //Part 12
        //Write a program to remove leading and trailing whitespace from a string.
        //Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 12: ");
        string s1Trim = " CODER SCHOOL!!  ";
        Console.WriteLine("Trim the string: " + s1Trim.Trim());

        //Part 13 
        //Write a program to parse a string to a number.
        //Hint: You can use the Parse() method to parse a string to a number.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 13: ");
        string s1Parse = "123";
        Console.WriteLine("Parse the string to number: " + int.Parse(s1Parse));

        //Part 14
        //Write a program to convert a number to a string.
        //Hint: You can use the ToString() method to convert a number to a string.
        //Hint: You can use the Console.WriteLine() method to output the result.
        Console.WriteLine("Part 14: ");
        int s1String = 123;
        Console.WriteLine("Parse the string to number: " + s1String.ToString());









        //////////////////Formating////////////////////
        Console.WriteLine("################# Formating ###########################");



        // Part 1

        // You're organizing a team outing and need to print personalized event invitations.
        // Develop a C# program that uses placeholders to create customized invitations.
        // Replace the placeholders with the recipient's name, event date, and current time.
        // Hint: Use composite formatting with placeholders to create personalized invitations.
        // Test Data:
        // Recipient's name: Alice
        // Event date: January 15, 2025
        // Expected Output:
        // Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.
        Console.WriteLine("Part 1: ");
        Console.Write("Recipient's name: ");
        string? name = Console.ReadLine();
        Console.Write("Event date: ");
        string? date = Console.ReadLine();
        Console.WriteLine("Hello," + name + "! You're invited to our team outing on " + date + ". The event starts at 09:00.");


        // Part 2

        // Imagine you're managing an online store and need to send order confirmation emails.
        // Write a C# program that utilizes placeholders to generate order confirmation emails.
        // Fill in the placeholders with the customer's name, order ID, and purchase details.
        // Hint: Use composite formatting with placeholders to generate order confirmation emails.
        // Test Data:
        // Customer's name: John Doe
        // Order ID: 123456
        // Purchase details: 2 x T-shirts, 3 x Jeans
        // Expected Output:
        // Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.
        Console.WriteLine("Part 2: ");
        Console.Write("Customer's name: ");
        string? customerName = Console.ReadLine();
        Console.Write("Order ID: ");
        string? orderId = Console.ReadLine();
        Console.Write("Purchase details: ");
        string? purchaseDetail = Console.ReadLine();
        Console.WriteLine("Dear " + customerName + ", your order (ID: " + orderId + ") has been confirmed. You've purchased: " + purchaseDetail);




        // Part 3

        // Picture yourself developing a task management application and need to display task reminders.
        // Create a C# program that employs placeholders to format task reminder messages.
        // Populate the placeholders with the task name, due date, and priority level.
        // Hint: Use composite formatting with placeholders to format task reminder messages.
        // Test Data:
        // Task name: Complete Project Proposal
        // Due date: May 10, 2025
        // Priority level: High
        // Expected Output:
        // Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.
        Console.WriteLine("Part 3: ");
        Console.Write("Task name: ");
        string? taskName = Console.ReadLine();
        Console.Write("Due date: ");
        string? dueDate = Console.ReadLine();
        Console.Write("Priority level: ");
        string? priorityLevel = Console.ReadLine();
        Console.WriteLine(taskName + " is due on " + dueDate + ". Priority: " + priorityLevel + ".");


        // Part 4

        // You're working on a scheduling application and need to generate event reminders.
        // Develop a C# program that utilizes placeholders to format event reminder notifications.
        // Fill in the placeholders with the event title, location, and start time.
        // Hint: Use composite formatting with placeholders to format event reminder notifications.
        // Test Data:
        // Event title: Team Meeting
        // Location: Conference Room A
        // Start time: 10:00 AM
        // Expected Output:
        // Reminder: Team Meeting at Conference Room A starts at 10:00 AM.
        Console.WriteLine("Part 4: ");
        Console.Write("Event title: ");
        string? eventName = Console.ReadLine();
        Console.Write("Location: ");
        string? location = Console.ReadLine();
        Console.Write("Start time: ");
        string? startTime = Console.ReadLine();
        Console.WriteLine(eventName + " at " + location + " starts at " + startTime + ".");



        // Part 5

        // Imagine you're designing a travel app and need to provide flight departure information.
        // Write a C# program that employs placeholders to format flight departure notifications.
        // Populate the placeholders with the flight number, departure airport, and scheduled time.
        // Hint: Use composite formatting with placeholders to format flight departure notifications.
        // Test Data:
        // Flight number: ABC123
        // Departure airport: JFK International Airport
        // Scheduled time: 08:30 AM
        // Expected Output:
        // Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.
        Console.WriteLine("Part 5: ");
        Console.Write("Flight number: ");
        string? flightNumber = Console.ReadLine();
        Console.Write("Departure airport: ");
        string? departureAirpoty = Console.ReadLine();
        Console.Write("Scheduled time: ");
        string? scheduleTime = Console.ReadLine();
        Console.WriteLine("Flight " + flightNumber + " departing from " + departureAirpoty + " is scheduled for " + scheduleTime + ".");



        // Part 6

        // You're developing a messaging application and want to greet the user.
        // Write a C# program that asks the user to enter their name.
        // Then, use interpolation to display a personalized greeting message.
        // Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
        // Test Data:
        // Enter your name: Alice
        // Expected Output:
        // Hello, Alice! Welcome to our messaging app.
        Console.WriteLine("Part 6: ");
        Console.Write("Enter your name: ");
        string? nameToMessage = Console.ReadLine();
        Console.WriteLine("Hello, " + nameToMessage + "! Welcome to our messaging app.");

        // Part 7

        // You're organizing a fantasy-themed event and need to print custom badges for the participants.
        // Develop a C# program that prompts the user to enter their character's name and class.
        // Then, concatenate the name and class, and print the result.
        // Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
        // Test Data:
        // Character's name: Legolas
        // Character's class: Archer
        // Expected Output:
        // Custom Badge: Legolas the Archer
        Console.WriteLine("Part 7: ");
        Console.Write("Character's name: ");
        string? characterName = Console.ReadLine();
        Console.Write("Character's class: ");
        string? characterClass = Console.ReadLine();
        Console.WriteLine("Custom Badge: " + characterName + "the" + characterClass + ".");

        // Part 8

        // Picture yourself managing a music playlist and need to display the total duration of a song.
        // Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
        // Prompt the user to enter the song's duration in seconds.
        // Then, calculate the minutes and seconds and display the formatted duration.
        // Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
        // Test Data:
        // Enter the song's duration in seconds: 245
        // Expected Output:
        // Song Duration: 4 minutes 5 seconds
        Console.WriteLine("Part 8: ");
        int hour, minute, second;
        int secondDuration = 0;
        int n;
        Console.Write("Enter the song's duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out n) == true)
        {
            secondDuration = n;
        }
        else
        {
            Console.WriteLine("Invalid input , Enter only number");
            return;
        }

        hour = secondDuration / 3600;
        minute = secondDuration % 3660 / 60;
        second = secondDuration % 3600 % 60;

        Console.WriteLine("Song Duration: " + hour + " hours " + minute + " minutes" + second + " seconds");


        // Part 9

        // Imagine you're developing a recipe app and want to display the serving size.
        // Create a C# program that formats and displays the serving size of a recipe.
        // Prompt the user to enter the number of servings.
        // Then, display the serving size aligned to the right with a width of 5 characters.
        // Hint: Use composite formatting with alignment to display the serving size.
        // Test Data:
        // Enter the number of servings: 8
        // Expected Output:
        // Serving Size:     8

        Console.WriteLine("Part 9: ");
        int nunmber_of_serving = 0;
        string alignLength = "     ";
        int input;
        Console.Write("Enter the number of servings: ");
        if (int.TryParse(Console.ReadLine(), out input) == true)
        {
            if (input > 99999)
            {
                Console.WriteLine("Invalid input , Enter only number");
                return;
            }
            nunmber_of_serving = input;
        }
        else
        {
            Console.WriteLine("Invalid input , Enter only number");
            return;
        }
        int lengthInput = nunmber_of_serving.ToString().Length;
        Console.WriteLine("Serving Size:" + alignLength.Substring(0, alignLength.Length - lengthInput) + nunmber_of_serving);


        // Part 10

        // You're designing a finance application and need to show the current account balance.
        // Develop a C# program that formats and displays the account balance.
        // Prompt the user to enter the account balance.
        // Then, display the balance aligned to the right with two decimal places.
        // Hint: Use composite formatting with alignment and precision to display the account balance.
        // Test Data:
        // Enter the account balance: 1050.75
        // Expected Output:
        // Account Balance: 1050.75

        Console.WriteLine("Part 10: ");
        Console.Write("Enter the account balance: ");
        decimal inputBalance = Convert.ToDecimal(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine("Account Balance: " + inputBalance);



        // Part 11

        // You're building a movie ticket booking system and need to present the ticket price.
        // Write a C# program that calculates and formats the ticket price with discounts.
        // Prompt the user to enter the ticket price and discount percentage.
        // Then, calculate the discounted price and display it aligned to the right with two decimal places.
        // Hint: Use composite formatting with alignment and precision to display the discounted price.
        // Test Data:
        // Enter the ticket price: 25.50
        // Enter the discount percentage: 15
        // Expected Output:
        // Discounted Price: 21.68

        Console.WriteLine("Part 11: ");
        Console.Write("Enter the ticket price: ");
        decimal ticketPrice = Convert.ToDecimal(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        Console.Write("Enter the discount percentage");
        decimal discountPercent = Convert.ToDecimal(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine("Discounted Price: " + (ticketPrice - (ticketPrice * discountPercent / 100)));




        // Part 12

        // Picture yourself developing a gaming platform and need to display the player's score.
        // Create a C# program that formats and displays the player's score.
        // Prompt the user to enter the player's score.
        // Then, display the score aligned to the right with a width of 8 characters.
        // Hint: Use composite formatting with alignment to display the player's score.
        // Test Data:
        // Enter the player's score: 10325
        // Expected Output:
        // Player's Score:   10325

        Console.WriteLine("Part 12: ");
        int playerScore = 0;
        string alignLengthScore = "        ";
        int inputScore;
        Console.Write("Enter the player's score: ");
        if (int.TryParse(Console.ReadLine(), out inputScore) == true)
        {
            if (inputScore > 99999)
            {
                Console.WriteLine("Invalid input , Enter only number");
                return;
            }
            playerScore = inputScore;
        }
        else
        {
            Console.WriteLine("Invalid input , Enter only number");
            return;
        }
        int lengthInputScore = playerScore.ToString().Length;
        Console.WriteLine("Player's Score:" + alignLengthScore.Substring(0, alignLengthScore.Length - lengthInputScore) + playerScore);




        // Part 13

        // You're working on a data analysis tool and need to present the statistical results.
        // Develop a C# program that formats and displays the average value of a dataset.
        // Prompt the user to enter a series of numbers separated by spaces.
        // Then, calculate the average value and display it aligned to the right with two decimal places.
        // Hint: Use composite formatting with alignment and precision to display the average value.
        // Test Data:
        // Enter a series of numbers: 10 15 20 25 30
        // Expected Output:
        // Average Value: 20.00
        Console.WriteLine("Part 13: ");
        Console.WriteLine("Enter a series of numbers: ");
        string? array_input = Console.ReadLine();
        decimal averageValue = 0;
        if (array_input != null)
        {
            string[] stringInput = array_input.Split(" ");
            if (stringInput.Length > 0)
            {
                int total = 0;
                foreach (string item in stringInput)
                {
                    total += int.Parse(item);
                }
                averageValue = Convert.ToDecimal(total / stringInput.Length, System.Globalization.CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Average Value: " + averageValue);
        }


        // Part 14

        // Imagine you're designing a weather app and need to show the temperature forecast.
        // Write a C# program that calculates and formats the average temperature.
        // Prompt the user to enter the temperatures for three days separated by spaces.
        // Then, calculate the average temperature and display it aligned to the right with one decimal place.
        // Hint: Use composite formatting with alignment and precision to display the average temperature.
        // Test Data:
        // Enter temperatures for 3 days: 25.5 28.7 22.3
        // Expected Output:
        // Average Temperature: 25.5
        Console.WriteLine("Part 14: ");
        Console.Write("Enter temperatures for 3 days (separated by spaces): ");
        string input = Console.ReadLine();
        string[] temperatureStrings = input.Split(' ');

        decimal totalTemperature = 0;
        int validCount = 0;

        foreach (string tempString in temperatureStrings)
        {

            totalTemperature += Convert.ToDecimal(tempString, System.Globalization.CultureInfo.InvariantCulture);
            validCount++;

        }

        if (validCount > 0)
        {
            decimal averageTemperature = totalTemperature / validCount;
            Console.WriteLine($"Average Temperature: {averageTemperature,10:F1}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numeric temperatures.");
        }

        // Part 15

        // You're building a fitness tracker and need to present the daily step count.
        // Create a C# program that formats and displays the total steps for a day.
        // Prompt the user to enter the steps taken.
        // Then, display the step count aligned to the right with a width of 6 characters.
        // Hint: Use composite formatting with alignment to display the step count.
        // Test Data:
        // Enter the steps taken: 12345
        // Expected Output:
        // Step Count:  12345

        Console.WriteLine("Part 15: ");
        int step_taken = 0;
        string alignLengthStep = "      ";
        int inputStep;
        Console.Write("Enter the number of servings: ");
        if (int.TryParse(Console.ReadLine(), out inputStep) == true)
        {
            if (inputStep > 99999)
            {
                Console.WriteLine("Invalid input , Enter only number");
                return;
            }
            step_taken = inputStep;
        }
        else
        {
            Console.WriteLine("Invalid input , Enter only number");
            return;
        }
        int lengthInputStep = step_taken.ToString().Length;
        Console.WriteLine("Serving Size:" + alignLengthStep.Substring(0, alignLengthStep.Length - lengthInputStep) + step_taken);




    }
}
