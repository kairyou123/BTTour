using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface ITourRepository : ICommonRepository<Tour>
    {
        IEnumerable<Tour> getWhere(string Ten, string LHDL, string ID, string MaTour, DateTime fromDate, DateTime toDate, int fromPrice, int toPrice, int isDeleted=0);
       Tour getByName(string Ten, int isDeleted = 0);
        IEnumerable<Tour> getAllDelete();
        Tour getById(int TourId, String MaTour = "");

    }
}
