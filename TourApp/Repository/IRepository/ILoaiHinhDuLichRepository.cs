using System;
using System.Collections.Generic;
using System.Text;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface ILoaiHinhDuLichRepository : ICommonRepository<LoaiHinhDL>
    {
        IEnumerable<LoaiHinhDL> getWhere(string ID, string Ten, string Mota);
        LoaiHinhDL getById(int lhdlId);
    }
}
