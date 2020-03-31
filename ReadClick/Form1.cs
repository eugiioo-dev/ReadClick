using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadClick
{
    public partial class ReadClick : Form
    {
        Int32 Contador;
        Int32 Total;

        public ReadClick()
        {
            InitializeComponent();
        }

        private void BtnAbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Arquivos = new OpenFileDialog
            {
                Title = "Selecionar Arquivo",
                InitialDirectory = "c:\\",
                Filter = "Arquivo de Texto (*.txt)|*.txt",
                RestoreDirectory = true
            };

            DialogResult Retorno = Arquivos.ShowDialog();

            if(Retorno.ToString() == "OK")
            {
                CaminhoArquivo.Text = Arquivos.FileName;
                CaixaDeTexto.Text = System.IO.File.ReadAllText(Arquivos.FileName);
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            CaminhoArquivo.Text = null;
            IntervaloEscrita.Text = "10";
            InvervaloParaIniciar.Text = "10";
            CaixaDeTexto.Text = null;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (BtnAbrirArquivo.Text == "Parar")
            {
                BtnAbrirArquivo.Text = "Iniciar";
                TimerParaEscreverTexto.Enabled = false;
            }
            else
            {
                Int32 InvervaloParaComecar = Convert.ToInt32(InvervaloParaIniciar.Text);
                BtnAbrirArquivo.Text = "Parar";
                TimerParaEscreverTexto.Interval = Convert.ToInt32((InvervaloParaComecar * 1000));
                TimerParaEscreverTexto.Enabled = true;
            }
        }

        private void TimerParaEscreverTexto_Tick(object sender, EventArgs e)
        {
            Int32 IntervaloParaEscrever = Convert.ToInt32(IntervaloEscrita.Text);
            TimerParaEscrever.Interval = ((IntervaloParaEscrever * 1000));
            TimerParaEscrever.Enabled = true;
        }

        private void TimerParaEscrever_Tick(object sender, EventArgs e)
        {
            String[] Linhas = System.IO.File.ReadAllLines(CaminhoArquivo.Text);
            Total = Linhas.Count();

            OnMouseClick(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            //WriteLine();
            SendKeys.Send("{SHIFT}");
            SendKeys.Send("{ENTER}");
        }
    }
}
