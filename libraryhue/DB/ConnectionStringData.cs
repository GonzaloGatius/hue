using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.DB
{
    public class ConnectionStringData
    {
        public string ConnectionStringName { get; set; }

        public ConnectionStringData()
        {
            ConnectionStringName = "Default";
        }
    }
}
