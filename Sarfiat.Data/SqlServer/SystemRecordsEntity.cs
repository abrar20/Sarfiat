﻿using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class SystemRecordsEntity : IDataHelper<SystemRecords>
    {
        private DBContext db;
        private SystemRecords table;
        public SystemRecordsEntity()
        {
                db = new DBContext();
        }
        #region Methods
        public int Add(SystemRecords table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.SystemRecords.Add(table);
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

        public async Task<int> AddAsync(SystemRecords table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.SystemRecords.AddAsync(table);
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
                    db.SystemRecords.Remove(table);
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
                    await Task.Run(()=> db.SystemRecords.Remove(table));
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

        public int Edit(SystemRecords table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    //we have to initilase the database or it will casue issues,just in edit
                    db = new DBContext();
                    db.SystemRecords.Update(table);
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

        public async Task<int> EditAsync(SystemRecords table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    // only in edit
                    db = new DBContext();
                    // there is no UpdateAsync, so we do like this Task.Run (() => )
                    await Task.Run(()=> db.SystemRecords.Update(table));
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

        public SystemRecords Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.SystemRecords.Where(x => x.Id == Id).First();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<SystemRecords> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.SystemRecords.Where(x => x.Id == Id).First());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<SystemRecords> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.SystemRecords.ToList();
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<SystemRecords>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.SystemRecords.ToList());
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        public List<SystemRecords> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.SystemRecords.Where(x => x.Id.ToString() == SearchItem
                    || x.UserName.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Title.ToString().Contains(SearchItem)
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

        public async Task<List<SystemRecords>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.SystemRecords.Where(x => x.Id.ToString() == SearchItem
                    || x.UserName.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Title.ToString().Contains(SearchItem)
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
