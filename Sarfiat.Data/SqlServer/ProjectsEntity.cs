using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class ProjectsEntity : IDataHelper<Projects>
    {
        private DBContext db;
        private Projects table;
        public ProjectsEntity()
        {
                db = new DBContext();
        }
        #region Methods
        public int Add(Projects table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.Projects.Add(table);
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

        public async Task<int> AddAsync(Projects table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.Projects.AddAsync(table);
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
                    db.Projects.Remove(table);
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
                    await Task.Run(()=> db.Projects.Remove(table));
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

        public int Edit(Projects table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    //we have to initilase the database or it will casue issues,just in edit
                    db = new DBContext();
                    db.Projects.Update(table);
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

        public async Task<int> EditAsync(Projects table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    // only in edit
                    db = new DBContext();
                    // there is no UpdateAsync, so we do like this Task.Run (() => )
                    await Task.Run(()=> db.Projects.Update(table));
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

        public Projects Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Projects.Where(x => x.Id == Id).First();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Projects> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Projects.Where(x => x.Id == Id).First());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Projects> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Projects.ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Projects>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Projects.ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Projects> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Projects.Where(x => x.Id.ToString() == SearchItem
                    || x.Name.Contains(SearchItem)
                    || x.Company.Contains(SearchItem)
                    || x.Customer.Contains(SearchItem)
                    || x.Address.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Income.ToString().Contains(SearchItem)
                    || x.Outcome.ToString().Contains(SearchItem)
                    || x.Revenue.ToString().Contains(SearchItem)
                    || x.StartDate.ToString().Contains(SearchItem)
                    || x.EndDate.ToString().Contains(SearchItem)
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

        public async Task<List<Projects>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Projects.Where(x => x.Id.ToString() == SearchItem
                    || x.Name.Contains(SearchItem)
                    || x.Company.Contains(SearchItem)
                    || x.Customer.Contains(SearchItem)
                    || x.Address.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Income.ToString().Contains(SearchItem)
                    || x.Outcome.ToString().Contains(SearchItem)
                    || x.Revenue.ToString().Contains(SearchItem)
                    || x.StartDate.ToString().Contains(SearchItem)
                    || x.EndDate.ToString().Contains(SearchItem)
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
