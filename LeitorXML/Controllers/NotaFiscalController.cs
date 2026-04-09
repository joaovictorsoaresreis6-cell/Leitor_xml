using LeitorXML.Models;
using LeitorXML.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LeitorXML.Controllers
{
    public class NotaFiscalController
    {
        private readonly NotaFiscalRepository _repository;

        public NotaFiscalController(NotaFiscalRepository repository)
        {
            _repository = repository;
        }

        public SalvarNotaFiscalResult Salvar(NotaFiscal notaFiscal)
        {
            if (string.IsNullOrWhiteSpace(notaFiscal.ChaveAcesso))
            {
                return SalvarNotaFiscalResult.Fail("Leia um XML válido antes de salvar no banco.");
            }

            if (_repository.ExistsByChaveAcesso(notaFiscal.ChaveAcesso))
            {
                return SalvarNotaFiscalResult.Fail("Essa nota fiscal já foi salva no banco.");
            }

            try
            {
                _repository.Add(notaFiscal);
                return SalvarNotaFiscalResult.Ok("Nota fiscal salva com sucesso no SQL Server.");
            }
            catch (DbUpdateException ex) when (IsDuplicateKeyException(ex))
            {
                return SalvarNotaFiscalResult.Fail("Essa nota fiscal já existe no banco (chave de acesso duplicada).");
            }
            catch (Exception ex)
            {
                return SalvarNotaFiscalResult.Fail("Erro ao salvar no banco: " + ex.Message);
            }
        }

        private static bool IsDuplicateKeyException(DbUpdateException ex)
        {
            if (ex.InnerException is SqlException sqlEx)
            {
                return sqlEx.Number == 2601 || sqlEx.Number == 2627;
            }

            return false;
        }
    }
}
