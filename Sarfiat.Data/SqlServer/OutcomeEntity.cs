using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class OutcomeEntity : IDataHelper<Outcome>
    {
        private DBContext db;
        private Outcome table;
        public OutcomeEntity()
        {
                db = new DBContext();
        }
        #region Methods
        public int Add(Outcome table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.Outcome.Add(table);
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

        public async Task<int> AddAsync(Outcome table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.Outcome.AddAsync(table);
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
                    db.Outcome.Remove(table);
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
                    await Task.Run(()=> db.Outcome.Remove(table));
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

        public int Edit(Outcome table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    //we have to initilase the database or it will casue issues,just in edit
                    db = new DBContext();
                    db.Outcome.Update(table);
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

        public async Task<int> EditAsync(Outcome table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    // only in edit
                    db = new DBContext();
                    // there is no UpdateAsync, so we do like this Task.Run (() => )
                    await Task.Run(()=> db.Outcome.Update(table));
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

        public Outcome Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Outcome.Where(x => x.Id == Id).First();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Outcome> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Outcome.Where(x => x.Id == Id).First());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Outcome> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Outcome.ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Outcome>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Outcome.ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<Outcome> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Outcome.Where(x => x.Id.ToString() == SearchItem
                    || x.CategoryName.Contains(SearchItem)
                    || x.SupplierName.Contains(SearchItem)
                    || x.RecNo.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Amount.ToString().Contains(SearchItem)
                    || x.OutcomeDate.ToString().Contains(SearchItem)
                    ).ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Outcome>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Outcome.Where(x => x.Id.ToString() == SearchItem
                    || x.CategoryName.Contains(SearchItem)
                    || x.SupplierName.Contains(SearchItem)
                    || x.RecNo.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Amount.ToString().Contains(SearchItem)
                    || x.OutcomeDate.ToString().Contains(SearchItem)
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
