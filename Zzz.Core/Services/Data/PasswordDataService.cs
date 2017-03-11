using System.Collections.Generic;
using System.Threading.Tasks;
using Zzz.Core.Contracts.Repositories;
using Zzz.Core.Contracts.Services;
using Zzz.Core.Models;

namespace Zzz.Core.Services.Data
{
    public class PasswordDataService : IPasswordDataService
    {
        private readonly IPasswordRepository _passwordRepository;
        public PasswordDataService(IPasswordRepository passwordRepository)
        {
            _passwordRepository = passwordRepository;
        }

        public virtual async Task<List<Password>> GetAllPasswords()
        {
            return await _passwordRepository.GetAllPasswords();
        }

        public async Task<Password> GetPasswordById(int passwordId)
        {
            return await _passwordRepository.GetPasswordById(passwordId);
        }
    }
}
