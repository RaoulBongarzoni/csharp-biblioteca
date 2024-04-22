using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public List<Document> documents = new List<Document>();
        
        public List<User> users;

        public Dictionary<decimal, decimal> lends;








        //ricerca per codice 

        public void cercaDocumento(List<Document> archivio, int codice)
        {
            foreach (Document document in archivio)
            {


                if (document.Code == codice)
                {
                    Console.WriteLine("libro trovato");
                    return;
                }

            }
            Console.WriteLine("libro non trovato");

        }

        //ricerca per titolo
        public void cercaPerNome(List<Document> archivio, string nameSearch)
        {
            foreach (var item in archivio)

            {

                if (item.Title.Contains(nameSearch))
                {
                    Console.WriteLine("trovato !!");
                }
            }
            Console.WriteLine("non trovato");
        }
    }
        


        



}
