PrintMessage printDelegate = PrintToConsole;

printDelegate("woww");


//assegno un nuovo metodo al delegato...
printDelegate = PrintToUpperConsole;

printDelegate("woww");




static void PrintToConsole(string message)
{
    Console.WriteLine(message);
}


static void PrintToUpperConsole(string message)
{
    Console.WriteLine( message.ToUpper());
}


//definizione di un delegate 
public delegate void PrintMessage(string message);
