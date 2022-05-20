using System;
using System.Collections.Generic;
using System.Configuration;

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
            Console.WriteLine("2 : stampa la parte del main discussa in esercitazione");

            Console.WriteLine("press enter to exit");


            Console.WriteLine("Cosa vuoi fare ? ");

            string sOperazione = Console.ReadLine();


            while (sOperazione != "")
            {

                if (sOperazione == "1")
                {
                    Console.WriteLine("Nome Utente: ");

                    string nome = Console.ReadLine();
                    if (nome == "")
                    {
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

                // da implementare altre operazioni

                if (sOperazione == "2")
                {
                    // parte inserita per esercitazione ( aggiumta Lista Utenti )
                    // nella prima parte lavora con il dizionario

                    CreaFilediSalvataggio();  // metodo aggiunto nell'esercitazione del 20/05 di mattina
                                              // per la configurazione di un file di salvataggio


                    // MiaBib.RestoreUtenti(); 



                    Scaffale s1 = new Scaffale("S001");
                    Scaffale s2 = new Scaffale("S002");
                    Scaffale s3 = new Scaffale("S003");

                    Libro l1 = new Libro("ISBN1", "Titolo 1", 2009, "Storia", 220);

                    Autore a1 = new Autore("Nome 1", "Cognome 1");
                    Autore a2 = new Autore("Nome 2", "Cognome 2");

                    l1.Autori.Add(a1);
                    l1.Autori.Add(a2);

                    l1.Scaffale = s1;

                    MiaBib.Documenti.Add(l1);


                    Libro l2 = new Libro("ISBN2", "Titolo 2", 2009, "Storia", 130);

                    Autore a3 = new Autore("Nome 3", "Cognome 3");
                    Autore a4 = new Autore("Nome 4", "Cognome 4");

                    l2.Autori.Add(a3);
                    l2.Autori.Add(a4);

                    l2.Scaffale = s2;
                    MiaBib.Documenti.Add(l2);



                    Dvd dvd1 = new Dvd("Codice1", "Titolo 3", 2019, "Storia", 130);

                    dvd1.Autori.Add(a3);

                    dvd1.Scaffale = s3;
                    MiaBib.Documenti.Add(dvd1);


                    Utente u1 = new Utente("Nome 1", "Cognome 1", "Telefono 1", "Email 1", "Password 1");

                    Utente prova = new Utente("Carlo", "Prova", "TelefonoP1", "EmailP1", "PasswordP1");

                    //Importante!!! devo commentare i due Add per provare il metodo Restore riga 156

                    MiaBib.Utenti.Add(u1);  //aggiunge alla lista direttamente

                    MiaBib.Utenti.Add(prova);  //aggiunge alla lista direttamente

                    MiaBib.SaveUtenti();  // Salva gli utenti della lista

                    //Questa parte è per prendere anche gli utenti del dizionario

                    //se volessi usare il dizionario: ( per motivi solo di studio ) 

                    MiaBib.MiaListaUtenti.AggiungiUtente("Luca", "Rossi", "telefono", "email", "psw");

                    //per evitare di chiedere la psw la inserisco in provvisorio direttamente
                    string chiave = "Luca" + ";" + "Rossi" + ";" + "email";

                    //la uso per il secondo utente preso da dizionario con un metodo specifico
                    Utente u2 = MiaBib.MiaListaUtenti.SingoloUtente(chiave);


                    Prestito p1 = new Prestito("P00001", new DateTime(2019, 1, 20), new DateTime(2019, 2, 20), u1, l1);
                    Prestito p2 = new Prestito("P00002", new DateTime(2019, 3, 20), new DateTime(2019, 4, 20), u1, l2);



                    Prestito p3 = new Prestito("P00002", new DateTime(2019, 3, 20), new DateTime(2019, 4, 20), u2, l2);

                    MiaBib.Prestiti.Add(p1);
                    MiaBib.Prestiti.Add(p2);

                    // Devo modificare L'inserimento in Add e la ricerca in prestiti per gli elementi passati da stringa


                    Console.WriteLine("\n\nSearchByCodice: ISBN1\n\n");

                    List<Documento> results = MiaBib.SearchByCodice("ISBN1");

                    foreach (Documento doc in results)
                    {
                        Console.WriteLine(doc.ToString());

                        if (doc.Autori.Count > 0)
                        {
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Autori");
                            Console.WriteLine("--------------------------");
                            foreach (Autore a in doc.Autori)
                            {
                                Console.WriteLine(a.ToString());
                                Console.WriteLine("--------------------------");
                            }
                        }
                    }

                    Console.WriteLine("\n\nSearchPrestiti: Nome 1, Cognome 1\n\n");

                    List<Prestito> prestiti = MiaBib.SearchPrestiti("Nome 1", "Cognome 1");

                    foreach (Prestito p in prestiti)
                    {
                        Console.WriteLine(p.ToString());
                        Console.WriteLine("--------------------------");
                    }

                    Console.WriteLine();
                    Console.WriteLine("---------------------------");

                    Console.WriteLine("Esegui nuova operazione");
                    sOperazione = Console.ReadLine();
                }


            }
        }

        // metodo che verifica se esiste il percorso di salvataggio 

        // C:\Users\Public\Biblioteca\bibliotecaSalva.txt 

        // se non esiste legge il percoso di salvataggio da C:\Users\Public\Biblioteca\bibliotecaInfo.txt 

        static void CreaFilediSalvataggio()
        {
            string variabileAmbiente = Environment.GetEnvironmentVariable("PUBLIC");

            if (variabileAmbiente != null) { Console.WriteLine(variabileAmbiente); }

            //if(Directory.Exists("@"+ variabileAmbiente + "\\Biblioteca"))

            string variabileAmbienteCompleta = variabileAmbiente + "\\Biblioteca";

            string pathInfo = variabileAmbienteCompleta + "\\bibliotecaInfo.txt";

            string pathSalva;

            //il prossimo rigo inserisce la chiave, la commento avendo già inserita la chiave
            // AddUpdateAppSettings("pathInfo", pathInfo);

            //per usarla come stringa  ReadSetting(pathInfo)

            Console.WriteLine("la chiave inserita nel file di configurazione {0}", ReadSetting("pathInfo"));

            if (Directory.Exists(variabileAmbienteCompleta))
            { Console.WriteLine("la directory esiste"); }
            else
            {
                Directory.CreateDirectory(variabileAmbienteCompleta);
                Console.WriteLine("la directory non esisteva l'ho creata");
            }

            if (File.Exists(ReadSetting("pathInfo")))
            {
                Console.WriteLine("Il file esiste vado a leggere il percorso");


                string linea = "";
                Console.WriteLine("sto leggendo {0}", ReadSetting("pathInfo"));
                using (StreamReader leggi = new StreamReader(ReadSetting("pathInfo")))


                {

                    while ((linea = leggi.ReadLine()) != null)
                    //legge il contenuto di Info
                    {

                        pathSalva = linea;

                        //Importante
                    }

                }

            }
            else
            {
                Console.WriteLine("Preferenze di salvataggio ");
                Console.WriteLine("1 : Vuoi salvare in un nuovo file ");
                Console.WriteLine("2 : Usa il percorso standard ");

                string option = Console.ReadLine();


                if (option != null && option == "1")
                {
                    Console.WriteLine("scrivere il percorso completo del nome file : ");
                    pathSalva = Console.ReadLine();



                }
                else if (option != null && option == "2")
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(ReadSetting("pathInfo"));

                        sw.WriteLine(ReadSetting("pathInfo"));
                        sw.Close();

                        Console.WriteLine("ho creato il file");
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }

                else
                {
                    Console.WriteLine("Scelta non consentita");
                    Environment.Exit(0);
                }
            }

        }

        
        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return "";
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }



        

    }

}



