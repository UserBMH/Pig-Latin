//I leaned heavily on the internet as I could not figure this out with what I got from lectures. Need to go back and actually learn how to do this going forward.

//Prompt user for setence
Console.WriteLine("Speak Friend...");
string loop;

do
{



    
    
    Console.WriteLine("");
    string sentence = Console.ReadLine();

    var convert = wordPig(sentence);
    Console.WriteLine(convert.ToLower());



    //Method creates wordPig, attached to setence variable
    static string wordPig(string sentence)
    {
        const string vowels = "AEIOUaeiou";
        const string except = "1234567890!@#$%^&*()_+";
        var returnSentence = "";
        foreach (var word in sentence.Split())
        {
            var firstLetter = word.Substring(0, 1);
            var restOfWord = word.Substring(1, word.Length - 1);
            var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);
            var bannedLetter = except.IndexOf(firstLetter, StringComparison.Ordinal);


            //IF THIS IS A VOWEL from above list
            if (currentLetter == -1)
            {
                returnSentence += restOfWord + firstLetter + "ay ";
            }

            //ELSE ITS NOT A VOEWL from above list
            else
            {
                returnSentence += word + "way ";
            }
        }
        return returnSentence;



    }



    //ask user for another word

    Console.WriteLine("");
    Console.WriteLine("Another phrase sir? y/n?");
    loop = Console.ReadLine();

    if (loop == "y")
    {
        Console.WriteLine("");
        Console.WriteLine("Speak Friend...");
        
    }
    else
    {
        System.Environment.Exit(0);
    }

}
while (true);








