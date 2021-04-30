using System;

namespace marcheiei
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Current half DNA sequence :");
            string halfDNASequence = Console.ReadLine().ToUpper();
            char[] nucleotide = halfDNASequence.ToCharArray();

            if (IsValidSequence(halfDNASequence) == false)
            { Console.WriteLine("That half DNA sequence is invalid."); }
            else
            {
                Console.Write("Do you want to replicate it ? (Y/N) :");
                char YorN1 = char.Parse(Console.ReadLine());
                if (YorN1 != 'Y' && YorN1 != 'N')
                {
                    do
                    {
                        Console.Write("Please input Y or N :");
                        YorN1 = char.Parse(Console.ReadLine());
                    } while (YorN1 == 'N' && YorN1 == 'Y');
                }
                if (YorN1 == 'Y')
                { Console.WriteLine("Current half DNA sequence: {0}", ReplicateSeqeunce(halfDNASequence)); }
            }
            Console.Write("Do you want to process another sequence ? (Y/N) :");
            char YorN2 = char.Parse(Console.ReadLine());
            if (YorN2 != 'Y' && YorN2 != 'N')
            {
                do
                {
                    Console.Write("Please input Y or N :");
                    YorN2 = char.Parse(Console.ReadLine());
                } while (YorN2 == 'N' && YorN2 == 'Y');
            }
            if (YorN2 == 'Y')
            { Main(); }
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
