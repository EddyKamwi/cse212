using System.Reflection;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //1st create a results array to store multiples of a proviced number
        var results = new double[length];

        //2nd create a loop to check if the length is not exceeded
        //and append a multiple each time to the results list
        for (int count = 0; count < length; count++)
        {
            //3rd appending a multiple to the results array
            results[count] = (count + 1) * number;
        }

        // 4th return the results array outside the loop
        return results; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //1st declare an index value for slicing the array
        int index = data.Count - amount;

        //2nd create a new array starting from the index to end
        var newList = data.GetRange(index, amount);

        //3rd then append to the new array from beggining to where it was sliced
        newList.AddRange(data.GetRange(0, index));

        //4th modifying the list in the parameter will require to clear and then add our new list.
        data.Clear();
        data.AddRange(newList);
    }

}
