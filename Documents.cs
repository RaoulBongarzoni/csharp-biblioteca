using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        public int Code { get; private set; }
        public string Title { get; set; }
        public int YearOfProduction { get; set; }
        public string Sector { get; set; }
        public string Scaffhold { get; set; }
        public Dictionary<string, string> Author {  get; set; }


        
        public Document ()
        {   
            Random random = new Random();
            this.Code = random.Next(1000);


        }
    }

    public class Book : Document
    {

        public int PageNumber { get; private set; }

        public Book( int pages) : base() {

            this.PageNumber = pages;




        }



    }

    public class Dvd : Document
    {

        public decimal dlenght;
        public Dvd( decimal lenght ) : base() { 

            this.dlenght = lenght;
        
        
        }


    }
}
