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
        // Step 1: Create a double array with the size given by length.
        double[] multiples = new double[length];
        // Step 2: Use a for loop to go through each position of the array.
        for (int i = 0; i <length; i++)
        // Step 3: Multiply number by the current position plus 1, and 
        multiples[i] = number * (i + 1);
        // Step 4: Return the completed array.
        return multiples; 
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
        // Step 1: Calculate the starting index of the last 'amount' elements.
        int startIndex = data.Count - amount;
        // Step 2: Store the last 'amount' elements in a temporary list.
        List<int> lastElements = data.GetRange(startIndex, amount);
        // Step 3: Remove those elements from the original list.
        data.RemoveRange(startIndex, amount);
        // Step 4: Insert the saved elements at the beginning of the original list.
        data.InsertRange(0, lastElements);



    }
}
