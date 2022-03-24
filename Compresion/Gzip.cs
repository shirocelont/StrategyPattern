using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace Compresion
{
    internal class Gzip
    {
        public string archivo;
        public void setArchivo(string archivo)
        {
            this.archivo = archivo;
        }

        public void comprimir()
        {
            using (FileStream compressedFileStream = File.Create(archivo))
            using (var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress))
            compressedFileStream.CopyTo(compressor);
        }
    }
}
