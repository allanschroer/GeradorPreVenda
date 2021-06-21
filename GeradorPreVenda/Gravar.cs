using System.IO;
using System;
using System.Threading.Tasks;

namespace GeradorPreVenda
{
    class gravar
    {

        public void GravarComAnotacao(string prevenda, string anotacao)
        {
            string texto = prevenda + " - " + anotacao + Environment.NewLine;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(Path.Combine(docPath, "Prevendas Com Descrição.txt"), texto);
            string[] linhas = { texto };
            File.AppendAllLines(Path.Combine("Prevendas.txt"), linhas);
        }

        public void GravarVariasPreVendas(string prevendas)
        {
            string texto = prevendas + Environment.NewLine;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(Path.Combine(docPath, "PrevendasAleatorias.txt"), texto);
            string[] linhas = { texto };
            File.AppendAllLines(Path.Combine("PrevendasAleatorias.txt"), linhas);
        }
    }
}

