using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorXML.DLL
{
    public class NotaFiscal
    {
        public string Numero { get; set; }
        public string Serie { get; set; }
        public DateTime DataEmissao { get; set; }
        public string ChaveAcesso { get; set; }
        public string Emitente { get; set; }
        public string CNPJEmitente { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
