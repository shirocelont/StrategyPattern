using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Windows.Forms;
using System.IO;
namespace Compresion
{
    internal class Deflate
    {
        public string archivo;
        public void setArchivo(string archivo)
        {
            this.archivo = archivo;
        }
        public void comprimir()
        {
            string nuevoDeflate = archivo;
            try
            {
                using (FileStream archive = File.Open(nuevoDeflate, FileMode.Create))
                using (FileStream compressedFileStream = File.Create(archivo))
                using (var compressor = new DeflateStream(compressedFileStream, CompressionMode.Compress))
                    archive.CopyTo(compressor);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

    }
}

