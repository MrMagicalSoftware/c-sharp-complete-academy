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


# TI DI DATO 

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


__________________________________________________________________________________________________________________

# LISTE , DIZIONARI E CODE


In C#, le collezioni come liste, dizionari e code offrono potenti strumenti per gestire gruppi di dati. Ecco una panoramica di ciascuna di queste collezioni, inclusi esempi di utilizzo.

### Liste

Le liste (`List<T>`) sono collezioni generiche che consentono di memorizzare elementi dello stesso tipo. Sono dinamiche, il che significa che possono cambiare dimensione automaticamente quando si aggiungono o si rimuovono elementi.

#### Esempio di Utilizzo delle Liste

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creazione di una lista di interi
        List<int> numeri = new List<int>();

        // Aggiunta di elementi
        numeri.Add(1);
        numeri.Add(2);
        numeri.Add(3);

        // Iterazione attraverso la lista
        Console.WriteLine("Elementi nella lista:");
        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }

        // Accesso agli elementi per indice
        Console.WriteLine("Elemento all'indice 1: " + numeri[1]);

        // Rimozione di un elemento
        numeri.Remove(2);
        Console.WriteLine("Dopo la rimozione:");
        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
    }
}
```

### Dizionari

I dizionari (`Dictionary<TKey, TValue>`) sono collezioni generiche che memorizzano coppie chiave-valore. Consentono un accesso rapido ai valori tramite le chiavi.

#### Esempio di Utilizzo dei Dizionari

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creazione di un dizionario che mappa stringhe a interi
        Dictionary<string, int> età = new Dictionary<string, int>();

        // Aggiunta di elementi
        età.Add("Alice", 30);
        età.Add("Bob", 25);
        età.Add("Charlie", 35);

        // Iterazione attraverso il dizionario
        Console.WriteLine("Elementi nel dizionario:");
        foreach (KeyValuePair<string, int> kvp in età)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }

        // Accesso agli elementi tramite chiave
        Console.WriteLine("Età di Alice: " + età["Alice"]);

        // Rimozione di un elemento
        età.Remove("Bob");
        Console.WriteLine("Dopo la rimozione:");
        foreach (KeyValuePair<string, int> kvp in età)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
}
```

### Code

Le code (`Queue<T>`) sono collezioni generiche che seguono il principio FIFO (First In, First Out). Gli elementi vengono aggiunti alla fine della coda e rimossi dall'inizio.

#### Esempio di Utilizzo delle Code

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creazione di una coda di stringhe
        Queue<string> coda = new Queue<string>();

        // Aggiunta di elementi
        coda.Enqueue("Primo");
        coda.Enqueue("Secondo");
        coda.Enqueue("Terzo");

        // Iterazione attraverso la coda
        Console.WriteLine("Elementi nella coda:");
        foreach (string elemento in coda)
        {
            Console.WriteLine(elemento);
        }

        // Rimozione di un elemento
        string primoElemento = coda.Dequeue();
        Console.WriteLine("Elemento rimosso: " + primoElemento);

        // Visualizzazione del prossimo elemento senza rimuoverlo
        string prossimoElemento = coda.Peek();
        Console.WriteLine("Prossimo elemento: " + prossimoElemento);

        // Stato della coda dopo la rimozione
        Console.WriteLine("Elementi nella coda dopo la rimozione:");
        foreach (string elemento in coda)
        {
            Console.WriteLine(elemento);
        }
    }
}
```

### Esempio Completo con Liste, Dizionari e Code

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista
        List<int> numeri = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Lista di numeri:");
        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }

        // Dizionario
        Dictionary<string, string> capitalePaese = new Dictionary<string, string>
        {
            { "Italia", "Roma" },
            { "Francia", "Parigi" },
            { "Spagna", "Madrid" }
        };
        Console.WriteLine("\nDizionari di capitali:");
        foreach (KeyValuePair<string, string> kvp in capitalePaese)
        {
            Console.WriteLine("Paese: " + kvp.Key + ", Capitale: " + kvp.Value);
        }

        // Coda
        Queue<string> codaPersone = new Queue<string>();
        codaPersone.Enqueue("Alice");
        codaPersone.Enqueue("Bob");
        codaPersone.Enqueue("Charlie");
        Console.WriteLine("\nCoda di persone:");
        while (codaPersone.Count > 0)
        {
            Console.WriteLine(codaPersone.Dequeue());
        }
    }
}
```

________________________________________________________________________________


# Metodi


In C#, i metodi sono blocchi di codice che eseguono un'attività specifica e possono essere richiamati da altre parti del programma. La dichiarazione e la chiamata di metodi sono fondamentali per la scrittura di codice modulare e riutilizzabile. Ecco una guida su come dichiarare, definire e chiamare metodi, inclusi i diversi modi di passare i parametri.

### Dichiarazione e Definizione di Metodi

Un metodo è dichiarato con un tipo di ritorno, un nome e una lista di parametri opzionali. La definizione del metodo include il corpo del metodo, che è racchiuso tra parentesi graffe `{}`.

#### Sintassi di Base

```csharp
[modificatore di accesso] [tipo di ritorno] [nome del metodo]([lista di parametri])
{
    // Corpo del metodo
}
```

- **Modificatore di accesso**: Specifica la visibilità del metodo (ad esempio, `public`, `private`, `protected`, `internal`).
- **Tipo di ritorno**: Specifica il tipo di dato che il metodo restituisce. Se il metodo non restituisce alcun valore, si usa `void`.
- **Nome del metodo**: Il nome del metodo, che deve essere un identificatore valido.
- **Lista di parametri**: Una lista opzionale di parametri che il metodo accetta, racchiusa tra parentesi tonde.

#### Esempio di Metodo Semplice

```csharp
using System;

class Program
{
    // Metodo che non restituisce un valore e non accetta parametri
    public static void Saluta()
    {
        Console.WriteLine("Ciao, mondo!");
    }

    // Metodo che restituisce un valore e accetta parametri
    public static int Somma(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Chiamata del metodo Saluta
        Saluta();

        // Chiamata del metodo Somma
        int risultato = Somma(5, 3);
        Console.WriteLine("Il risultato della somma è: " + risultato);
    }
}
```

### Passaggio di Parametri

Ci sono diversi modi per passare parametri ai metodi in C#:

1. **Passaggio per Valore**
2. **Passaggio per Riferimento**
3. **Parametri Opzionali**
4. **Parametri Nomeati**

#### Passaggio per Valore

Di default, i parametri in C# sono passati per valore, il che significa che viene passata una copia del valore del parametro.

```csharp
using System;

class Program
{
    public static void Incrementa(int numero)
    {
        numero++;
        Console.WriteLine("Dentro il metodo: " + numero); // 11
    }

    static void Main()
    {
        int valore = 10;
        Incrementa(valore);
        Console.WriteLine("Fuori dal metodo: " + valore); // 10
    }
}
```

#### Passaggio per Riferimento

Usando le parole chiave `ref` o `out`, è possibile passare parametri per riferimento, permettendo al metodo chiamato di modificare il valore della variabile chiamante.

```csharp
using System;

class Program
{
    public static void Incrementa(ref int numero)
    {
        numero++;
        Console.WriteLine("Dentro il metodo: " + numero); // 11
    }

    static void Main()
    {
        int valore = 10;
        Incrementa(ref valore);
        Console.WriteLine("Fuori dal metodo: " + valore); // 11
    }
}
```

#### Parametri Opzionali

I parametri opzionali consentono di specificare valori predefiniti per alcuni parametri. Se il chiamante non fornisce un valore, viene utilizzato il valore predefinito.

```csharp
using System;

class Program
{
    public static void StampaMessaggio(string messaggio = "Messaggio di default")
    {
        Console.WriteLine(messaggio);
    }

    static void Main()
    {
        StampaMessaggio(); // Stampa "Messaggio di default"
        StampaMessaggio("Ciao!"); // Stampa "Ciao!"
    }
}
```

#### Parametri Nomeati

I parametri nomeati consentono di passare gli argomenti ai metodi specificando il nome del parametro, rendendo il codice più leggibile e permettendo di cambiare l'ordine degli argomenti.

