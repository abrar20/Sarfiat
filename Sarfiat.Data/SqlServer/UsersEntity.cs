using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class UsersEntity : IDataHelper<Users>
    {
        private DBContext db;
        private Users table;
        public UsersEntity()
        {
                db = new DBContext();
        }
        #region Methods
        public int Add(Users table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.Users.Add(table);
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

        public async Task<int> AddAsync(Users table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.Users.AddAsync(table);
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
                    db.Users.Remove(table);
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
                    await Task.Run(()=> db.Users.Remove(table));
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

        public int Edit(Users table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    //we have to initilase the database or it will casue issues,just in edit
                    db = new DBContext();
                    db.Users.Update(table);
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

        public async Task<int> EditAsync(Users table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    // only in edit
                    db = new DBContext();
                    // there is no UpdateAsync, so we do like this Task.Run (() => )
                    await Task.Run(()=> db.Users.Update(table));
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

        public Users Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Users.Where(x => x.Id == Id).First();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Users> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Users.Where(x => x.Id == Id).First());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Users> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Users.ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Users>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Users.ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Users> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Users.Where(x => x.Id.ToString() == SearchItem
                    || x.FullName.Contains(SearchItem)
                    || x.UserName.Contains(SearchItem)
                    || x.Phone.Contains(SearchItem)
                    || x.Email.Contains(SearchItem)
                    || x.AddedDate.Date.ToString().Contains(SearchItem)
                    ).ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Users>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Users.Where(x => x.Id.ToString() == SearchItem
                    || x.FullName.Contains(SearchItem)
                    || x.UserName.Contains(SearchItem)
                    || x.Phone.Contains(SearchItem)
                    || x.Email.Contains(SearchItem)
                    || x.AddedDate.Date.ToString().Contains(SearchItem)
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
