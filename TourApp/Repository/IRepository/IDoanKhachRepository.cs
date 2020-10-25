using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IDoanKhachRepository : ICommonRepository<DoanKhach>
    {
        IEnumerable<DoanKhach> getWhere(string Ten, int isDeleted = 0, string tenTour = "");
        IEnumerable<DoanKhach> getAllDelete();

        DoanKhach getById(int id, string maHK = "");

    }
}