```csharp
using System;

class Program
{
    public static void StampaInformazioni(string nome, int età)
    {
        Console.WriteLine("Nome: " + nome + ", Età: " + età);
    }

    static void Main()
    {
        StampaInformazioni(età: 25, nome: "Alice"); // Stampa "Nome: Alice, Età: 25"
    }
}
```

### Esempio Completo

Ecco un esempio completo che mostra l'uso di diversi tipi di passaggio di parametri e metodi:

```csharp
using System;

class Program
{
    // Metodo con passaggio per valore
    public static void PassaggioPerValore(int numero)
    {
        numero += 10;
        Console.WriteLine("Dentro PassaggioPerValore: " + numero);
    }

    // Metodo con passaggio per riferimento
    public static void PassaggioPerRiferimento(ref int numero)
    {
        numero += 10;
        Console.WriteLine("Dentro PassaggioPerRiferimento: " + numero);
    }

    // Metodo con parametro opzionale
    public static void Saluta(string messaggio = "Ciao, mondo!")
    {
        Console.WriteLine(messaggio);
    }

    // Metodo con parametri nomeati
    public static void Informazioni(string nome, int età)
    {
        Console.WriteLine("Nome: " + nome + ", Età: " + età);
    }

    static void Main()
    {
        int valore = 5;

        // Chiamata di metodo con passaggio per valore
        PassaggioPerValore(valore);
        Console.WriteLine("Fuori da PassaggioPerValore: " + valore);

        // Chiamata di metodo con passaggio per riferimento
        PassaggioPerRiferimento(ref valore);
        Console.WriteLine("Fuori da PassaggioPerRiferimento: " + valore);

        // Chiamata di metodo con parametro opzionale
        Saluta();
        Saluta("Buongiorno!");

        // Chiamata di metodo con parametri nomeati
        Informazioni(nome: "Alice", età: 30);
    }
}
```

______________________________________

# GESTIONE DELLE EXCEPTION

La gestione delle eccezioni in C# consente di catturare e gestire errori in modo strutturato e robusto. Le eccezioni sono eventi che interrompono il normale flusso di esecuzione di un programma. Utilizzando la gestione delle eccezioni, è possibile intercettare questi eventi e prendere azioni appropriate, come la registrazione degli errori, il rilascio delle risorse o la presentazione di messaggi di errore significativi all'utente.

### Gestione delle Eccezioni

In C#, la gestione delle eccezioni viene realizzata utilizzando i blocchi `try`, `catch`, `finally` e `throw`.

#### Blocco `try`

Il blocco `try` contiene il codice che potrebbe generare un'eccezione.

#### Blocco `catch`

Il blocco `catch` contiene il codice che viene eseguito se si verifica un'eccezione. Può catturare specifici tipi di eccezioni.

#### Blocco `finally`

Il blocco `finally` contiene il codice che viene eseguito indipendentemente dal fatto che un'eccezione sia stata sollevata o meno. Viene utilizzato per rilasciare risorse o eseguire operazioni di pulizia.

#### Parola chiave `throw`

La parola chiave `throw` viene utilizzata per sollevare un'eccezione.

### Esempio di Gestione delle Eccezioni

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Codice che potrebbe sollevare un'eccezione
            int[] numeri = { 1, 2, 3 };
            Console.WriteLine(numeri[5]); // Questo genera un'eccezione IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            // Gestione specifica dell'eccezione IndexOutOfRangeException
            Console.WriteLine("Errore: Indice fuori dai limiti dell'array.");
            Console.WriteLine("Dettagli: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Gestione generica delle eccezioni
            Console.WriteLine("Si è verificato un errore.");
            Console.WriteLine("Dettagli: " + ex.Message);
        }
        finally
        {
            // Codice di pulizia
            Console.WriteLine("Blocco finally eseguito.");
        }
    }
}
```

### Sollevare Eccezioni

In C#, è possibile sollevare eccezioni personalizzate utilizzando la parola chiave `throw` insieme a un'istanza della classe `Exception` (o di una delle sue sottoclassi).

#### Esempio di Sollevamento di Eccezioni

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            ValidaEtà(-5);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Errore: " + ex.Message);
        }
    }

    static void ValidaEtà(int età)
    {
        if (età < 0 || età > 120)
        {
            throw new ArgumentOutOfRangeException(nameof(età), "L'età deve essere compresa tra 0 e 120.");
        }
        Console.WriteLine("Età valida: " + età);
    }
}
```

### Creare Eccezioni Personalizzate

È possibile creare eccezioni personalizzate ereditando dalla classe `Exception`.

#### Esempio di Eccezione Personalizzata

```csharp
using System;

class EtàNonValidaException : Exception
{
    public EtàNonValidaException() { }

    public EtàNonValidaException(string message) : base(message) { }

    public EtàNonValidaException(string message, Exception inner) : base(message, inner) { }
}

class Program
{
    static void Main()
    {
        try
        {
            ValidaEtà(-5);
        }
        catch (EtàNonValidaException ex)
        {
            Console.WriteLine("Errore: " + ex.Message);
        }
    }

    static void ValidaEtà(int età)
    {
        if (età < 0 || età > 120)
        {
            throw new EtàNonValidaException("L'età deve essere compresa tra 0 e 120.");
        }
        Console.WriteLine("Età valida: " + età);
    }
}
```

### Esempio Completo di Gestione delle Eccezioni

Ecco un esempio che combina diversi aspetti della gestione delle eccezioni in un programma:

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Inserisci un numero:");
            string input = Console.ReadLine();
            int numero = int.Parse(input);

            ValidaNumero(numero);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Errore: Il formato del numero non è valido.");
            Console.WriteLine("Dettagli: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Errore: Il numero è troppo grande o troppo piccolo.");
            Console.WriteLine("Dettagli: " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Errore: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Si è verificato un errore inatteso.");
            Console.WriteLine("Dettagli: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operazione completata.");
        }
    }

    static void ValidaNumero(int numero)
    {
        if (numero < 0 || numero > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(numero), "Il numero deve essere compreso tra 0 e 100.");
        }
        Console.WriteLine("Numero valido: " + numero);
    }
}
```

In questo esempio, il programma:
1. Chiede all'utente di inserire un numero.
2. Converte l'input in un intero.
3. Valida il numero per assicurarsi che sia compreso tra 0 e 100.
4. Gestisce diverse eccezioni che potrebbero verificarsi durante la conversione e la validazione del numero.
5. Utilizza un blocco `finally` per eseguire il codice di pulizia, indipendentemente dal fatto che si sia verificata un'eccezione.


_______________________________________________________


# LEGGERE E SCRIVERE SU FILE 


In C#, è possibile leggere e scrivere su file utilizzando i flussi (streams). La classe `System.IO` fornisce vari tipi di flussi e classi helper per lavorare con i file. Ecco come accedere al file system e leggere/scrivere su file utilizzando i flussi.

### Lettura da File

Per leggere da un file, si può utilizzare la classe `StreamReader`.

#### Esempio di Lettura da File

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string percorsoFile = "testo.txt";

        try
        {
            using (StreamReader sr = new StreamReader(percorsoFile))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la lettura del file:");
            Console.WriteLine(ex.Message);
        }
    }
}
```

### Scrittura su File

Per scrivere su un file, si può utilizzare la classe `StreamWriter`.

#### Esempio di Scrittura su File

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string percorsoFile = "testo.txt";

        try
        {
            using (StreamWriter sw = new StreamWriter(percorsoFile))
            {
                sw.WriteLine("Ciao, mondo!");
                sw.WriteLine("Scrittura su file in C#.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la scrittura del file:");
            Console.WriteLine(ex.Message);
        }
    }
}
```

### Esempio Completo: Lettura e Scrittura

Ecco un esempio che mostra come combinare lettura e scrittura su file:

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string percorsoFile = "testo.txt";

        // Scrittura su file
        try
        {
            using (StreamWriter sw = new StreamWriter(percorsoFile))
            {
                sw.WriteLine("Ciao, mondo!");
                sw.WriteLine("Scrittura su file in C#.");
            }
            Console.WriteLine("Scrittura completata.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la scrittura del file:");
            Console.WriteLine(ex.Message);
        }

        // Lettura da file
        try
        {
            using (StreamReader sr = new StreamReader(percorsoFile))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la lettura del file:");
            Console.WriteLine(ex.Message);
        }
    }
}
```

