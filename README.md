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







