using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace kanbada
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string nomeArquivo = PegaArquivoDefault();
            if (args.Length > 0)
                nomeArquivo = args[0];

            Application.Run(new WMain(nomeArquivo));
        }


        public static string PegaArquivoDefault()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return Path.Combine(path, "sprint.xml");
        }
    }
}