### Lettura e Scrittura di File Binari

Per file binari, si utilizzano `FileStream`, `BinaryReader`, e `BinaryWriter`.

#### Scrittura di File Binari

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string percorsoFile = "dati.bin";

        try
        {
            using (FileStream fs = new FileStream(percorsoFile, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(123);     // Scrive un intero
                bw.Write("Ciao!"); // Scrive una stringa
                bw.Write(4.5);     // Scrive un double
            }
            Console.WriteLine("Scrittura binaria completata.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la scrittura del file binario:");
            Console.WriteLine(ex.Message);
        }
    }
}
```

#### Lettura di File Binari

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string percorsoFile = "dati.bin";

        try
        {
            using (FileStream fs = new FileStream(percorsoFile, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int numero = br.ReadInt32();
                string testo = br.ReadString();
                double valore = br.ReadDouble();

                Console.WriteLine($"Intero: {numero}, Stringa: {testo}, Double: {valore}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la lettura del file binario:");
            Console.WriteLine(ex.Message);
        }
    }
}
```

### Esempio Completo: File Binari

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string percorsoFile = "dati.bin";

        // Scrittura su file binario
        try
        {
            using (FileStream fs = new FileStream(percorsoFile, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(123);     // Scrive un intero
                bw.Write("Ciao!"); // Scrive una stringa
                bw.Write(4.5);     // Scrive un double
            }
            Console.WriteLine("Scrittura binaria completata.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la scrittura del file binario:");
            Console.WriteLine(ex.Message);
        }

        // Lettura da file binario
        try
        {
            using (FileStream fs = new FileStream(percorsoFile, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int numero = br.ReadInt32();
                string testo = br.ReadString();
                double valore = br.ReadDouble();

                Console.WriteLine($"Intero: {numero}, Stringa: {testo}, Double: {valore}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante la lettura del file binario:");
            Console.WriteLine(ex.Message);
        }
    }
}
```

_______________________________________________________________________

# Enumerazioni 


In C#, le enumerazioni (o enum) sono un tipo di dato che consente di definire un insieme di costanti con nomi specifici. Le enumerazioni migliorano la leggibilità del codice, permettendo di utilizzare nomi simbolici al posto di valori numerici.

### Dichiarazione di un Enum

Un enum è dichiarato utilizzando la parola chiave `enum`, seguita dal nome dell'enumerazione e dall'elenco delle costanti racchiuso tra parentesi graffe.

#### Sintassi di Base

```csharp
enum NomeEnum
{
    Costante1,
    Costante2,
    Costante3
}
```

#### Esempio

```csharp
enum GiornoDellaSettimana
{
    Lunedì,
    Martedì,
    Mercoledì,
    Giovedì,
    Venerdì,
    Sabato,
    Domenica
}
```

### Utilizzo di un Enum

Una volta dichiarato un enum, puoi utilizzarlo per definire variabili del tipo dell'enum e assegnare loro i valori delle costanti definite nell'enumerazione.

#### Esempio

```csharp
using System;

class Program
{
    enum GiornoDellaSettimana
    {
        Lunedì,
        Martedì,
        Mercoledì,
        Giovedì,
        Venerdì,
        Sabato,
        Domenica
    }

    static void Main()
    {
        GiornoDellaSettimana oggi = GiornoDellaSettimana.Venerdì;
        Console.WriteLine("Oggi è: " + oggi);
        
        // Confronto di enum
        if (oggi == GiornoDellaSettimana.Venerdì)
        {
            Console.WriteLine("Buon fine settimana!");
        }
    }
}
```

### Specificare i Valori delle Costanti

Per default, le costanti di un enum sono di tipo `int` e iniziano da 0. È possibile specificare valori diversi per le costanti.

#### Esempio

```csharp
enum LivelloDiLog
{
    Informazione = 1,
    Avviso = 2,
    Errore = 3,
    Critico = 4
}
```

### Conversione tra Enum e Valori Interi

Puoi convertire un enum in un valore intero e viceversa.

#### Esempio

```csharp
using System;

class Program
{
    enum LivelloDiLog
    {
        Informazione = 1,
        Avviso = 2,
        Errore = 3,
        Critico = 4
    }

    static void Main()
    {
        LivelloDiLog livello = LivelloDiLog.Errore;
        int valoreIntero = (int)livello;
        Console.WriteLine("Il livello di log 'Errore' ha il valore intero: " + valoreIntero);

        LivelloDiLog nuovoLivello = (LivelloDiLog)4;
        Console.WriteLine("Il valore intero 4 corrisponde al livello di log: " + nuovoLivello);
    }
}
```

### Enumerazioni con Flag

È possibile creare un enum che può rappresentare una combinazione di valori utilizzando l'attributo `[Flags]`.

#### Esempio

```csharp
using System;

[Flags]
enum GiorniLavorativi
{
    Nessuno = 0,
    Lunedì = 1,
    Martedì = 2,
    Mercoledì = 4,
    Giovedì = 8,
    Venerdì = 16,
    Tutti = Lunedì | Martedì | Mercoledì | Giovedì | Venerdì
}

class Program
{
    static void Main()
    {
        GiorniLavorativi giorni = GiorniLavorativi.Lunedì | GiorniLavorativi.Mercoledì | GiorniLavorativi.Venerdì;
        Console.WriteLine("Giorni lavorativi selezionati: " + giorni);

        // Verifica se un giorno è incluso
        if ((giorni & GiorniLavorativi.Mercoledì) == GiorniLavorativi.Mercoledì)
        {
            Console.WriteLine("Mercoledì è un giorno lavorativo selezionato.");
        }
    }
}
```

### Esempio Completo

Ecco un esempio completo che mostra la creazione e l'utilizzo di un enum in un'applicazione pratica.

```csharp
using System;

class Program
{
    enum StatoOrdine
    {
        InAttesa = 1,
        Elaborato,
        Spedito,
        Consegnato,
        Annullato
    }

    static void Main()
    {
        StatoOrdine statoCorrente = StatoOrdine.InAttesa;

        Console.WriteLine("Stato corrente dell'ordine: " + statoCorrente);

        // Simulazione di avanzamento dello stato dell'ordine
        statoCorrente = StatoOrdine.Elaborato;
        Console.WriteLine("Stato aggiornato dell'ordine: " + statoCorrente);

        statoCorrente = StatoOrdine.Spedito;
        Console.WriteLine("Stato aggiornato dell'ordine: " + statoCorrente);

        statoCorrente = StatoOrdine.Consegnato;
        Console.WriteLine("Stato aggiornato dell'ordine: " + statoCorrente);

        // Conversione da enum a int
        int valoreIntero = (int)statoCorrente;
        Console.WriteLine("Il valore intero dello stato 'Consegnato' è: " + valoreIntero);

        // Conversione da int a enum
        StatoOrdine statoDaValoreIntero = (StatoOrdine)4;
        Console.WriteLine("Il valore intero 4 corrisponde allo stato: " + statoDaValoreIntero);
    }
}
```

_____________________________


# PROGRAMMAZIONE A OGGETTI 


In C#, le classi sono uno degli elementi fondamentali della programmazione orientata agli oggetti. Ecco una panoramica su come definire una classe in .NET 8, come usare i modificatori di accesso, creare metodi getter e setter, definire un costruttore e sovrascrivere il metodo `ToString()`.

### Definire una Classe

Per creare una classe in C#, si utilizza la parola chiave `class`:

```csharp
public class Persona
{
    // Campi privati
    private string nome;
    private int eta;

    // Proprietà con metodi getter e setter
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Eta
    {
        get { return eta; }
        set { eta = value; }
    }

    // Costruttore
    public Persona(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }

    // Metodo ToString sovrascritto
    public override string ToString()
    {
        return $"Nome: {nome}, Età: {eta}";
    }
}
```

### Modificatori di Accesso

In C#, i modificatori di accesso determinano la visibilità di classi, metodi e variabili. I più comuni sono:

- `public`: accessibile da qualsiasi parte del programma.
- `private`: accessibile solo all'interno della stessa classe.
- `protected`: accessibile all'interno della stessa classe e delle classi derivate.
- `internal`: accessibile all'interno dello stesso assembly.
- `protected internal`: accessibile all'interno dello stesso assembly e dalle classi derivate.

### Proprietà con Metodi Getter e Setter

Le proprietà in C# vengono spesso usate al posto dei campi pubblici per fornire accesso controllato ai dati. È possibile definire proprietà con metodi getter e setter:

```csharp
public class Persona
{
    private string nome;
    private int eta;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Eta
    {
        get { return eta; }
        set { eta = value; }
    }
}
```

### Costruttore

Il costruttore è un metodo speciale che viene chiamato quando si crea una nuova istanza di una classe. Viene utilizzato per inizializzare i campi della classe:

```csharp
public Persona(string nome, int eta)
{
    this.nome = nome;
    this.eta = eta;
}
```

### Sovrascrivere il Metodo `ToString()`

Il metodo `ToString()` viene utilizzato per restituire una rappresentazione stringa di un oggetto. È spesso utile sovrascriverlo per fornire una descrizione significativa dell'oggetto:

```csharp
public override string ToString()
{
    return $"Nome: {nome}, Età: {eta}";
}
```

### Esempio Completo

Ecco un esempio completo che mette insieme tutto:

```csharp
public class Persona
{
    private string nome;
    private int eta;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Eta
    {
        get { return eta; }
        set { eta = value; }
    }

    public Persona(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }

    public override string ToString()
    {
        return $"Nome: {nome}, Età: {eta}";
    }
}
```

______________________________________________________________________________


# PRINCIPIO DI OVERLODING :

L'overloading (sovraccarico) in C# è una funzionalità che permette di definire più metodi con lo stesso nome ma con parametri diversi all'interno della stessa classe. Questo consente di utilizzare lo stesso nome di metodo per operazioni simili che richiedono diversi tipi di input.

Questo esempio dimostra come l'overloading dei metodi possa rendere una classe più versatile e facile da usare, permettendo operazioni simili con input diversi.

```csharp
public class Calcolatrice
{
    // Metodo per sommare due numeri interi
    public int Somma(int a, int b)
    {
        return a + b;
    }

    // Metodo per sommare tre numeri interi
    public int Somma(int a, int b, int c)
    {
        return a + b + c;
    }

    // Metodo per sommare due numeri a virgola mobile
    public double Somma(double a, double b)
    {
        return a + b;
    }

    // Metodo per sommare tre numeri a virgola mobile
    public double Somma(double a, double b, double c)
    {
        return a + b + c;
    }

    // Metodo per concatenare due stringhe
    public string Somma(string a, string b)
    {
        return a + b;
    }
}

// Esempio di utilizzo della classe Calcolatrice
class Program
{
    static void Main(string[] args)
    {
        Calcolatrice calc = new Calcolatrice();

        // Utilizzo dei vari metodi Somma
        int sommaInt = calc.Somma(1, 2);
        int sommaTreInt = calc.Somma(1, 2, 3);
        double sommaDouble = calc.Somma(1.5, 2.5);
        double sommaTreDouble = calc.Somma(1.5, 2.5, 3.5);
        string sommaStringhe = calc.Somma("Hello, ", "world!");

        // Stampa dei risultati
        Console.WriteLine("Somma di due interi: " + sommaInt);
        Console.WriteLine("Somma di tre interi: " + sommaTreInt);
        Console.WriteLine("Somma di due double: " + sommaDouble);
        Console.WriteLine("Somma di tre double: " + sommaTreDouble);
        Console.WriteLine("Somma di due stringhe: " + sommaStringhe);
    }
}
```

### Spiegazione

1. **Metodo `Somma(int a, int b)`**: somma due numeri interi.
2. **Metodo `Somma(int a, int b, int c)`**: somma tre numeri interi.
3. **Metodo `Somma(double a, double b)`**: somma due numeri a virgola mobile.
4. **Metodo `Somma(double a, double b, double c)`**: somma tre numeri a virgola mobile.
5. **Metodo `Somma(string a, string b)`**: concatena due stringhe.

Ogni metodo `Somma` ha lo stesso nome ma parametri diversi, consentendo di eseguire operazioni diverse a seconda dei tipi e del numero di parametri forniti.

### Utilizzo

Nel metodo `Main`, viene creata un'istanza della classe `Calcolatrice` e vengono chiamati i vari metodi `Somma` con parametri diversi. I risultati vengono quindi stampati sulla console.


_________________________________________________


L'ereditarietà è uno dei pilastri della programmazione orientata agli oggetti e consente a una classe di derivare da un'altra classe, ereditando i suoi membri (metodi, proprietà, campi). Questo permette la riusabilità del codice e la creazione di gerarchie di classi.

### Esempio Completo di Ereditarietà in C#

Immaginiamo di avere una classe base `Animale` e due classi derivate `Cane` e `Gatto`.

#### Classe Base `Animale`

```csharp
public class Animale
{
    // Campo privato
    private string nome;

    // Proprietà pubblica
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    // Costruttore
    public Animale(string nome)
    {
        this.nome = nome;
    }

    // Metodo virtuale
    public virtual void FaiVerso()
    {
        Console.WriteLine("L'animale fa un verso.");
    }

    // Metodo ToString sovrascritto
    public override string ToString()
    {
        return $"Nome: {nome}";
    }
}
```

#### Classe Derivata `Cane`

```csharp
public class Cane : Animale
{
    // Campo specifico della classe Cane
    public string Razza { get; set; }

    // Costruttore che chiama il costruttore base
    public Cane(string nome, string razza) : base(nome)
    {
        this.Razza = razza;
    }

    // Override del metodo FaiVerso
    public override void FaiVerso()
    {
        Console.WriteLine("Il cane abbaia.");
    }

    // Override del metodo ToString
    public override string ToString()
    {
        return base.ToString() + $", Razza: {Razza}";
    }
}
```

#### Classe Derivata `Gatto`

```csharp
public class Gatto : Animale
{
    // Campo specifico della classe Gatto
    public string Colore { get; set; }

    // Costruttore che chiama il costruttore base
    public Gatto(string nome, string colore) : base(nome)
    {
        this.Colore = colore;
    }

    // Override del metodo FaiVerso
    public override void FaiVerso()
    {
        Console.WriteLine("Il gatto miagola.");
    }

    // Override del metodo ToString
    public override string ToString()
    {
        return base.ToString() + $", Colore: {Colore}";
    }
}
```

#### Programma Principale

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Creazione di un oggetto Cane
        Cane cane = new Cane("Fido", "Labrador");
        Console.WriteLine(cane);  // Output: Nome: Fido, Razza: Labrador
        cane.FaiVerso();  // Output: Il cane abbaia.

        // Creazione di un oggetto Gatto
        Gatto gatto = new Gatto("Micio", "Nero");
        Console.WriteLine(gatto);  // Output: Nome: Micio, Colore: Nero
        gatto.FaiVerso();  // Output: Il gatto miagola.

        // Uso di polimorfismo
        Animale animale1 = cane;
        Animale animale2 = gatto;

        Console.WriteLine(animale1);  // Output: Nome: Fido, Razza: Labrador
        Console.WriteLine(animale2);  // Output: Nome: Micio, Colore: Nero

        animale1.FaiVerso();  // Output: Il cane abbaia.
        animale2.FaiVerso();  // Output: Il gatto miagola.
    }
}
```

### Spiegazione del Codice

1. **Classe Base `Animale`**:
   - Definisce un campo privato `nome` e una proprietà pubblica `Nome`.
   - Include un costruttore per inizializzare `nome`.
   - Ha un metodo virtuale `FaiVerso` che può essere sovrascritto nelle classi derivate.
   - Sovrascrive il metodo `ToString` per fornire una rappresentazione stringa dell'oggetto.

2. **Classe Derivata `Cane`**:
   - Eredita dalla classe `Animale`.
   - Aggiunge un campo specifico `Razza`.
   - Sovrascrive il metodo `FaiVerso` per fornire un comportamento specifico.
   - Sovrascrive il metodo `ToString` per includere anche la razza del cane.

3. **Classe Derivata `Gatto`**:
   - Eredita dalla classe `Animale`.
   - Aggiunge un campo specifico `Colore`.
   - Sovrascrive il metodo `FaiVerso` per fornire un comportamento specifico.
   - Sovrascrive il metodo `ToString` per includere anche il colore del gatto.

4. **Programma Principale**:
   - Crea istanze di `Cane` e `Gatto`, e invoca i loro metodi.
   - Dimostra l'uso del polimorfismo assegnando istanze di `Cane` e `Gatto` a variabili di tipo `Animale`.
   - Mostra che i metodi sovrascritti vengono chiamati correttamente anche quando si utilizzano riferimenti di tipo base (`Animale`).



_____________________________________________________________



# Parte 2 

<br><br><br>
<br><br><br>
<br><br><br>
______________________

### Disaccoppiamento dei Metodi e Gestione degli Eventi in C#

Il disaccoppiamento dei metodi e la gestione degli eventi sono concetti chiave nella programmazione orientata agli oggetti. In C#, ciò viene spesso realizzato tramite l'uso di delegati, espressioni lambda e eventi.

### Dichiarazione e Uso dei Delegati

I delegati sono tipi di riferimento che rappresentano metodi con una firma specifica. Possono essere usati per passare metodi come parametri ad altri metodi.

#### Dichiarazione di un Delegato

```csharp
public delegate void Operazione(int a, int b);
```

#### Utilizzo di un Delegato

```csharp
public class Calcolatrice
{
    public void Somma(int a, int b)
    {
        Console.WriteLine($"Somma: {a + b}");
    }

    public void Sottrai(int a, int b)
    {
        Console.WriteLine($"Sottrai: {a - b}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calcolatrice calc = new Calcolatrice();
        Operazione operazione;

        operazione = calc.Somma;
        operazione(5, 3);  // Output: Somma: 8

        operazione = calc.Sottrai;
        operazione(5, 3);  // Output: Sottrai: 2
    }
}
```

### Utilizzo delle Espressioni Lambda

Le espressioni lambda forniscono una sintassi concisa per scrivere delegati anonimi. Possono essere utilizzate per creare istanze di delegati in modo più compatto.

#### Esempio di Espressione Lambda

```csharp
Operazione operazione;

operazione = (a, b) => Console.WriteLine($"Somma: {a + b}");
operazione(5, 3);  // Output: Somma: 8

operazione = (a, b) => Console.WriteLine($"Sottrai: {a - b}");
operazione(5, 3);  // Output: Sottrai: 2
```

### Gestione degli Eventi

Gli eventi in C# sono una sintassi speciale per i delegati che permette alle classi di fornire notifiche ai client quando accadono determinate azioni.

#### Dichiarazione di un Evento

```csharp
public class Processo
{
    // Dichiarazione del delegato
    public delegate void ProcessoCompletatoHandler();

    // Dichiarazione dell'evento
    public event ProcessoCompletatoHandler ProcessoCompletato;

    public void AvviaProcesso()
    {
        Console.WriteLine("Processo in esecuzione...");
        // Logica del processo

        // Sollevare l'evento quando il processo è completato
        OnProcessoCompletato();
    }

    protected virtual void OnProcessoCompletato()
    {
        if (ProcessoCompletato != null)
        {
            ProcessoCompletato();
        }
    }
}
```

#### Sottoscrizione e Gestione di un Evento

```csharp
class Program
{
    static void Main(string[] args)
    {
        Processo processo = new Processo();

        // Sottoscrivere l'evento
        processo.ProcessoCompletato += Processo_ProcessoCompletato;

        processo.AvviaProcesso();
    }

    private static void Processo_ProcessoCompletato()
    {
        Console.WriteLine("Il processo è stato completato!");
    }
}
```

### Esempio Completo

Ecco un esempio completo che combina delegati, espressioni lambda e gestione di eventi:

```csharp
using System;

public delegate void Operazione(int a, int b);

public class Calcolatrice
{
    public void Somma(int a, int b)
    {
        Console.WriteLine($"Somma: {a + b}");
    }

    public void Sottrai(int a, int b)
    {
        Console.WriteLine($"Sottrai: {a - b}");
    }
}

public class Processo
{
    public delegate void ProcessoCompletatoHandler();
    public event ProcessoCompletatoHandler ProcessoCompletato;

    public void AvviaProcesso()
    {
        Console.WriteLine("Processo in esecuzione...");
        // Logica del processo

        // Sollevare l'evento
        OnProcessoCompletato();
    }

    protected virtual void OnProcessoCompletato()
    {
        if (ProcessoCompletato != null)
        {
            ProcessoCompletato();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calcolatrice calc = new Calcolatrice();
        Operazione operazione;

        // Utilizzo di espressioni lambda per delegati
        operazione = (a, b) => Console.WriteLine($"Somma Lambda: {a + b}");
        operazione(5, 3);  // Output: Somma Lambda: 8

        operazione = calc.Somma;
        operazione(5, 3);  // Output: Somma: 8

        operazione = calc.Sottrai;
        operazione(5, 3);  // Output: Sottrai: 2

        // Gestione degli eventi
        Processo processo = new Processo();
        processo.ProcessoCompletato += () => Console.WriteLine("Il processo è stato completato!");
        processo.AvviaProcesso();
    }
}
```

### Spiegazione dell'Esempio Completo

1. **Dichiarazione del Delegato**: `Operazione` è un delegato che accetta due interi.
2. **Classe `Calcolatrice`**: Contiene metodi `Somma` e `Sottrai`.
3. **Classe `Processo`**: Dichiarazione di un evento `ProcessoCompletato`.
4. **Metodo `Main`**:
   - Utilizzo di espressioni lambda per definire rapidamente operazioni.
   - Esempi di utilizzo del delegato `Operazione` con metodi `Somma` e `Sottrai`.
   - Gestione dell'evento `ProcessoCompletato`.


Questo esempio mostra come combinare delegati, espressioni lambda e eventi per creare un codice flessibile e disaccoppiato.


_____________________


## DELEGATI :


I delegati in C# sono una caratteristica potente e versatile che serve per diverse finalità. Ecco alcuni dei principali usi e vantaggi dei delegati:

### 1. **Disaccoppiamento del Codice**

I delegati consentono di disaccoppiare il codice, separando l'invocazione di un metodo dalla sua implementazione. Questo è utile quando si desidera passare metodi come parametri ad altri metodi, creando un codice più modulare e facile da mantenere.

### 2. **CallBacks**

I delegati vengono utilizzati per implementare callback, che sono metodi passati come parametri e chiamati in un momento successivo. Questo è comune in programmazione asincrona e basata su eventi.

### 3. **Programmazione Orientata agli Eventi**

Gli eventi in C# sono basati sui delegati. Gli eventi permettono agli oggetti di notificare altre parti del programma quando si verifica un'azione specifica, come un click del mouse o il completamento di un'operazione.

### 4. **Metodi Anonimi ed Espressioni Lambda**

I delegati sono alla base delle espressioni lambda e dei metodi anonimi, che consentono di definire blocchi di codice concisi e temporanei da passare come parametri.

### Esempi Pratici di Utilizzo dei Delegati

#### 1. **Disaccoppiamento del Codice**

Immagina di avere una classe `Calcolatrice` con diversi metodi di operazioni matematiche:

```csharp
public class Calcolatrice
{
    public int Somma(int a, int b) => a + b;
    public int Sottrai(int a, int b) => a - b;
    public int Moltiplica(int a, int b) => a * b;
}
```

Puoi definire un delegato per rappresentare questi metodi:

```csharp
public delegate int OperazioneMatematica(int a, int b);
```

E utilizzarli in modo disaccoppiato:

```csharp
class Program
{
    static void Main()
    {
        Calcolatrice calc = new Calcolatrice();
        OperazioneMatematica operazione;

        operazione = calc.Somma;
        Console.WriteLine("Somma: " + operazione(5, 3));  // Output: Somma: 8

        operazione = calc.Sottrai;
        Console.WriteLine("Sottrai: " + operazione(5, 3));  // Output: Sottrai: 2
    }
}
```

#### 2. **Callback**

Supponiamo di avere un metodo che esegue un'operazione asincrona e desideri notificare il completamento:

```csharp
public class Processo
{
    public delegate void ProcessoCompletatoHandler();
    public void AvviaProcesso(ProcessoCompletatoHandler callback)
    {
        Console.WriteLine("Processo in esecuzione...");
        // Simulazione di un processo
        System.Threading.Thread.Sleep(1000);
        // Notifica il completamento
        callback();
    }
}
```

Utilizzo del callback:

```csharp
class Program
{
    static void Main()
    {
        Processo processo = new Processo();
        processo.AvviaProcesso(() => Console.WriteLine("Il processo è stato completato!"));
    }
}
```

#### 3. **Programmazione Orientata agli Eventi**

Gli eventi in C# sono dichiarati utilizzando i delegati:

```csharp
public class Processo
{
    public delegate void ProcessoCompletatoHandler();
    public event ProcessoCompletatoHandler ProcessoCompletato;

    public void AvviaProcesso()
    {
        Console.WriteLine("Processo in esecuzione...");
        // Simulazione di un processo
        System.Threading.Thread.Sleep(1000);
        // Solleva l'evento al completamento
        OnProcessoCompletato();
    }

    protected virtual void OnProcessoCompletato()
    {
        ProcessoCompletato?.Invoke();
    }
}
```

Sottoscrizione e gestione dell'evento:

```csharp
class Program
{
    static void Main()
    {
        Processo processo = new Processo();
        processo.ProcessoCompletato += () => Console.WriteLine("Il processo è stato completato!");
        processo.AvviaProcesso();
    }
}
```

### 4. **Metodi Anonimi ed Espressioni Lambda**

Utilizzare espressioni lambda con delegati:

```csharp
OperazioneMatematica somma = (a, b) => a + b;
Console.WriteLine("Somma Lambda: " + somma(5, 3));  // Output: Somma Lambda: 8
```

### Vantaggi dei Delegati

1. **Flessibilità**: Consentono di passare metodi come parametri, permettendo di scegliere quale metodo eseguire in fase di runtime.
2. **Riutilizzabilità del Codice**: Consentono di creare metodi generici che possono chiamare diversi metodi specificati dall'utente.
3. **Manutenibilità**: Facilitano la scrittura di codice che è più modulare e più facile da aggiornare.
4. **Compatibilità con gli Eventi**: Sono essenziali per la programmazione orientata agli eventi, permettendo di definire e gestire eventi in modo semplice.

In conclusione, i delegati in C# sono strumenti potenti per disaccoppiare il codice, implementare callback, gestire eventi e lavorare con espressioni lambda, migliorando la flessibilità e la manutenibilità del codice.



_________________________________


#  12 - Utilizzo di collezioni e costruzione di tipi generici

Lavorare con le raccolte Creazione e utilizzo di tipi generici Definire interfacce generiche e comprendere la varianza Utilizzo di metodi e delegati generici



### Lavorare con le Collezioni in C#

Le collezioni sono strutture dati che consentono di memorizzare e gestire gruppi di oggetti. C# fornisce diverse collezioni nella libreria standard, come `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, `Stack<T>`, ecc.

#### Esempio: Utilizzo di `List<T>`

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeri = new List<int> { 1, 2, 3, 4, 5 };
        numeri.Add(6);
        numeri.Remove(3);

        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
    }
}
```

### Creazione e Utilizzo di Tipi Generici

I tipi generici permettono di creare classi e metodi che funzionano con qualsiasi tipo di dato senza compromettere la sicurezza del tipo. Questo aumenta la riusabilità e la flessibilità del codice.

#### Esempio: Classe Generica `Stack<T>`

```csharp
public class Stack<T>
{
    private List<T> elements = new List<T>();

