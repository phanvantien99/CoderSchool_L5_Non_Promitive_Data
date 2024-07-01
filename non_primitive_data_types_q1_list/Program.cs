namespace non_primitive_data_types_q1_list;

class Program
{
    static void Main(string[] args)
    {

        //Part 1
        //Create a list of 5 names and then print them out to the console.
        //Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
        List<string> listString = new List<string>();
        listString.Add("Alex");
        listString.Add("John");
        listString.Add("David");
        listString.Add("Chain");
        listString.Add("Jack");
        Console.WriteLine("Part 1: ");
        listString.ForEach(delegate (string name)
        {
            Console.WriteLine(name);
        });

        //Part 2
        //Using the list of names and find the name in the 3rd position and print it out to the console.
        //Hint: You can use the index of the list to find the name in the 3rd position.
        Console.WriteLine("Part 2: ");
        Console.WriteLine(listString[2]);

        //Part 3
        //Using the list of names, remove the name in the 2nd position and then print the list out to the console.
        //Hint: You can use the RemoveAt() method to remove an item from the list.
        Console.WriteLine("Part 3: ");
        listString.RemoveAt(1);
        listString.ForEach(delegate (string name)
        {
            Console.WriteLine(name);
        });

        //Part 4
        //Using the list of names, add a new name to the list and then print the list out to the console.
        //Hint: You can use the Add() method to add a new name to the list.
        listString.Add("Butcher");
        Console.WriteLine("Part 4: ");
        listString.ForEach(delegate (string name)
        {
            Console.WriteLine(name);
        });

        //Part 5
        //Using the list of names , find the length of the list and print it out to the console.
        //Hint: You can use the Count property to find the length of the list.
        Console.Write("Part 5: ");
        Console.Write(listString.Count());

        //Part 6
        //Using the list of names , check if a name exists in the list and print out if it exists or not.
        //Hint: You can use the Contains() method to check if a name exists in the list.
        Console.WriteLine("\nPart 6: ");
        listString.ForEach(delegate (string name)
        {
            if (name.Contains('a'))
            {
                Console.WriteLine(name);
            }
        });

        //Part 7
        //Using the list of names, find the index of a name in the list and print it out to the console.
        //Hint: You can use the IndexOf() method to find the index of a name in the list.
        Console.WriteLine("Part 7: ");
        Console.WriteLine("Index of: " + listString.IndexOf("Alex"));

        //Part 8
        //Using the list of names, insert a new name at the 3rd position and print the list out to the console.
        //Hint: You can use the Insert() method to insert a new name at a specific position in the list.
        Console.WriteLine("Part 8: ");
        listString.Insert(2, "Timmy");
        listString.ForEach(delegate (string name)
        {
            Console.WriteLine(name);
        });

        //Part 9
        //Using the list of names, sort the list and print it out to the console.
        //Hint: You can use the Sort() method to sort the list.
        Console.WriteLine("Part 9: ");
        listString.Sort();
        listString.ForEach(delegate (string name)
        {
            Console.WriteLine(name);
        });

        //Part 10
        //Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
        //Hint: You can use the FindLastIndex() method to find the last index of a name in the list.
        int lastIndexOf = listString.FindLastIndex(delegate (string name) {
            return name == "Jack";
        });
        Console.WriteLine("Part 10: " + lastIndexOf);


        //Part 11
        //Using the list of names, clear the list and print the list out to the console.
        //Hint: You can use the Clear() method to clear the list.
        listString.Clear();
        Console.WriteLine("Part 11: " + listString.Count() + " items");

        //Part 12
        //Create a new list of strings and integers and print them out to the console.
        //Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
        Console.WriteLine("Part 12: ");
        List<int> listInt = new List<int>();
        listInt.Add(23);
        listInt.Add(44);
        listInt.Add(91);
        listInt.ForEach(delegate (int numb) {
            Console.WriteLine(numb);
        });
    }

}
