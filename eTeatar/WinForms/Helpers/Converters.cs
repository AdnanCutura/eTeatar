using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Helpers
{
    public static class Converters
    {
        public static System.Drawing.Image ByteArrayToSystemDrawing(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Write(byteArrayIn, 0, byteArrayIn.Length);
            return Image.FromStream(ms, true);
        }

        public static byte[] SystemDrawingToByteArray(System.Drawing.Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, img.RawFormat);
            return stream.ToArray();
        }
    }
}