    public void Push(T item)
    {
        elements.Add(item);
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Lo stack è vuoto.");
        }

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Lo stack è vuoto.");
        }

        return elements[elements.Count - 1];
    }

    public int Count
    {
        get { return elements.Count; }
    }
}
```

#### Utilizzo della Classe Generica

```csharp
class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Peek()); // Output: 2
        Console.WriteLine(stack.Count);  // Output: 2
    }
}
```

### Definire Interfacce Generiche e Comprendere la Varianza

Le interfacce generiche permettono di definire contratti che i tipi generici devono rispettare. La varianza consente di specificare come i tipi generici possono essere convertiti tra loro.

#### Esempio: Interfaccia Generica `IRepository<T>`

```csharp
public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    T GetById(int id);
    IEnumerable<T> GetAll();
}
```

#### Implementazione dell'Interfaccia Generica

```csharp
public class Repository<T> : IRepository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public T GetById(int id)
    {
        // Questa è una simulazione, in un caso reale avresti un modo per ottenere l'ID
        return items[id];
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }
}
```

#### Utilizzo dell'Interfaccia Generica

```csharp
class Program
{
    static void Main()
    {
        IRepository<int> intRepo = new Repository<int>();
        intRepo.Add(1);
        intRepo.Add(2);
        intRepo.Add(3);

        foreach (var item in intRepo.GetAll())
        {
            Console.WriteLine(item);
        }
    }
}
```

### Utilizzo di Metodi e Delegati Generici

I metodi generici permettono di definire metodi che possono operare su tipi diversi. I delegati generici permettono di definire riferimenti a metodi che possono avere parametri di tipi diversi.

#### Esempio: Metodo Generico

```csharp
public class Util
{
    public static void Scambia<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
```

#### Utilizzo del Metodo Generico

```csharp
class Program
{
    static void Main()
    {
        int x = 1;
        int y = 2;
        Util.Scambia(ref x, ref y);

        Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 2, y: 1
    }
}
```

#### Esempio: Delegato Generico

```csharp
public delegate T Operazione<T>(T a, T b);

class Program
{
    static void Main()
    {
        Operazione<int> somma = (a, b) => a + b;
        Console.WriteLine(somma(3, 4)); // Output: 7

        Operazione<string> concatena = (a, b) => a + b;
        Console.WriteLine(concatena("Hello, ", "world!")); // Output: Hello, world!
    }
}
```

### Spiegazione

- **Collezioni**: `List<T>` è utilizzata per memorizzare e gestire una lista di interi.
- **Tipi Generici**: La classe `Stack<T>` è generica, consentendo di creare uno stack per qualsiasi tipo.
- **Interfacce Generiche**: `IRepository<T>` definisce un contratto generico per un repository. `Repository<T>` lo implementa.
- **Metodi Generici**: Il metodo `Scambia<T>` scambia i valori di due variabili di qualsiasi tipo.
- **Delegati Generici**: `Operazione<T>` permette di definire operazioni generiche, come somma di interi e concatenazione di stringhe.

Questi esempi mostrano come lavorare con le collezioni e come creare e utilizzare tipi, interfacce, metodi e delegati generici, offrendo flessibilità e riusabilità nel codice C#.

________________________________


# GARBAGE COLLECTION


### Gestione della Durata degli Oggetti e Controllo delle Risorse in C#

In C#, la gestione della durata degli oggetti e il controllo delle risorse sono aspetti fondamentali per garantire l'efficienza e la stabilità delle applicazioni. Questi concetti sono strettamente legati alla gestione della memoria e delle risorse non gestite (come file, connessioni di rete e database).

### Introduzione alla Garbage Collection

La Garbage Collection (GC) in C# è un processo automatico che gestisce l'allocazione e la deallocazione della memoria per gli oggetti. Il GC rileva e rimuove gli oggetti che non sono più raggiungibili dal codice dell'applicazione, liberando così la memoria.

#### Funzionamento della Garbage Collection

1. **Allocazione**: Quando un oggetto viene creato, la memoria viene allocata nel managed heap.
2. **Generazioni**: Gli oggetti sono suddivisi in tre generazioni (0, 1, 2) per ottimizzare la gestione della memoria.
3. **Raccolta**: Il GC esegue una raccolta quando la memoria è insufficiente o viene esplicitamente richiesta tramite `GC.Collect()`.
4. **Compattazione**: Dopo la raccolta, il GC compatta la memoria, riducendo la frammentazione.

### Esempio: Garbage Collection

```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 1000; i++)
        {
            var obj = new object();
        }

        Console.WriteLine("Eseguito il loop.");
        GC.Collect();  // Richiama esplicitamente la Garbage Collection
        GC.WaitForPendingFinalizers();  // Attende che tutti i finalizzatori pendenti vengano eseguiti
        Console.WriteLine("Garbage Collection eseguita.");
    }
}
```

### Gestione delle Risorse

Oltre alla memoria, le applicazioni devono gestire risorse non gestite come file, connessioni di rete e database. In C#, la gestione delle risorse viene tipicamente eseguita utilizzando il pattern `Dispose` e l'interfaccia `IDisposable`.

#### Pattern Dispose e Interfaccia IDisposable

L'interfaccia `IDisposable` definisce un metodo `Dispose` che deve essere implementato per rilasciare le risorse.

```csharp
public class Risorsa : IDisposable
{
    private bool disposed = false;

