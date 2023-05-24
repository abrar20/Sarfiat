using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class IncomeEntity : IDataHelper<Income>
    {
        private DBContext db;
        private Income table;
        public IncomeEntity()
        {
                db = new DBContext();
        }
        #region Methods
        public int Add(Income table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.Income.Add(table);
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

        public async Task<int> AddAsync(Income table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.Income.AddAsync(table);
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
                    db.Income.Remove(table);
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
                    await Task.Run(()=> db.Income.Remove(table));
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

        public int Edit(Income table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    //we have to initilase the database or it will casue issues,just in edit
                    db = new DBContext();
                    db.Income.Update(table);
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

        public async Task<int> EditAsync(Income table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    // only in edit
                    db = new DBContext();
                    // there is no UpdateAsync, so we do like this Task.Run (() => )
                    await Task.Run(()=> db.Income.Update(table));
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

        public Income Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Income.Where(x => x.Id == Id).First();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Income> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Income.Where(x => x.Id == Id).First());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Income> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Income.ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Income>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Income.ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Income> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Income.Where(x => x.Id.ToString() == SearchItem
                    || x.CategoryName.Contains(SearchItem)
                    || x.CustomerName.Contains(SearchItem)
                    || x.RecNo.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Amount.ToString().Contains(SearchItem)
                    || x.IncomeDate.ToString().Contains(SearchItem)
                    ).ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Income>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Income.Where(x => x.Id.ToString() == SearchItem
                    || x.CategoryName.Contains(SearchItem)
                    || x.CustomerName.Contains(SearchItem)
                    || x.RecNo.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Amount.ToString().Contains(SearchItem)
                    || x.IncomeDate.ToString().Contains(SearchItem)
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
