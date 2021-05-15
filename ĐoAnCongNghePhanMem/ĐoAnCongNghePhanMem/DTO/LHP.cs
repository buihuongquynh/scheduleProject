using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DTO
{
    class LHP
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Thu { get; set; }
        public int TietBD { get; set; }
        public int TietKT { get; set; }
        private bool Type { get; set; }
    }
}
