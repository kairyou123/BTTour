using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IDoanKhachRepository : ICommonRepository<DoanKhach>
    {
        IEnumerable<DoanKhach> getWhere(string ID, string MaDoan, string TenDoan, string Chitiet, string Tinhtrang, string TourID, string MaTour, int isDeleted, string nameTour = "");
        IEnumerable<DoanKhach> getAllDelete();

        DoanKhach getById(int id, string maHK = "");

    }
}
