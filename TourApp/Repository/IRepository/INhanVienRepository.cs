using System;
using System.Collections.Generic;
using System.Text;
using TourApp.Const;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface INhanVienRepository : ICommonRepository<NhanVien>
    {
        IEnumerable<NhanVien> getWhere(String Ten, int isDeleted = Status.NotDeleted );
        IEnumerable<NhanVien> getAllDelete();
        NhanVien getById(int NVId, String MaNV = "");

    }
}
