using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IHanhKhachRepository : ICommonRepository<HanhKhach>
    {
        IEnumerable<HanhKhach> getWhere(String Ten, int isDeleted = 0);
        IEnumerable<HanhKhach> getAllDelete();

        HanhKhach getById(int id, string maHK = "");

    }
}
