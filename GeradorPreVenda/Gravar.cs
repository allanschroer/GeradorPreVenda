using System.IO;
using System;
using System.Threading.Tasks;

namespace GeradorPreVenda
{
    class gravar
    {

        public void Gravar(string prevenda, string anotacao)
        {
            string texto = prevenda + " - " + anotacao + Environment.NewLine;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(Path.Combine(docPath, "Prevendas.txt"), texto);
            string[] linhas = { texto };
            File.AppendAllLines(Path.Combine("Prevendas.txt"), linhas);
        }
    }
}

