# c sharp complete-academy

__________________________________________________________________________________



Programma del corso

- 1 - Introduzione a C# e .Net

    Introduzione a .Net
    Creazione di progetti con Visual Studio 2022
    Scrivere un'applicazione C#
    Redazione di documentazioni efficaci
    Esecuzione e debug delle applicazioni con Visual Studio 2022

- 2 - Struttura della programmazione C#

    Variabili, valori, classi/oggetti
    Il linguaggio: sintassi, espressioni, operatori
    Contenitori .Net: lista, dizionario, coda
    Istruzioni di flusso
    Istruzioni di iterazione
    Frammenti di codice di Visual Studio 2022

- 3 - Dichiarazione e chiamata di metodi

    Definizione e chiamata di metodi
    Passaggio di parametri

- 4 - Gestione delle eccezioni

    La gestione delle eccezioni
    Sollevare eccezioni

- 5 - Leggere e scrivere su file

    Accedere al file system
    Leggere e scrivere su file utilizzando i flussi

- 6 - Creazione di nuovi tipi di dati

    Creazione e utilizzo di enumerazioni
    Creazione e utilizzo delle classi
    Creazione e utilizzo di strutture
    Confronto tra tipi di riferimento e tipi di valore
    Gestione dei riferimenti alle librerie di classi in Visual Studio 2022

- 7 - Incapsulamento di dati e metodi

    Controllare la visibilità dei membri
    Condividere metodi e dati

- 8 - Ereditarietà delle classi e implementazione delle interfacce

    Utilizzare l'ereditarietà per definire nuovi tipi di riferimento
    Definire e implementare le interfacce
    Definizione di classi astratte

- 9 - Gestione della durata degli oggetti e controllo delle risorse

    Introduzione alla Garbage Collection
    Gestione delle risorse

- 10 - Incapsulamento avanzato

    Creazione e utilizzo delle proprietà
    Creazione e utilizzo di indicizzatori
    Overload degli operatori

- 11 - Disaccoppiamento dei metodi e gestione degli eventi

    Dichiarazione e uso dei delegati
    Utilizzo delle espressioni Lambda
    Gestione di eventi

- 12 - Utilizzo di collezioni e costruzione di tipi generici

    Lavorare con le raccolte
    Creazione e utilizzo di tipi generici
    Definire interfacce generiche e comprendere la varianza
    Utilizzo di metodi e delegati generici

- 13 - Programmazione asincrona e personalizzazione del codice

    Programmazione asincrona
    Creazione di una classe di raccolta personalizzata
    Semplificazione del codice

- 14 - Utilizzo di LINQ per interrogare i dati

    Utilizzo di metodi di estensione LINQ e operatori di query
    Creazione di query ed espressioni LINQ dinamiche

- 15 - Sviluppo basato su test

    Il ruolo dei test nello sviluppo
    Introduzione ai pattern MVC, MVVM
    Unit test e Visual Studio 2022





__________________________________________________________________________________


Editor Online : https://www.programiz.com/csharp-programming/online-compiler/



In C#, i tipi di dato possono essere suddivisi in due categorie principali: tipi di valore (value types) e tipi di riferimento (reference types). Ecco una panoramica di entrambi:

### Tipi di Valore (Value Types)

I tipi di valore memorizzano direttamente i dati e sono allocati nello stack. Alcuni dei tipi di valore comuni in C# includono:

1. **Tipi Numerici**
    - **Interi senza segno**
        - `byte`: 8-bit (0 to 255)
        - `ushort`: 16-bit (0 to 65,535)
        - `uint`: 32-bit (0 to 4,294,967,295)
        - `ulong`: 64-bit (0 to 18,446,744,073,709,551,615)
    - **Interi con segno**
        - `sbyte`: 8-bit (-128 to 127)
        - `short`: 16-bit (-32,768 to 32,767)
        - `int`: 32-bit (-2,147,483,648 to 2,147,483,647)
        - `long`: 64-bit (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
    - **Floating-point**
        - `float`: 32-bit floating-point
        - `double`: 64-bit floating-point
        - `decimal`: 128-bit precisione decimale, usato principalmente per applicazioni finanziarie

2. **Tipi Booleani**
    - `bool`: rappresenta un valore booleano (true o false)

3. **Tipi Carattere**
    - `char`: rappresenta un singolo carattere Unicode a 16 bit

4. **Strutture**
    - `struct`: una struttura definita dall'utente

5. **Enumerazioni**
    - `enum`: un insieme di costanti denominate

### Tipi di Riferimento (Reference Types)

I tipi di riferimento memorizzano un riferimento ai dati, non i dati stessi. Sono allocati nell'heap e includono:

1. **Stringhe**
    - `string`: rappresenta una sequenza di caratteri Unicode

2. **Classi**
    - `class`: una classe definita dall'utente

3. **Array**
    - Array di qualsiasi tipo (es. `int[]`, `string[]`)

4. **Interfacce**
    - `interface`: definisce un contratto che può essere implementato da una classe o una struttura

5. **Delegati**
    - `delegate`: rappresenta un riferimento a un metodo

6. **Oggetti**
    - `object`: il tipo base da cui tutti i tipi di riferimento derivano

### Differenze Chiave

- **Allocazione di Memoria**: I tipi di valore vengono allocati nello stack, mentre i tipi di riferimento vengono allocati nell'heap.
- **Copia dei Dati**: Quando un tipo di valore viene assegnato a un'altra variabile, viene creata una copia dei dati. Per i tipi di riferimento, viene copiato solo il riferimento all'oggetto.
- **Gestione della Memoria**: I tipi di riferimento sono gestiti dal garbage collector, mentre i tipi di valore vengono automaticamente deallocati quando escono dallo scope.

### Esempio di Dichiarazione

Ecco alcuni esempi di come dichiarare e utilizzare i vari tipi di dato in C#:

```csharp
// Tipi di Valore
int numeroIntero = 42;
float numeroDecimale = 3.14f;
char carattere = 'A';
bool flag = true;

// Tipi di Riferimento
string testo = "Hello, World!";
int[] arrayNumeri = {1, 2, 3, 4, 5};
MyClass oggetto = new MyClass();
MyDelegate delegato = new MyDelegate(MyMetodo);

// Classe di esempio
public class MyClass
{
    public int MyProperty { get; set; }
}

// Delegato di esempio
public delegate void MyDelegate();
public void MyMetodo()
{
    // Codice del metodo
}
```


_______________________




### Leggere una stringa

Il metodo più semplice per leggere l'input dell'utente è `Console.ReadLine()`, che legge una riga completa di testo inserita dall'utente.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci il tuo nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Ciao, " + nome + "!");
    }
}
```

### Leggere un intero

Per leggere un numero intero dall'utente, è necessario convertire la stringa letta con `Console.ReadLine()` in un intero usando `int.Parse()` o `int.TryParse()` per una gestione migliore degli errori.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci un numero intero:");
        string input = Console.ReadLine();
        
        // Metodo 1: int.Parse() (potrebbe generare un'eccezione se l'input non è un numero valido)
        int numero;
        try
        {
            numero = int.Parse(input);
            Console.WriteLine("Hai inserito: " + numero);
        }
        catch (FormatException)
        {
            Console.WriteLine("Errore: input non valido.");
        }

        // Metodo 2: int.TryParse() (gestisce l'errore senza eccezioni)
        if (int.TryParse(input, out numero))
        {
            Console.WriteLine("Hai inserito: " + numero);
        }
        else
        {
            Console.WriteLine("Errore: input non valido.");
        }
    }
}
```

### Leggere un numero decimale