    public void UsaRisorsa()
    {
        if (disposed)
        {
            throw new ObjectDisposedException("Risorsa");
        }
        Console.WriteLine("Usando la risorsa...");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);  // Impedisce che il finalizzatore venga chiamato
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Rilascia le risorse gestite
            }
            // Rilascia le risorse non gestite
            disposed = true;
        }
    }

    ~Risorsa()
    {
        Dispose(false);
    }
}
```

#### Utilizzo del Pattern Dispose

```csharp
class Program
{
    static void Main()
    {
        using (var risorsa = new Risorsa())
        {
            risorsa.UsaRisorsa();
        }  // Dispose viene chiamato automaticamente alla fine del blocco using

        Console.WriteLine("Risorsa gestita.");
    }
}
```

### Esempio Completo: Gestione di File con `StreamWriter`

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "example.txt";

        // Scrittura di un file usando StreamWriter
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Ciao, mondo!");
        }  // StreamWriter viene chiuso e risorse rilasciate automaticamente

        // Lettura di un file usando StreamReader
        using (StreamReader reader = new StreamReader(path))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("Contenuto del file: " + content);
        }  // StreamReader viene chiuso e risorse rilasciate automaticamente
    }
}
```

### Spiegazione del Codice

1. **Garbage Collection**:
   - Nel primo esempio, il metodo `GC.Collect()` viene chiamato esplicitamente per forzare la garbage collection. Questo è generalmente sconsigliato poiché il GC gestisce la memoria in modo efficiente e chiamarlo manualmente può causare un degrado delle prestazioni.

