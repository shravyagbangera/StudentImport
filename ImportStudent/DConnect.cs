using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportStudent
{
    internal class DConnect
    {
        public string Getconnection() 
        {
            String connection = "Data Source=.;Initial Catalog=Student;Integrated Security=True";
return connection;
        }
    }
}
