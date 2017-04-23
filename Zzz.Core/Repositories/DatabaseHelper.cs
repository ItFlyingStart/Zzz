using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using Zzz.Core.Models.Orm;

namespace Zzz.Core.Repositories
{
    public class DatabaseHelper
    {
        Realm realm;

        public DatabaseHelper()
        {
            realm = Realm.GetInstance();
        }

        #region Password
        public List<PasswordOrm> GetAllPasswords()
        {
            List<PasswordOrm> allPasswords = new List<PasswordOrm>(realm.All<PasswordOrm>());
            return allPasswords;
        }

        public PasswordOrm GetPassword(string id)
        {
            PasswordOrm password = (PasswordOrm)realm.All<PasswordOrm>().Where(p => p.Id == id);
            return password;
        }

        public void UpdatePassword(PasswordOrm password)
        {
            realm.Write(() =>
            {
                realm.Add(password);
            });
        }
        #endregion

        #region Password
        public List<GroupOrm> GetAllGroups()
        {
            List<GroupOrm> allGroups = new List<GroupOrm>(realm.All<GroupOrm>());
            return allGroups;
        }

        public GroupOrm GetGroup(string id)
        {
            GroupOrm group = (GroupOrm)realm.All<GroupOrm>().Where(p => p.Id == id);
            return group;
        }

        public void UpdateGroup(GroupOrm group)
        {
            realm.Write(() =>
            {
                realm.Add(group);
            });
        }
        #endregion

        public void GenerateFakeData()
        {
            GroupOrm groupEmail;
            GroupOrm groupWebShop;
            if (GetAllGroups().Count < 1)
            {
                groupEmail = realm.Add(new GroupOrm { Name = "Email", Description = "All email passwords", IconId = 1 });
                groupWebShop = realm.Add(new GroupOrm { Name = "Web Shop", Description = "All web shop passwords", IconId = 2 });
            }
            else
            {
                groupEmail = (GroupOrm)realm.All<GroupOrm>().Where(p => p.Name == "Email");
                groupWebShop = (GroupOrm)realm.All<GroupOrm>().Where(p => p.Name == "Web Shop");
            }

            if (GetAllPasswords().Count < 1)
            {
                var outlookPassword = realm.Add(new PasswordOrm { Name = "Outlook.com", Description = "Outlook.com password", PasswordGroup = groupEmail });
                var workEmailPassword = realm.Add(new PasswordOrm { Name = "Zzz email", Description = "Zzz email password", PasswordGroup = groupEmail });
                var bolDotComPassword = realm.Add(new PasswordOrm { Name = "Bol.com", Description = "Bol.com password", PasswordGroup = groupWebShop });
            }
        }
    }
}
