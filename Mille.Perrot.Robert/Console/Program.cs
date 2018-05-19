using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio.Model;
using Biblio.Model.Entities;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Context ctx = new Context();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
