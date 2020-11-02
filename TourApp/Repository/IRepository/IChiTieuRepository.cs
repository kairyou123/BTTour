using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IChiTieuRepository : ICommonRepository<ChiTieu>
    {
        IEnumerable<ChiTieu> getWhere(string ID,string Ten);

        ChiTieu getByName(String Ten);
        ChiTieu getById(int CTId);

    }
}
