using System;
using System.Windows.Forms;

namespace LeitorXML.Data
{
    public static class DatabaseBootstrapper
    {
        public static void Initialize()
        {
            try
            {
                using var dbContext = new AppDbContext();
                dbContext.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falha ao inicializar conexão com SQL Server. Verifique a connection string em LEITORXML_SQLSERVER_CONNECTION.\n\nDetalhe: " + ex.Message,
                    "Erro de Banco de Dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
