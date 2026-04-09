namespace LeitorXML.Models
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public string Serie { get; set; } = string.Empty;
        public string DataEmissao { get; set; } = string.Empty;
        public string ValorTotal { get; set; } = string.Empty;
        public string Emitente { get; set; } = string.Empty;
        public string CnpjEmitente { get; set; } = string.Empty;
        public string ChaveAcesso { get; set; } = string.Empty;
    }
}
