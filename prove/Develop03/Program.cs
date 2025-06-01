using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int run = 1;

        Reference[] verses = new Reference[]
       {
            new Reference("Genesis", 3, 10, "And he said, I heard thy voice in the garden, and I was afraid, because I was naked; \nand I hid myself."),
            new Reference("Isaiah", 41, 10, "Fear thou not, for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; \nyea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),
            new Reference("Psalm", 23, 1, "The Lord is my shepherd; I shall not want."),
            new Reference("Philippians", 4, 13, "I can do all things through Christ which strengtheneth me."),
            new Reference("Proverbs", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
            new Reference("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Reference("Hebrews", 11, 1, "Now faith is the substance of things hoped for, the evidence of things not seen."),
            new Reference("Romans", 8, 38, 39,
                "For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, " +
                "nor things present, nor things to come, nor height, nor depth, nor any other creature, " +
                "shall be able to separate us from the love of God, which is in Christ Jesus our Lord."),
                
            //new Reference("Isaiah", 43, 1, 2, "But now thus saith the Lord that created thee, O Jacob, and he that formed thee, O Israel, \nFear not, for I have redeemed thee, I have called thee by thy name; thou art mine. \n\nWhen thou passest through the waters, I will be with thee; and through the rivers, \nthey shall not overflow thee; when thou walkest through the fire, thou shalt not be burned; neither shall the flame kindle upon thee. ")
       };

        int chosenScript = random.Next(verses.Length);
        Scripture scripture = new Scripture(verses[chosenScript]);
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");



        while (run == 1)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                run = 0;
                break;
            }
            else if (input == "")
            {
                Console.Clear();
                Console.WriteLine(verses[chosenScript]);
                Console.WriteLine(scripture.GetText());
                scripture.HideRandomWords();
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");

                if (scripture.AreAllWordsHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Press any key to exit.");
                    Console.ReadKey();
                    break;
                }
    
            }

        }
        
        
    }
}