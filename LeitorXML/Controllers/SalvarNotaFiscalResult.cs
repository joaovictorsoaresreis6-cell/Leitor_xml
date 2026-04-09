namespace LeitorXML.Controllers
{
    public class SalvarNotaFiscalResult
    {
        public bool Sucesso { get; }
        public string Mensagem { get; }

        private SalvarNotaFiscalResult(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public static SalvarNotaFiscalResult Ok(string mensagem)
        {
            return new SalvarNotaFiscalResult(true, mensagem);
        }

        public static SalvarNotaFiscalResult Fail(string mensagem)
        {
            return new SalvarNotaFiscalResult(false, mensagem);
        }
    }
}
