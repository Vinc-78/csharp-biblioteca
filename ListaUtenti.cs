using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class ListaUtenti
    {
        // private Dictionary<Tuple<string, string, string>, Utente> MyDictionary; //con le tuple
        private Dictionary<string, Utente> myDictionary;

        public ListaUtenti()
        {

            // MyDictionary = new Dictionary<Tuple<string, string, string>, Utente>();  //con le tuple

            myDictionary = new Dictionary<string, Utente>();
        }


        //Tutti i metodi per inserire, cercare e fare tutto nel dizionario

        // Metodo con le tuple
        /* public void AggiungiUtente(Utente uUtente)
         {
             var chiave = new Tuple<string, string, string>(uUtente.Nome, uUtente.Cognome, uUtente.Email);

             MyDictionary.Add(chiave, uUtente);


         } */

        public void AggiungiUtente(string Nome, string Cognome, string Telefono, string Email, string Password)
        {
            string chiave = Nome.ToLower() + ";" + Cognome.ToLower() + ";" + Email.ToLower();

            Utente nuovoUtente = new Utente(Nome, Cognome, Telefono, Email, Password);

            myDictionary.Add(chiave, nuovoUtente);
        }

        
        public void LeggiUtente(string Nome, string Cognome, string Email)
        {
            string chiave = Nome.ToLower() + ";" + Cognome.ToLower() + ";" + Email.ToLower();

            if (myDictionary.ContainsKey(chiave)) {
                Console.WriteLine("chiave inserita nel dizionario : {0}", chiave);
                Console.WriteLine(myDictionary[chiave].ToString());  }

            else { Console.WriteLine("utente non presente"); }
          
            
        }

        
    }
}
