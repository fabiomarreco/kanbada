using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Org.Mentalis.Utilities;
using System.Deployment.Application;
using System.Text.RegularExpressions;

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
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            
            string nomeArquivo = string.Empty;
            var actArgs = AppDomain.CurrentDomain.SetupInformation.ActivationArguments;
            if ((actArgs != null) && (actArgs.ActivationData != null) && (actArgs.ActivationData.Length > 0))
                nomeArquivo = actArgs.ActivationData[0];

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                if ((args.Length != 0) && (File.Exists(args[0])))
                    nomeArquivo = args[0];
                else
                {
                    nomeArquivo = PegaArquivoDefault();
                    if (args.Length > 0)
                        nomeArquivo = args[0];
                }
            }
            else
            {
                if (!File.Exists(nomeArquivo))
                {
                    nomeArquivo = Regex.Replace (nomeArquivo, "file:/+", "");
                    nomeArquivo = Uri.UnescapeDataString(nomeArquivo);
                    if (!File.Exists(nomeArquivo))
                        nomeArquivo = @"\\" + nomeArquivo;
                }
            }

            if (nomeArquivo.EndsWith(".application"))
            {
                MessageBox.Show("Aplicação Instalada com Sucesso");
                return;
            }

            if (!File.Exists(nomeArquivo))
            {
                MessageBox.Show("Arquivo nao encontrado: " + nomeArquivo);
                return;
            }

            Application.Run(new WMain(nomeArquivo));
        }
        /*
        public static string[] GetArguments()
        {
            if (ApplicationDeployment.IsNetworkDeployed &&
                ApplicationDeployment.CurrentDeployment.ActivationUri != null)
            {
                string query = HttpUtility.UrlDecode(
                    ApplicationDeployment.CurrentDeployment.ActivationUri.Query);
                if (!string.IsNullOrEmpty(query) && query.StartsWith("?"))
                {
                    string[] arguments = query.Substring(1).Split(' ');
                    string[] commandLineArgs = new string[arguments.Length + 1];
                    commandLineArgs[0] = Environment.GetCommandLineArgs()[0];
                    arguments.CopyTo(commandLineArgs, 1);
                    return commandLineArgs;
                }
            }
            return Environment.GetCommandLineArgs();
        }
        */
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var resultado = MessageBox.Show(string.Format("{0}\r\n\n REINICIAR?", e.ExceptionObject.ToString()), ((Exception)e.ExceptionObject).Message.ToString(), MessageBoxButtons.YesNo);
            switch (resultado)
            {
                case DialogResult.Yes: Application.Restart(); return;
                case DialogResult.No: Application.Exit(); return;
            }
        }


        public static string PegaArquivoDefault()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return Path.Combine(path, "sprint.xml");
        }


        /// <summary>
        ///  Verifica a instalacao do programa
        /// </summary>
        private static void VerificaInstalacao()
        {
            string asmName = Assembly.GetExecutingAssembly().Location;
            string location = Path.GetDirectoryName(asmName);

            Func<string, DirectoryInfo> criaDiretorio =
                new Func<string, DirectoryInfo>(s =>
                    (!Directory.Exists(Path.Combine(location, s))) ?
                        Directory.CreateDirectory(Path.Combine(location, s)) : null);


            criaDiretorio("History");
            criaDiretorio("Log");


            try
            {
                FileAssociation FA = new FileAssociation();
                FA.Extension = "kbd";
                FA.ContentType = "application/kanbadaboard";
                FA.FullName = "Quadro Kanban para Kanbada!";
                FA.ProperName = "Kanbada! board";

                FA.AddCommand("open", string.Format("\"{0}\" -view \"%1\"", asmName));
                FA.IconPath = Path.Combine(location, @"Resources\kanbada.ico");
                FA.Create();
                // Remove the file type from the registry
                //FA.Remove();
            }
            catch
            {
                // Se de erro nao precisa notificar usuario;
            }
        }
    }
}
