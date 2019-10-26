using System.IO;

namespace NetConf.UsingStatement
{
    public class UsingStatement
    {
        const string original = ".\\NetConf\\UsingStatement\\file.txt";
        const string copia = ".\\NetConf\\UsingStatement\\fileCopy.txt";

        //Antes
        public static void Demo() {
            using (var streamReader1 = new StreamReader(original))
            {
                using (var streamWriter = new StreamWriter(copia))
                {
                    streamWriter.Write(streamReader1.ReadToEnd());
                }                
            }
        }

        //Agora
        /* public static void Demo() {
            using var streamReader1 = new StreamReader(original);
            using var streamWriter = new StreamWriter(copia);
            streamWriter.Write(streamReader1.ReadToEnd());
        } */
    }
}