Analogamente, per leggere un numero decimale (ad esempio, `double` o `float`), è possibile utilizzare `double.Parse()` o `double.TryParse()`.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci un numero decimale:");
        string input = Console.ReadLine();
        
        double numero;
        if (double.TryParse(input, out numero))
        {
            Console.WriteLine("Hai inserito: " + numero);
        }
        else
        {
            Console.WriteLine("Errore: input non valido.");
        }
    }
}
```

### Leggere un carattere

Per leggere un singolo carattere, si può utilizzare `Console.ReadKey()`.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Premi un tasto:");
        ConsoleKeyInfo tasto = Console.ReadKey();
        Console.WriteLine("\nHai premuto: " + tasto.KeyChar);
    }
}
```

___________________________________________________


In C#, gli operatori matematici sono utilizzati per eseguire operazioni aritmetiche su variabili e valori. Ecco un elenco degli operatori matematici principali con esempi di utilizzo:

### Operatori Aritmetici di Base

1. **Addizione (`+`)**
   - Somma due operandi.

   ```csharp
   int a = 10;
   int b = 5;
   int somma = a + b; // somma = 15
   ```

2. **Sottrazione (`-`)**
   - Sottrae il secondo operando dal primo.

   ```csharp
   int a = 10;
   int b = 5;
   int differenza = a - b; // differenza = 5
   ```

3. **Moltiplicazione (`*`)**
   - Moltiplica due operandi.

   ```csharp
   int a = 10;
   int b = 5;
   int prodotto = a * b; // prodotto = 50
   ```

4. **Divisione (`/`)**
   - Divide il primo operando per il secondo.

   ```csharp
   int a = 10;
   int b = 5;
   int quoziente = a / b; // quoziente = 2
   ```

   > **Nota:** Se si divide un intero per un altro intero, il risultato sarà un intero (la parte decimale verrà troncata). Per ottenere un risultato decimale, almeno uno degli operandi deve essere un numero a virgola mobile.

   ```csharp
   double a = 10;
   double b = 3;
   double quoziente = a / b; // quoziente ≈ 3.3333
   ```

5. **Modulo (`%`)**
   - Restituisce il resto della divisione del primo operando per il secondo.

   ```csharp
   int a = 10;
   int b = 3;
   int resto = a % b; // resto = 1
   ```

### Operatori di Incremento e Decremento

1. **Incremento (`++`)**
   - Incrementa l'operando di 1.

   ```csharp
   int a = 10;
   a++; // a = 11
   ```

2. **Decremento (`--`)**
   - Decrementa l'operando di 1.

   ```csharp
   int a = 10;
   a--; // a = 9
   ```

### Operatori di Assegnazione Compatti

1. **Assegnazione Additiva (`+=`)**
   - Aggiunge il valore dell'operando di destra all'operando di sinistra e assegna il risultato all'operando di sinistra.

   ```csharp
   int a = 10;
   a += 5; // a = 15
   ```

2. **Assegnazione Sottrattiva (`-=`)**
   - Sottrae il valore dell'operando di destra dall'operando di sinistra e assegna il risultato all'operando di sinistra.

   ```csharp
   int a = 10;
   a -= 5; // a = 5
   ```

3. **Assegnazione Moltiplicativa (`*=`)**
   - Moltiplica l'operando di sinistra per il valore dell'operando di destra e assegna il risultato all'operando di sinistra.

   ```csharp
   int a = 10;
   a *= 2; // a = 20
   ```

4. **Assegnazione Divisiva (`/=`)**
   - Divide l'operando di sinistra per il valore dell'operando di destra e assegna il risultato all'operando di sinistra.

   ```csharp
   int a = 10;
   a /= 2; // a = 5
   ```

5. **Assegnazione Modulativa (`%=`)**
   - Calcola il modulo dell'operando di sinistra con il valore dell'operando di destra e assegna il risultato all'operando di sinistra.

   ```csharp
   int a = 10;
   a %= 3; // a = 1
   ```

### Esempio Completo

Ecco un esempio completo che utilizza vari operatori matematici:

