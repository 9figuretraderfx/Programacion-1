using System;

class Program
{
    public static void Main(string[] args)
    {
        bool x = true;
        bool y = true;

        //X = TRUE, TRUE, FALSE, FALSE
        //NOT X = FALSE, FALSE, TRUE, TRUE

        //X= TRUE, Y=TRUE, NOT X=FALSE, (NOT X) AND Y=FALSE
        Console.WriteLine("X= " + x + " Y= " + y + " !X= " + !x + " !X&&Y " + (!x && y));

        //X= TRUE, Y=FALSE, NOT X=FALSE, (NOT X) AND Y=FALSE
        Console.WriteLine("X= " + x + " Y= " + !x + " !X= " + !x + " !X&&Y " + (!x && y));

        //X= TRUE, Y=FALSE, NOT X=FALSE, (NOT X) AND Y=FALSE
        Console.WriteLine("X= " + !x + " Y= " + x + " !X= " + x + " !X&&Y " + (x && y));

        //X= TRUE, Y=FALSE, NOT X=FALSE, (NOT X) AND Y=FALSE
        Console.WriteLine("X= " + !x + " Y= " + !x + " !X= " + x + " !X&&Y " + (!x && y));
    }
}