2. **Pattern Dispose**:
   - La classe `Risorsa` implementa `IDisposable` e definisce il metodo `Dispose` per rilasciare risorse. Il metodo `Dispose` viene chiamato automaticamente alla fine del blocco `using`, garantendo che le risorse siano rilasciate correttamente.
   - Il metodo `Dispose(bool disposing)` differenzia tra risorse gestite e non gestite. Le risorse non gestite vengono rilasciate sia in `Dispose` che nel distruttore `~Risorsa`, mentre le risorse gestite vengono rilasciate solo in `Dispose`.

3. **Gestione di File**:
   - L'uso di `StreamWriter` e `StreamReader` all'interno di un blocco `using` garantisce che i file vengano chiusi e le risorse rilasciate correttamente alla fine del blocco.

### Conclusioni

- **Garbage Collection**: Automatica e gestita dal runtime, libera la memoria degli oggetti non più in uso.
- **Pattern Dispose e IDisposable**: Forniscono un modo per rilasciare risorse non gestite in modo deterministico, assicurando che risorse come file e connessioni vengano correttamente chiuse e rilasciate.

Gestire correttamente la durata degli oggetti e le risorse è cruciale per evitare perdite di memoria e garantire l'efficienza e la stabilità delle applicazioni C#.


________________________________________________




