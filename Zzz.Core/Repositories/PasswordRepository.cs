using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zzz.Core.Contracts.Repositories;
using Zzz.Core.Models;

namespace Zzz.Core.Repositories
{
    public class PasswordRepository : BaseRepository, IPasswordRepository
    {
        private static readonly List<Password> AllPasswords = new List<Password>
        {
            new Password
            {
                Id = 1,
                Name = "Outlook",
                Description = "Outlook password"
            },
            new Password
            {
                Id = 2,
                Name = "Bol.com",
                Description = "Bol.com password"
            }
        };

        public async Task<List<Password>> GetAllPasswords()
        {
            return await Task.FromResult(AllPasswords);
        }

        public async Task<Password> GetPasswordById(int passwordId)
        {
            return await Task.FromResult(AllPasswords.FirstOrDefault(c => c.Id == passwordId));
        }
    }
}