```csharp
using System;

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 3;

        // Operatori aritmetici di base
        Console.WriteLine("Addizione: " + (x + y));     // 13
        Console.WriteLine("Sottrazione: " + (x - y));  // 7
        Console.WriteLine("Moltiplicazione: " + (x * y)); // 30
        Console.WriteLine("Divisione: " + (x / y));    // 3 (divisione intera)
        Console.WriteLine("Modulo: " + (x % y));       // 1

        // Operatori di incremento e decremento
        x++;
        Console.WriteLine("Incremento: " + x);         // 11
        x--;
        Console.WriteLine("Decremento: " + x);         // 10

        // Operatori di assegnazione compatti
        x += 5;
        Console.WriteLine("Assegnazione Additiva: " + x); // 15
        x -= 2;
        Console.WriteLine("Assegnazione Sottrattiva: " + x); // 13
        x *= 2;
        Console.WriteLine("Assegnazione Moltiplicativa: " + x); // 26
        x /= 2;
        Console.WriteLine("Assegnazione Divisiva: " + x); // 13
        x %= 3;
        Console.WriteLine("Assegnazione Modulativa: " + x); // 1
    }
}
```

Questi esempi mostrano come utilizzare gli operatori matematici in C# per eseguire operazioni aritmetiche di base e modificare i valori delle variabili.







____________________________________________________


In C#, le strutture di selezione consentono di eseguire diverse operazioni in base a condizioni specifiche. Le principali strutture di selezione includono `if`, `else if`, `else`, `switch` e l'operatore ternario. Ecco una panoramica di ciascuna di queste strutture con esempi di codice.

### Struttura `if`

La struttura `if` valuta una condizione booleana e, se la condizione è vera, esegue un blocco di codice.

```csharp
using System;

class Program
{
    static void Main()
    {
        int numero = 10;

        if (numero > 0)
        {
            Console.WriteLine("Il numero è positivo.");
        }
    }
}
```

### Struttura `if-else`

La struttura `if-else` consente di eseguire un blocco di codice se la condizione è vera e un altro blocco se la condizione è falsa.

```csharp
using System;

class Program
{
    static void Main()
    {
        int numero = -5;

        if (numero > 0)
        {
            Console.WriteLine("Il numero è positivo.");
        }
        else
        {
            Console.WriteLine("Il numero è negativo o zero.");
        }
    }
}
```

### Struttura `if-else if-else`

La struttura `if-else if-else` consente di valutare più condizioni in sequenza.

```csharp
using System;

class Program
{
    static void Main()
    {
        int numero = 0;

        if (numero > 0)
        {
            Console.WriteLine("Il numero è positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Il numero è negativo.");
        }
        else
        {
            Console.WriteLine("Il numero è zero.");
        }
    }
}
```

### Struttura `switch`

La struttura `switch` è utile quando si devono confrontare un valore con diverse costanti. È particolarmente utile per la gestione di enumerazioni o valori discreti.

```csharp
using System;

class Program
{
    static void Main()
    {
        int giornoDellaSettimana = 3;

        switch (giornoDellaSettimana)
        {
            case 1:
                Console.WriteLine("Lunedì");
                break;
            case 2:
                Console.WriteLine("Martedì");
                break;
            case 3:
                Console.WriteLine("Mercoledì");
                break;
            case 4:
                Console.WriteLine("Giovedì");
                break;
            case 5:
                Console.WriteLine("Venerdì");
                break;
            case 6:
                Console.WriteLine("Sabato");
                break;
            case 7:
                Console.WriteLine("Domenica");
                break;
            default:
                Console.WriteLine("Giorno non valido.");
                break;
        }
    }
}
```

### Operatore Ternario

L'operatore ternario (`? :`) consente di scrivere espressioni condizionali in una singola riga. È un'alternativa compatta alla struttura `if-else` per assegnazioni semplici.

