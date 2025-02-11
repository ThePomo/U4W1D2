using System;

class Program
{
    static void Main()
    {
      
        Persona persona1 = new Persona("Giuseppe Davide Salvatore", "Pomo", 30);

     
        Console.WriteLine("Dettagli della Persona:");
        Console.WriteLine("Nome: " + persona1.GetNome());
        Console.WriteLine("Cognome: " + persona1.GetCognome());
        Console.WriteLine("Età: " + persona1.GetEta());
        Console.WriteLine("Tutti i dettagli: " + persona1.GetDettagli());
    }
}