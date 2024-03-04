internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nutrifood Test");
        Console.WriteLine("Moh Khoirul Arifin Batch 13 Online");
        Console.WriteLine();

        // Test 1, count words in a sentence
        Console.WriteLine("Test 1, count words in a sentence");
        Console.Write("Please input some sentence: ");
        string sentence = Console.ReadLine()!;
        var count = CountWords(sentence);
        // Print result
        Console.WriteLine($"there are {count} words in your sentence");
        Console.WriteLine();

        // Test 2, find biggest number in an array
        Console.WriteLine("Test 2, find biggest number in an array");
        Console.Write("Please input numbers separated by space: ");
        // prompt user to input numbers separated by space
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        var biggest = FindBiggestNumber(numbers);
        // Print result
        Console.WriteLine($"the biggest number is {biggest}");
        Console.WriteLine();

        // Test 3, sort numbers in an array
        Console.WriteLine("Test 3, sort numbers in an array");
        Console.Write("Please input numbers separated by space: ");
        // prompt user to input numbers separated by space
        numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        var sorted = SortNumbers(numbers);
        // Print result
        Console.WriteLine($"the sorted numbers are {string.Join(", ", sorted)}");
        Console.WriteLine();

        // Test 4, search for the letters that appear most often in a word
        Console.WriteLine("Test 4, search for the letters that appear most often in a word");
        Console.Write("Please input a word: ");
        // prompt user to input a word
        var word = Console.ReadLine()!;
        var mostFrequent = FindMostFrequentLetter(word);
        // Print result
        Console.WriteLine($"the most frequent letter is {mostFrequent}");
        Console.WriteLine();

        // Test 5, check if a word is a palindrome word
        Console.WriteLine("Test 5, check if a word is a palindrome word");
        Console.Write("Please input a word: ");
        // prompt user to input a word
        word = Console.ReadLine()!;
        var isPalindrome = IsPalindrome(word);
        // Print result
        if (isPalindrome)
        {
            Console.WriteLine($"{word} is a palindrome word");
        }
        else
        {
            Console.WriteLine($"{word} is not a palindrome word");
        }
        Console.WriteLine();

        // Thank you
        Console.WriteLine("Thank you!");
    }

    // Function to count words in a sentence
    private static int CountWords(string sentence)
    {
        return sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // Function to find biggest number in an array
    private static int FindBiggestNumber(int[] numbers)

    {
        int biggest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > biggest)
            {
                biggest = numbers[i];
            }

        }

        return biggest;
    }

    // function to sort numbers in an array based on smallest number
    private static int[] SortNumbers(int[] numbers)
    {
        Array.Sort(numbers);

        return numbers;
    }

    // function to search for the letters that appear most often in a word
    private static char FindMostFrequentLetter(string word)
    {
        var letterCount = new Dictionary<char, int>();
        foreach (char letter in word)
        {
            if (char.IsLetter(letter))
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }
        }
        var mostFrequentLetter = letterCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        return mostFrequentLetter;
    }

    // function to check if a word is a palindrome word
    private static bool IsPalindrome(string word)
    {
        word = word.ToLower();
        int left = 0;
        int right = word.Length - 1;
        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}