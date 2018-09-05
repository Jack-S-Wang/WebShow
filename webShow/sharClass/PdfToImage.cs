using Spire.Pdf;
using System;
using System.Drawing;
using System.IO;

namespace webShow.sharClass
{
    public class PdfToImage
    {
        Bitmap bmp;
        public byte[] getBitmap(string fileName)
        {
            byte[] dataAll = new byte[0];
            PdfDocument doc = new PdfDocument();
            // Load PDF file 
            doc.LoadFromFile(fileName);
            //doc.LoadFromBytes(data);
            for (int i = 0; i < doc.Pages.Count; i++)
            {
                // Save the page which is specified as System.Drawing.Bitmap object 
                bmp = doc.SaveAsImage(i) as Bitmap;
                using (MemoryStream Ms = new MemoryStream())
                {
                    bmp.Save(Ms, System.Drawing.Imaging.ImageFormat.Jpeg);//把图像数据序列化到内存
                    byte[] imgByte = new byte[Ms.Length];
                    Ms.Position = 0;
                    Ms.Read(imgByte, 0, Convert.ToInt32(Ms.Length));//反序列，存放在字节数组里
                    var temporaryData = new byte[dataAll.Length + Ms.Length];
                    Array.Copy(dataAll, 0, temporaryData, 0, dataAll.Length);
                    Array.Copy(imgByte, 0, temporaryData, dataAll.Length, imgByte.Length);
                    dataAll = temporaryData;
                }
            }
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    ms.Position = 0;
            //    ms.Write(dataAll, 0, dataAll.Length);
            //    Bitmap newbit = new Bitmap(ms);
            //}

            return dataAll;
        }
    }
}
