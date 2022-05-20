using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    class Biblioteca
    {
        public string Nome { get; set; }
        public List<Documento> Documenti { get; set; }
        public List<Prestito> Prestiti { get; set; }

        public List<Utente> Utenti { get; set; }
        public ListaUtenti MiaListaUtenti { get; set; }

        
       

        public Biblioteca(string Nome)
        {
            this.Nome = Nome;
            this.Documenti = new List<Documento>();
            this.Prestiti = new List<Prestito>();
            this.MiaListaUtenti = new ListaUtenti();
            this.Utenti = new List<Utente>();

        }
        static string variabileAmbiente = Environment.GetEnvironmentVariable("PUBLIC");

        static string pathSalva = variabileAmbiente + "\\Biblioteca" + "\\bibliotecaSalva.txt";

        public bool SaveUtenti()
        {
            
            try
            {
                string variabileAmbiente = Environment.GetEnvironmentVariable("PUBLIC");

                string path = variabileAmbiente + "\\Biblioteca" +"\\bibliotecaSalva.txt";

                // salva in C:\Users\Public\Biblioteca\biblioteca.txt  
                //creato dal metodo CreaFilediSalvataggio() in program

                Console.WriteLine("percorso di salvataggio è {0}", pathSalva);
                //StreamWriter sw = new StreamWriter(@"C: \Users\Public\Biblioteca\biblioteca.txt");

                StreamWriter sw = new StreamWriter(pathSalva);

                //sw.WriteLine("ListaUtenti");

                foreach (Utente utente in Utenti)
                {
                    sw.WriteLine(utente.Nome + ":" + utente.Cognome + ":" + utente.Telefono + ":" + utente.Email + ":" + utente.Password);

                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool RestoreUtenti()
        {
            string linea = "";
            try
            {
                StreamReader leggi = new StreamReader(pathSalva);
            
                while ((linea = leggi.ReadLine()) != null)
                {
                    
                    char separatore = ':';

                    string[] vetStringhe = linea.Split(separatore);

                    Utente nuovoUtente = new Utente(vetStringhe[0], vetStringhe[1], vetStringhe[2], vetStringhe[3], vetStringhe[4]);
                    
                    Utenti.Add(nuovoUtente);
                    
                    leggi.Close();

                }
                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false; 
            }

        }



        public List<Documento> SearchByCodice(string Codice)
        {
            return this.Documenti.Where(d => d.Codice == Codice).ToList();
        }

        public List<Documento> SearchByTitolo(string Titolo)
        {
            return this.Documenti.Where(d => d.Titolo == Titolo).ToList();
        }

        public List<Prestito> SearchPrestiti(string Numero)
        {
            return this.Prestiti.Where(p => p.Numero == Numero).ToList();
        }

        public List<Prestito> SearchPrestiti(string Nome, string Cognome)
        {
            return this.Prestiti.Where(p => p.Utente.Nome == Nome && p.Utente.Cognome == Cognome).ToList();
        }
    }
}