# PROGRAMMAZIONE ASYNCRONA

<br><br><br><br>

### Programmazione Asincrona in C#

La programmazione asincrona consente di eseguire operazioni in background senza bloccare il thread principale. In C#, le parole chiave `async` e `await` semplificano notevolmente la scrittura di codice asincrono.

#### Esempio: Utilizzo di `async` e `await`

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://jsonplaceholder.typicode.com/posts/1";
        string data = await FetchDataAsync(url);
        Console.WriteLine(data);
    }

    static async Task<string> FetchDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
```

### Creazione di una Classe di Raccolta Personalizzata

Le classi di raccolta personalizzate permettono di definire strutture dati specifiche che si adattano meglio alle esigenze della propria applicazione.

#### Esempio: Classe di Raccolta Personalizzata `SimpleList<T>`

```csharp
using System;
using System.Collections;
using System.Collections.Generic;

public class SimpleList<T> : IEnumerable<T>
{
    private T[] items;
    private int count;

    public SimpleList()
    {
        items = new T[4];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, count * 2);
        }
        items[count++] = item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        }
    }

    public int Count => count;

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
```

#### Utilizzo della Classe di Raccolta Personalizzata

```csharp
class Program
{
    static void Main()
    {
        SimpleList<int> list = new SimpleList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Console.WriteLine("Elementi nella lista:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Elemento all'indice 1: {list[1]}");
    }
}
```

### Semplificazione del Codice

Semplificare il codice significa renderlo più leggibile, manutenibile e privo di ridondanze. Ci sono diverse tecniche per raggiungere questo obiettivo:

- **Usare metodi ed espressioni lambda** per ridurre il boilerplate code.
- **Utilizzare pattern di progettazione** appropriati.
- **Rifattorizzare il codice** per eliminare la duplicazione.

#### Esempio: Utilizzo di Espressioni Lambda

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Numeri pari:");
        evenNumbers.ForEach(Console.WriteLine);
    }
}
```

### Combinare Tutti i Concetti

#### Programma Completo: Asincrono, Raccolta Personalizzata e Codice Semplificato

```csharp
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

public class SimpleList<T> : IEnumerable<T>
{
    private T[] items;
    private int count;

    public SimpleList()
    {
        items = new T[4];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, count * 2);
        }
        items[count++] = item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        }
    }

    public int Count => count;

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

class Program
{
    static async Task Main(string[] args)
    {
        // Asynchronous fetch data example
        string url = "https://jsonplaceholder.typicode.com/posts";
        var data = await FetchDataAsync(url);
        Console.WriteLine("Fetched Data:");
        Console.WriteLine(data);

        // Using the custom collection class
        SimpleList<string> list = new SimpleList<string>();
        list.Add("First");
        list.Add("Second");
        list.Add("Third");

        Console.WriteLine("Items in the list:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Item at index 1: {list[1]}");

        // Using LINQ to simplify code
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even Numbers:");
        evenNumbers.ForEach(Console.WriteLine);
    }

    static async Task<string> FetchDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
```

### Spiegazione del Codice

1. **Programmazione Asincrona**:
   - Il metodo `FetchDataAsync` utilizza `HttpClient` per fare una richiesta HTTP in modo asincrono. `await` è usato per attendere il completamento dell'operazione senza bloccare il thread principale.

2. **Classe di Raccolta Personalizzata**:
   - `SimpleList<T>` è una classe generica che implementa `IEnumerable<T>` per consentire l'enumerazione degli elementi. Supporta l'aggiunta dinamica di elementi e l'accesso tramite indice.

3. **Semplificazione del Codice**:
   - Le espressioni lambda e LINQ vengono utilizzate per filtrare e operare sulla lista di numeri, rendendo il codice più conciso e leggibile.

### Conclusioni

La combinazione di programmazione asincrona, la creazione di classi di raccolta personalizzate e la semplificazione del codice porta a soluzioni più efficienti, manutenibili e performanti. Utilizzare questi concetti in modo efficace consente di scrivere codice più pulito e robusto in C#.


______________________________________________________________________________



