using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingData_BMP_picture
{
    class BMP24
    {
        public byte[] buff;

        public BMP24(byte[] intBuff)
        {
            this.buff = intBuff;
        }
        public Int32 GiveFirst() {
            return buff[0];
        }
    }
}
