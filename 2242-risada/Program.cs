using System;

public class Program
{
     
    static void Main(string[] args)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        string laughter = Console.ReadLine();
        string laughterVowels = "";

        for (int i = 0; i < laughter.Length; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (laughter[i] == vowels[j])
                    laughterVowels += laughter[i];
              
            }
        }
        bool funnyLaugh = true;
        int length = laughterVowels.Length;

        for (int i = 0; i < length / 2; i++)
        {
            int index = length - 1 -i;
            
            if (laughterVowels[i] !=            laughterVowels[index])
            {
                funnyLaugh = false;
                break;
            }
        }

        if (funnyLaugh)
            Console.WriteLine('S');
        else
            Console.WriteLine('N');

    }
}
