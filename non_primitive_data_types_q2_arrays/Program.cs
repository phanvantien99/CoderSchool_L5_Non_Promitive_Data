namespace non_primitive_data_types_q2_arrays;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Printing Array Elements
        // Create an array of 5 countries and then print them out to the console.
        // Hint: Use a foreach loop to print the array elements.
        Console.WriteLine("Part 1: ");
        Array names = new string[5] { "John", "Jane", "Jack", "Jill", "James" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //---------------------------------------------------------------------
        // Part 2: Accessing Array Elements by Index
        // Using the array of countries, find the name in the 3rd position and print it out to the console.
        // Hint: Use the index of the array to access the name in the 3rd position.
        Console.WriteLine("Part 2: " + names.GetValue(2));


        //---------------------------------------------------------------------
        // Part 3: Removing an Element from the Array
        // Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
        // Hint: Use the RemoveAt() method to remove an item from the array.
        Console.WriteLine("Part 3: ");
        int elementToRemove = 1;
        string[] updatedNames = new string[names.Length - 1];
        // copy the before the element
        Array.Copy(names, 0, updatedNames, 0, elementToRemove);
        // copy the after the element
        Array.Copy(names, elementToRemove + 1, updatedNames, elementToRemove, names.Length - elementToRemove - 1);
        foreach (string name in updatedNames)
        {
            Console.WriteLine(name);
        }

        //---------------------------------------------------------------------
        // Part 4: Replacing an Element in the Array
        // Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
        // Hint: Use the index of the array to replace the name in the 3rd position with a new name.
        Console.WriteLine("Part 4: ");
        names.SetValue("Test", 2);
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        
        //---------------------------------------------------------------------
        // Part 5: Finding the Length of the Array
        // Using the array of countries, find the length of the array and print it out to the console.
        // Hint: Use the Length property to find the length of the array.
        Console.WriteLine("Part 5: " + names.Length);
        
        //---------------------------------------------------------------------
        // Part 6: Checking if an Element Exists in the Array
        // Using the array of countries, check if a name exists in the array and print out if it exists or not.
        // Hint: Use the Contains() method to check if a name exists in tlhe array.
        Console.WriteLine("Part 6: Is 'Test' contained in array: " + (Array.IndexOf(names, "Test") != -1));

        //---------------------------------------------------------------------
        // Part 7: Finding the Index of an Element in the Array
        // Using the array of countries, find the index of a name in the array and print it out to the console.
        // Hint: Use the IndexOf() method to find the index of a name in the array.
        Console.WriteLine("Part 7: " + Array.IndexOf(names, "Test"));
    }
}
