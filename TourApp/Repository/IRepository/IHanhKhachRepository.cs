using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IHanhKhachRepository : ICommonRepository<HanhKhach>
    {
        IEnumerable<HanhKhach> getWhere(string ID, string MaHK, string Ten, string SDT, string Email, string CMND, string Diachi, string Gioitinh, string Passport, int isDeleted);
        IEnumerable<HanhKhach> getAllDelete();

        HanhKhach getById(int id, string maHK = "");

    }
}
