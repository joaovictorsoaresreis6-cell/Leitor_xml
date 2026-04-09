using LeitorXML.Data;
using LeitorXML.Models;

namespace LeitorXML.Repositories
{
    public class NotaFiscalRepository
    {
        public bool ExistsByChaveAcesso(string chaveAcesso)
        {
            using var dbContext = new AppDbContext();
            return dbContext.NotasFiscais.Any(n => n.ChaveAcesso == chaveAcesso);
        }

        public void Add(NotaFiscal notaFiscal)
        {
            using var dbContext = new AppDbContext();
            dbContext.NotasFiscais.Add(notaFiscal);
            dbContext.SaveChanges();
        }
    }
}
