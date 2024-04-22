using System.Runtime.CompilerServices;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ARCHIVIO DOCUMENTI");

            List<Document> list = new List<Document>(10);
            for(int i = 0; i < 10 ; i++) {
                Document currentDoc = new Document();
                currentDoc.Title = i + "_documento";
                list.Add( currentDoc);
                Console.WriteLine(list[i].Title);
                Console.WriteLine(list[i].Code);
            }

            Console.WriteLine("inserisci dati utente");
            Console.WriteLine("INSERISCI IN SEQUENZA COGNOME NOME EMAIL PASSWORD TELEFONO");
            User nuovoUtente = new User(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine($" Cognome : {nuovoUtente.Surname}");
            Console.WriteLine($" Nome : {nuovoUtente.Name}");
            Console.WriteLine($" Email : {nuovoUtente.Email}");
             
            Console.WriteLine($" Numero di telefono : {nuovoUtente.PhoneNumber}");
            Console.WriteLine("INSERISCI IL CODICE DEL DOCUMENTO DA CERCARE");
            int codeToSearch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INSERISCI IL CODICE DEL DOCUMENTO DA CERCARE");
            string textToSearch = Convert.ToString(Console.ReadLine());

            Library archivio = new Library();

            Console.WriteLine("RICERCA PER CODICE");
            archivio.cercaDocumento(list, codeToSearch);
            Console.WriteLine("RICERCA PER NOME");
            archivio.cercaPerNome(list, textToSearch);
        }
    }
}
