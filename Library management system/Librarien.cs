using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Librarien : User
    {
        public int EmployeeNumber { get; set; }

        public Librarien(string name)
        {
            Name = name;
        }

        //passing addmethod from library class ( to not write the method of adding twice  )
        public void AddBook(Book newbook, Library library)
        {
           library.Add(newbook);
        }
        public void RemoveBook(Book newbook, Library library)
        {
            library.Add(newbook);
        }
    }
}
