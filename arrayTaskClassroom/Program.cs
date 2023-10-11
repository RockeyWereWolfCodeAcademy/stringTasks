namespace arrayTaskClassroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //string word = "Hdllo";
            //char letter = 'e';
            //bool isLetterHere = false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        isLetterHere = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(isLetterHere);
            //task2
            string sentence = "Ya xochu spat";
            string findWord = "Ya";
            int j = 0;
            bool isWordHere = false;
            for (int i = 0;!isWordHere; i++) 
            {
                if (j == findWord.Length-1)
                {
                    isWordHere = true;
                    break;
                }
                if (sentence[i] == findWord[j])
                {
                    j++;
                }
            }
            Console.WriteLine(isWordHere);
        }
    }
}