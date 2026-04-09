using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LeitorXML.DLL
{
    public class NotaFiscalService
    {
        public NotaFiscal LerXml(string caminhoArquivo)
        {
            XDocument xml = XDocument.Load(caminhoArquivo);

            string? numero = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "nNF")?.Value;
            string? serie = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "serie")?.Value;
            string? data = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "dhEmi")?.Value;
            string? valor = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "vNF")?.Value;
            string? emitente = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "xNome")?.Value;
            string? cnpj = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "CNPJ")?.Value;

            var infNFe = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "infNFe");
            string? chave = infNFe?.Attribute("Id")?.Value?.Replace("NFe", "");

            NotaFiscal nota = new NotaFiscal
            {
                Numero = numero ?? "",
                Serie = serie ?? "",
                Emitente = emitente ?? "",
                CNPJEmitente = cnpj ?? "",
                ChaveAcesso = chave ?? "",
                ValorTotal = decimal.TryParse(valor, out var v) ? v : 0,
                DataEmissao = DateTime.TryParse(data, out var d) ? d : DateTime.MinValue
            };

            return nota;
        }
        public bool ValidarXml(string caminhoArquivo)
        {
            try
            {
                XDocument xml = XDocument.Load(caminhoArquivo);

                var numero = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "nNF");
                var emitente = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "xNome");
                var valor = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "vNF");

                if (numero == null || emitente == null || valor == null)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
        public string SalvarNoBanco(NotaFiscal nota)
        {
            try
            {
                var repository = new LeitorXML.Repositories.NotaFiscalRepository();
                var controller = new LeitorXML.Controllers.NotaFiscalController(repository);

                var notaModel = new LeitorXML.Models.NotaFiscal
                {
                    Numero = nota.Numero,
                    Serie = nota.Serie,
                    DataEmissao = nota.DataEmissao.ToString(),
                    ValorTotal = nota.ValorTotal.ToString(),
                    Emitente = nota.Emitente,
                    CnpjEmitente = nota.CNPJEmitente,
                    ChaveAcesso = nota.ChaveAcesso
                };

                var resultado = controller.Salvar(notaModel);

                return resultado.Mensagem;
            }
            catch (Exception ex)
            {
                return "Erro ao salvar: " + ex.Message;
            }
        }
    }
}
