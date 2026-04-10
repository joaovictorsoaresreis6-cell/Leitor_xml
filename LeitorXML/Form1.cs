using System;
using System.Windows.Forms;
using System.Xml.Linq;
using LeitorXML.Controllers;
// using LeitorXML.Models;
using LeitorXML.Repositories;
using LeitorXML.DLL;
using NotaFiscalDTO = LeitorXML.DLL.NotaFiscal;

namespace LeitorXML
{

    public partial class Form1 : Form
    {
        private string? caminhoXML;
        private readonly NotaFiscalController _notaFiscalController;

        public Form1()
        {
            InitializeComponent();
            _notaFiscalController = new NotaFiscalController(new NotaFiscalRepository());
        }

        private void btnSelecionarXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione um arquivo no formato .XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
                caminhoXML = openFileDialog.FileName;
                MessageBox.Show("Você selecionou esse arquivo: " + caminhoArquivo);
            }
        }
        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblSerie_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnLerXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoXML))
            {
                MessageBox.Show("Selecione um XML primeiro!");
                return;
            }

            NotaFiscalService service = new NotaFiscalService();
            NotaFiscalDTO nota = service.LerXml(caminhoXML);

            txtNumero.Text = nota.Numero;
            txtSerie.Text = nota.Serie;
            txtData.Text = nota.DataEmissao.ToString();
            txtValor.Text = nota.ValorTotal.ToString();
            txtEmitente.Text = nota.Emitente;
            txtCNPJ.Text = nota.CNPJEmitente;
            txtChave.Text = nota.ChaveAcesso;
        }

        private void openFileDialogXML_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnSalvarBanco_Click(object sender, EventArgs e)
        {
            var notaModel = new LeitorXML.Models.NotaFiscal
            {
                Numero = txtNumero.Text.Trim(),
                Serie = txtSerie.Text.Trim(),
                DataEmissao = txtData.Text,
                ValorTotal = txtValor.Text,
                Emitente = txtEmitente.Text.Trim(),
                CnpjEmitente = txtCNPJ.Text.Trim(),
                ChaveAcesso = txtChave.Text.Trim()
            };

            var repository = new LeitorXML.Repositories.NotaFiscalRepository();
            var controller = new LeitorXML.Controllers.NotaFiscalController(repository);

            var resultado = controller.Salvar(notaModel);

            MessageBox.Show(resultado.Mensagem);
        }

        private void btnValidarXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoXML))
            {
                MessageBox.Show("Selecione um XML primeiro!");
                return;
            }

            NotaFiscalService service = new NotaFiscalService();

            bool valido = service.ValidarXml(caminhoXML);

            MessageBox.Show(valido ? "\n XML válido! \n" : "XML inválido! \nVerifique se todos os campos estão preenchidos !\n");
        }
    }
}
