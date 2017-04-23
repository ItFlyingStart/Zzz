using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zzz.Core.Contracts.Repositories;
using Zzz.Core.Models;
using Zzz.Core.Models.Orm;
using Realms;
using ExpressMapper;
using ExpressMapper.Extensions;

namespace Zzz.Core.Repositories
{
    public class PasswordRepository : BaseRepository, IPasswordRepository
    {
        DatabaseHelper dbHelper;

        public PasswordRepository()
        {
            dbHelper = new DatabaseHelper();

            // TO BE REMOVED.
            dbHelper.GenerateFakeData();
        }

        public async Task<List<Password>> GetAllPasswords()
        {
            List<PasswordOrm> allPasswordOrms = dbHelper.GetAllPasswords();
            List<Password> result = allPasswordOrms.Map<List<PasswordOrm>, List<Password>>();

            return await Task.FromResult(result);
        }

        public async Task<Password> GetPasswordById(string passwordId)
        {
            PasswordOrm passwordOrm = dbHelper.GetPassword(passwordId);
            Password result = passwordOrm.Map<PasswordOrm, Password>();

            return await Task.FromResult(result);
        }
    }
}
