using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class UsersRolesEntity : IDataHelper<UsersRoles>
    {
        private DBContext db;
        private UsersRoles table;
        public UsersRolesEntity()
        {
                db = new DBContext();
        }
        #region Methods
        public int Add(UsersRoles table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.UsersRoles.Add(table);
                    db.SaveChanges();
                    return 1;
                }
                else { return 0; }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> AddAsync(UsersRoles table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.UsersRoles.AddAsync(table);
                    await db.SaveChangesAsync();
                    return 1;
                }
                else { return 0; }
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    table = Find(Id);
                    db.UsersRoles.Remove(table);
                    db.SaveChanges();
                    return 1;
                }
                else { return 0; }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    table = await FindAsync(Id);
                    // there is no RemoveAsync ,so we did like this instead
                    await Task.Run(()=> db.UsersRoles.Remove(table));
                    await db.SaveChangesAsync();
                    return 1;
                }
                else { return 0; }
            }
            catch
            {
                return 0;
            }
        }

        public int Edit(UsersRoles table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    //we have to initilase the database or it will casue issues,just in edit
                    db = new DBContext();
                    db.UsersRoles.Update(table);
                    db.SaveChanges();
                    return 1;
                }
                else { return 0; }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> EditAsync(UsersRoles table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    // only in edit
                    db = new DBContext();
                    // there is no UpdateAsync, so we do like this Task.Run (() => )
                    await Task.Run(()=> db.UsersRoles.Update(table));
                    await db.SaveChangesAsync();
                    return 1;
                }
                else { return 0; }
            }
            catch
            {
                return 0;
            }
        }

        public UsersRoles Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.UsersRoles.Where(x => x.Id == Id).First();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<UsersRoles> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.UsersRoles.Where(x => x.Id == Id).First());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<UsersRoles> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.UsersRoles.ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UsersRoles>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.UsersRoles.ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<UsersRoles> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.UsersRoles.Where(x => x.Id.ToString() == SearchItem
                    || x.Key.Contains(SearchItem)
                    || x.Value.ToString().Contains(SearchItem)
                    ).ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UsersRoles>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.UsersRoles.Where(x => x.Id.ToString() == SearchItem
                    || x.Key.Contains(SearchItem)
                    || x.Value.ToString().Contains(SearchItem)
                    ).ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }
        #endregion

    }
}
