using System.Collections.Generic;
using System.Threading.Tasks;
using Zzz.Core.Models;

namespace Zzz.Core.Contracts.Services
{
    public interface IPasswordDataService
    {
        Task<List<Password>> GetAllPasswords();

        Task<Password> GetPasswordById(string passwordId);
    }
}