```csharp
using System;

class Program
{
    static void Main()
    {
        int numero = 5;
        string risultato = numero > 0 ? "Positivo" : "Non positivo";
        Console.WriteLine(risultato);
    }
}
```

### Esempio Completo

Ecco un esempio completo che utilizza diverse strutture di selezione:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci un numero intero:");
        string input = Console.ReadLine();
        int numero;
        
        if (int.TryParse(input, out numero))
        {
            // Uso di if-else if-else
            if (numero > 0)
            {
                Console.WriteLine("Il numero è positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Il numero è negativo.");
            }
            else
            {
                Console.WriteLine("Il numero è zero.");
            }

            // Uso di switch
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Il numero è uno.");
                    break;
                case 2:
                    Console.WriteLine("Il numero è due.");
                    break;
                default:
                    Console.WriteLine("Il numero non è né uno né due.");
                    break;
            }

            // Uso dell'operatore ternario
            string parita = numero % 2 == 0 ? "pari" : "dispari";
            Console.WriteLine("Il numero è " + parita + ".");
        }
        else
        {
            Console.WriteLine("Errore: input non valido.");
        }
    }
}
```


_________________________________________________________________

# Strutture iterative c#


In C#, gli operatori iterativi, o strutture di controllo iterative, consentono di eseguire un blocco di codice ripetutamente fino a quando una condizione specificata è vera. Le principali strutture iterative in C# sono `for`, `foreach`, `while` e `do-while`. Ecco una panoramica di ciascuna di queste strutture con esempi di codice.

### Ciclo `for`

Il ciclo `for` viene utilizzato quando si conosce in anticipo il numero di iterazioni da eseguire. È costituito da tre parti: inizializzazione, condizione e incremento.

```csharp
using System;

class Program
{
    static void Main()
    {
        // Ciclo for per stampare i numeri da 0 a 9
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
```

### Ciclo `foreach`

Il ciclo `foreach` viene utilizzato per iterare attraverso tutti gli elementi di una collezione (come un array o una lista). È particolarmente utile quando si desidera accedere a ciascun elemento senza dover gestire l'indice di iterazione.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeri = { 1, 2, 3, 4, 5 };

        // Ciclo foreach per stampare ciascun numero nell'array
        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
    }
}
```

### Ciclo `while`

Il ciclo `while` esegue un blocco di codice ripetutamente finché una condizione specificata rimane vera. La condizione viene valutata all'inizio di ogni iterazione.

```csharp
using System;

class Program
{
    static void Main()
    {
        int i = 0;

        // Ciclo while per stampare i numeri da 0 a 9
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
```

### Ciclo `do-while`

Il ciclo `do-while` è simile al ciclo `while`, ma la condizione viene valutata alla fine di ogni iterazione. Ciò significa che il blocco di codice verrà eseguito almeno una volta, indipendentemente dalla condizione.

```csharp
using System;

class Program
{
    static void Main()
    {
        int i = 0;

        // Ciclo do-while per stampare i numeri da 0 a 9
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i < 10);
    }
}
```

### Esempio Completo

Ecco un esempio completo che utilizza tutte e quattro le strutture iterative:

```csharp
using System;

class Program
{
    static void Main()
    {
        // Esempio con ciclo for
        Console.WriteLine("Ciclo for:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iterazione " + i);
        }

        // Esempio con ciclo foreach
        Console.WriteLine("Ciclo foreach:");
        string[] nomi = { "Alice", "Bob", "Charlie" };
        foreach (string nome in nomi)
        {
            Console.WriteLine("Ciao, " + nome + "!");
        }

        // Esempio con ciclo while
        Console.WriteLine("Ciclo while:");
        int j = 0;
        while (j < 3)
        {
            Console.WriteLine("Iterazione " + j);
            j++;
        }

        // Esempio con ciclo do-while
        Console.WriteLine("Ciclo do-while:");
        int k = 0;
        do
        {
            Console.WriteLine("Iterazione " + k);
            k++;
        }
        while (k < 3);
    }
}
```





















