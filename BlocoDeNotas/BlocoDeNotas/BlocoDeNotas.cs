using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocoDeNotas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //Função do botão de salvar do bloco de notas
        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        //Função que acessa o arquivo que o usuário salvou e introduz o texto do bloco de notas neste arquivo.
        private void SalvarOk(object sender, CancelEventArgs e)
        {

            string caminhoArquivo = saveFileDialog1.FileName;
            File.WriteAllText(caminhoArquivo, txb_Entrada.Text);
            txb_Entrada.Clear();

        }
    }
}
