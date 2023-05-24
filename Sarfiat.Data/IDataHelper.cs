using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data
{
    public interface IDataHelper<Table>
    {
        //Read
        /// <summary>Gets all data.</summary>
        /// <returns>list of all data</returns>
        List<Table> GetAllData();
        /// <summary>Searches the specified search item.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>list of searched items</returns>
        List<Table> Search(string SearchItem);
        /// <summary>Finds the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>if success return item == Id, failed return 0</returns>
        Table Find(int Id);
        //write
        /// <summary>Adds the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 if success and 0 if failed</returns>
        int Add(Table table);
        int Edit(Table table);
        int Delete(int Id);

        //ReadAsync
        Task<List<Table>> GetAllDataAsync();
        Task<List<Table>> SearchAsync(string SearchItem);
        Task<Table> FindAsync(int Id);
        //writeAsync
        Task<int> AddAsync(Table table);
        Task<int> EditAsync(Table table);
        Task<int> DeleteAsync(int Id);
    }
}
