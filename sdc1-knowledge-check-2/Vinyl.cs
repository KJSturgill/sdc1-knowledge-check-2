using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdc1_knowledge_check_2
{
    internal class Vinyl : Media
    {
        public string NumberOfVinyl { get; set; }

        public Vinyl() 
        {
            NumberOfVinyl = string.Empty;
        }
    }


}
