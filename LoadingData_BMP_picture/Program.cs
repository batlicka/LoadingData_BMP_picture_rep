using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoadingData_BMP_picture
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            String fileName = "d:\\dokumenty\\Vojta\\UTB\\visual_studio_repos\\picturesSources\\jednoduchy1.bmp";
            FileStream fs = new FileStream("d:\\dokumenty\\Vojta\\UTB\\visual_studio_repos\\picturesSources\\jednoduchy1.bmp", FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            byte[] buff;
            buff = new byte[(int)numBytes];
            buff = br.ReadBytes((int)numBytes);

            BMP24 ArrayPic = new BMP24(buff);
            //vypíše první byte souboru na pozici [0]
            Console.Write(ArrayPic.GiveFirst());
            
            //FileToByteArray("d:\\dokumenty\\Vojta\\UTB\\visual_studio_repos\\picturesSources\\jednoduchy1.bmp");
        }
    }    
}
