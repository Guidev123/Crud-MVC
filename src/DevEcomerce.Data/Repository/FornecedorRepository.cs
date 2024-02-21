using DevEcomerce.Business.Interfaces;
using DevEcomerce.Business.Models;
using DevEcomerce.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevEcomerce.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(EcomerceDbContext context) : base(context)
        {

        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking().Include(c => c.Endereco).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()

                .Include(c => c.Produtos)
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c=>c.Id == id);
        }
    }
}
