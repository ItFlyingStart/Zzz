using System.Collections.Generic;
using System.Threading.Tasks;
using Zzz.Core.Models;

namespace Zzz.Core.Contracts.Repositories
{
    public interface IPasswordRepository
    {
        Task<List<Password>> GetAllPasswords();

        Task<Password> GetPasswordById(int passwordId);
    }
}
