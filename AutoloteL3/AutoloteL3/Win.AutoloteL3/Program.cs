using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.AutoloteL3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
        public static byte[] imagenToByteArray(Image ImagenIn)
        {
            var ms = new MemoryStream();
            ImagenIn.Save(ms, ImagenIn.RawFormat);

            return ms.ToArray();
        }
       
    }
}
