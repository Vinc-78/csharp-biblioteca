using System;
using System.Collections.Generic;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {

            /*
             Si vuole progettare un sistema per la gestione di una biblioteca.

             Gli utenti registrati al sistema, 
             fornendo cognome, nome, email, password, recapito telefonico,

             possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).

            I documenti sono caratterizzati da un codice identificativo di tipo stringa
            
            (ISBN per i libri, numero seriale per i DVD), titolo, anno, settore 
            (storia, matematica, economia, …),
            stato (In Prestito, Disponibile), uno scaffale in cui è posizionato, 
            un elenco di autori (Nome, Cognome).

            Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
            L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, 
            effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.

            Il sistema per ogni prestito determina un numero progressivo di tipo alfanumerico.
            Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
             */

            /*
            Scaffale s1 = new Scaffale("scaf1");

            Biblioteca MiaBib = new Biblioteca("Universitaria");

            Utente u1 = new Utente("Nome 1", "Cognome 1", "Telefono 1", "Email 1", "Password 1");

            Dvd d1 = new Dvd("125", "Titolo", 1980, "Arte", 25);

            Prestito p1 = new Prestito("A01", new DateTime(2019, 1, 20), new DateTime(2019, 2, 20), u1, d1);
            */

            Biblioteca MiaBib = new Biblioteca("Universitaria");

           

            Console.WriteLine("1 : registra utente");
            Console.WriteLine("2 : richiedi prestito");

            Console.WriteLine("press enter to exit");


            Console.WriteLine("Cosa vuoi fare ? ");

            string sOperazione = Console.ReadLine();
            

            while (sOperazione != "") {

                if (sOperazione == "1")
                {
                    Console.WriteLine("Nome Utente: ");

                    string nome = Console.ReadLine();
                    if (nome == "") { 
                        Console.WriteLine("Devi scvrivere qualcosa ");
                        Console.WriteLine("Premi invio e Ricomincia");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Cognome Utente: ");
                    string cognome = Console.ReadLine();
                        if (cognome == "")
                    {
                        Console.WriteLine("Devi scvrivere qualcosa ");
                        Console.WriteLine("Premi invio e Ricomincia");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Telefono Utente: ");
                    string telefono = Console.ReadLine();
                        if (telefono == "")
                    {
                        Console.WriteLine("Devi scvrivere qualcosa ");
                        Console.WriteLine("Premi invio e Ricomincia");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }


                    Console.WriteLine("Email Utente: ");
                        string email = Console.ReadLine();
                        if (email == "")
                    {
                        Console.WriteLine("Devi scvrivere qualcosa ");
                        Console.WriteLine("Premi invio e Ricomincia");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Pasword Utente: ");
                    string psw = Console.ReadLine();
                    if (psw == "")
                    {
                        Console.WriteLine("Devi scvrivere qualcosa ");
                        Console.WriteLine("Premi invio e Ricomincia");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }


                    Utente nuovoUtente = new Utente(nome, cognome, telefono, email, psw);

                    MiaBib.MiaListaUtenti.AggiungiUtente(nome, cognome, telefono, email, psw);



                    Console.WriteLine("Hai inserito l'utente: ");
                    Console.WriteLine();
                    Console.WriteLine(nuovoUtente.ToString());

                    Console.WriteLine();
                    Console.WriteLine("-------------------");

                    // Stampa aggiunta per prova con il metodo LeggiUtente

                    Console.WriteLine("Stampa con secondo metodo(dal dizionario): ");
                    Console.WriteLine();
                    MiaBib.MiaListaUtenti.LeggiUtente(nome, cognome, email);


                    Console.WriteLine("Cosa Vuoi fare ora: ");
                    sOperazione = Console.ReadLine();
                   
                   


                }

                // da implementare....
                if (sOperazione == "2")
                {
                    Console.WriteLine("Richiedi Prestito");
                    sOperazione = Console.ReadLine();
                }


            }
        }

    }

}


    