### Utilizzo di LINQ per Interrogare i Dati

LINQ (Language Integrated Query) è una potente funzionalità di C# che consente di scrivere query direttamente nel codice utilizzando una sintassi simile a SQL. LINQ può essere utilizzato per interrogare vari tipi di dati, come array, liste, collezioni, XML, dataset e database relazionali.

### Utilizzo di Metodi di Estensione LINQ e Operatori di Query

LINQ fornisce due sintassi principali: la sintassi basata su metodi di estensione e la sintassi delle query. Entrambe le sintassi offrono una vasta gamma di operatori per filtrare, ordinare, raggruppare e trasformare i dati.


LINQ semplifica l'interrogazione dei dati in C#, offrendo una sintassi concisa e potente. La capacità di costruire query dinamiche consente di creare applicazioni flessibili che possono adattarsi a condizioni di runtime variabili. Utilizzare LINQ migliora la leggibilità e manutenibilità del codice, rendendo le operazioni di filtraggio, ordinamento e trasformazione dei dati più intuitive.



#### Esempio: Sintassi dei Metodi di Estensione

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Utilizzo di metodi di estensione LINQ
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        var squaredNumbers = numbers.Select(n => n * n).ToList();
        var sumOfNumbers = numbers.Sum();
        
        Console.WriteLine("Numeri pari:");
        evenNumbers.ForEach(Console.WriteLine);

        Console.WriteLine("Numeri quadrati:");
        squaredNumbers.ForEach(Console.WriteLine);

        Console.WriteLine("Somma dei numeri:");
        Console.WriteLine(sumOfNumbers);
    }
}
```

#### Esempio: Sintassi delle Query

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Utilizzo della sintassi delle query LINQ
        var evenNumbers = from n in numbers
                          where n % 2 == 0
                          select n;

        var squaredNumbers = from n in numbers
                             select n * n;

        var sumOfNumbers = (from n in numbers
                            select n).Sum();

        Console.WriteLine("Numeri pari:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Numeri quadrati:");
        foreach (var number in squaredNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Somma dei numeri:");
        Console.WriteLine(sumOfNumbers);
    }
}
```

### Creazione di Query ed Espressioni LINQ Dinamiche

A volte è necessario costruire query LINQ in modo dinamico in base a condizioni runtime. Questo può essere ottenuto utilizzando espressioni lambda e l'API `System.Linq.Expressions`.

#### Esempio: Query Dinamica con `System.Linq.Expressions`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 },
            new Person { Name = "Bob", Age = 35 }
        };

        // Costruire dinamicamente una query per filtrare persone con età maggiore di un valore specificato
        int ageThreshold = 28;
        var filteredPeople = FilterPeopleByAge(people, ageThreshold);

        Console.WriteLine($"Persone con età maggiore di {ageThreshold}:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }
    }

    static IEnumerable<Person> FilterPeopleByAge(IEnumerable<Person> people, int age)
    {
        var parameter = Expression.Parameter(typeof(Person), "p");
        var property = Expression.Property(parameter, "Age");
        var constant = Expression.Constant(age);
        var comparison = Expression.GreaterThan(property, constant);
        var predicate = Expression.Lambda<Func<Person, bool>>(comparison, parameter).Compile();

        return people.Where(predicate);
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

### Spiegazione del Codice

1. **Sintassi dei Metodi di Estensione**:
   - `Where`: Filtra la sequenza di numeri selezionando solo quelli pari.
   - `Select`: Trasforma ogni numero nella sua radice quadrata.
   - `Sum`: Calcola la somma di tutti i numeri.

2. **Sintassi delle Query**:
   - Utilizza una sintassi simile a SQL per eseguire le stesse operazioni della sintassi dei metodi di estensione.

3. **Query Dinamiche**:
   - L'uso di `System.Linq.Expressions` permette di creare dinamicamente espressioni lambda.
   - `Expression.Parameter` crea un parametro per la lambda.
   - `Expression.Property` ottiene la proprietà `Age` dell'oggetto `Person`.
   - `Expression.GreaterThan` crea una condizione di confronto.
   - `Expression.Lambda<Func<Person, bool>>` crea una lambda e la compila in un delegato.
   - `people.Where(predicate)` filtra la lista delle persone in base alla condizione dinamica.




_______________________________________________________________________________________________


$${\color{red}TDD}$$


# TDD

### Sviluppo Basato su Test (Test-Driven Development - TDD) in C#

Il Sviluppo Basato su Test (TDD) è una metodologia di sviluppo software in cui i test vengono scritti prima del codice effettivo. L'idea principale è scrivere un test che fallisca, quindi scrivere il codice minimo necessario per far passare il test, e infine rifattorizzare il codice per migliorarlo mantenendo i test positivi.

### Principi del TDD

1. **Scrivi un test che fallisca**: Prima di scrivere qualsiasi codice, scrivi un test che definisca una nuova funzione o miglioria. Il test inizialmente fallirà poiché la funzionalità non è ancora implementata.
2. **Scrivi il codice minimo necessario**: Scrivi solo il codice necessario per far passare il test. Non aggiungere funzionalità extra.
3. **Rifattorizza il codice**: Migliora il codice mantenendo tutti i test positivi. La rifattorizzazione include l'eliminazione della duplicazione e l'ottimizzazione del design.

### Strumenti per il TDD in C#

- **xUnit**: Un popolare framework di test per .NET.
- **NUnit**: Un altro framework di test ampiamente utilizzato.
- **MSTest**: Il framework di test ufficiale di Microsoft.

In questo esempio, useremo xUnit per dimostrare il TDD.

### Esempio Completo di TDD con xUnit

#### 1. Installare xUnit

Per utilizzare xUnit, aggiungi il pacchetto `xunit` e `xunit.runner.visualstudio` al tuo progetto. Questo può essere fatto tramite NuGet Package Manager in Visual Studio o aggiungendo direttamente le dipendenze al file `.csproj`.

```xml
<PackageReference Include="xunit" Version="2.4.1" />
<PackageReference Include="xunit.runner.visualstudio" Version="2.4.3" />
```

#### 2. Scrivere il Primo Test (Red)

Crea una classe di test e scrivi un test che inizialmente fallisca.

```csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_WhenCalled_ReturnsSumOfArguments()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(1, 2);

        // Assert
        Assert.Equal(3, result);
    }
}
```

#### 3. Scrivere il Codice Minimo (Green)

Implementa il codice necessario per far passare il test.

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
```

#### 4. Rifattorizzare il Codice (Refactor)

In questo esempio, il codice è già piuttosto semplice e non necessita di rifattorizzazione. Tuttavia, se ci fossero delle duplicazioni o un design migliorabile, questo sarebbe il momento di fare modifiche mantenendo i test verdi.

### Esempio Esteso: Calcolatrice con Operazioni Multiple

Supponiamo di voler estendere la calcolatrice per includere operazioni di sottrazione, moltiplicazione e divisione.

#### 1. Scrivere Test per Nuove Funzionalità

```csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_WhenCalled_ReturnsSumOfArguments()
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Subtract_WhenCalled_ReturnsDifferenceOfArguments()
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Multiply_WhenCalled_ReturnsProductOfArguments()
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(3, 4);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_WhenCalled_ReturnsQuotientOfArguments()
    {
        var calculator = new Calculator();
        var result = calculator.Divide(8, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(8, 0));
    }
}
```

#### 2. Implementare il Codice Minimo per Far Passare i Test

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}
```

#### 3. Rifattorizzare il Codice (se necessario)

In questo caso, il codice è già ben strutturato. Se ci fossero miglioramenti o ottimizzazioni da fare, dovrebbero essere fatte in questa fase mantenendo i test verdi.

### Conclusioni

Il TDD aiuta a scrivere codice più pulito, manutenibile e privo di bug. La metodologia obbliga a pensare ai requisiti e ai casi d'uso prima di scrivere il codice, migliorando così la qualità complessiva del software. Utilizzando framework di test come xUnit, NUnit o MSTest, è possibile integrare facilmente il TDD nel proprio workflow di sviluppo C#.


_____________________


$${\color{red}DESIGN PATTERN}$$














