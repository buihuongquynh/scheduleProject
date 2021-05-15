using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DAO
{
    class doAnDAO
    {
        private static doAnDAO _Instance;
        public static doAnDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new doAnDAO();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public doAnDAO()
        {
        }

        //cac cau lenh SQL 
    }
}
