using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourApp.Const;
using TourApp.Context;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp.Repository
{
    public class DoanKhachRepository : IDoanKhachRepository
    {
        private TourContext _context;

        public DoanKhachRepository(TourContext context)
        {
            _context = context;
        }

        public void Add(DoanKhach entity)
        {
            _context.DoanKhachs.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(DoanKhach entity)
        {
            entity.isDeleted = Status.Deleted;
            _context.DoanKhachs.Update(entity);
            _context.SaveChanges();
        }

        public IEnumerable<DoanKhach> getAll()
        {
            return _context.DoanKhachs.Where(dk => dk.isDeleted == Status.NotDeleted).Include(i => i.Tour).Include(i => i.CTDoans).ThenInclude(i=>i.HanhKhach)
                                                               .Include(i => i.NV_VTs).ThenInclude(i => i.NhanVien)
                                                               .Include(i => i.CTChitieus).ThenInclude(i => i.ChiTieu)
                                                               .ToList();
        }

        public IEnumerable<DoanKhach> getAllDelete()
        {
            return _context.DoanKhachs.Where(dk => dk.isDeleted == Status.Deleted).Include(i => i.Tour).ToList();
        }

        public IEnumerable<DoanKhach> getWhere(string name, int isDeleted, string nameTour)
        {
            return _context.DoanKhachs.Where(dk => dk.isDeleted == isDeleted && dk.TenDoan.Contains(name) && dk.Tour.Ten.Contains(nameTour))
                                                               .Include(i => i.Tour) .Include(i => i.CTDoans).ThenInclude(i => i.HanhKhach)
                                                               .Include(i => i.NV_VTs).ThenInclude(i=>i.NhanVien)
                                                               .Include(i => i.CTChitieus).ThenInclude(i => i.ChiTieu)
                                                               .ToList();
        }

        public DoanKhach getById(int id, string maDK = "")
        {
            return _context.DoanKhachs.Where(dk => dk.DoanId == id || dk.MaDoan == maDK)
                                                              .Include(i => i.Tour).Include(i => i.Tour).Include(i => i.CTDoans).ThenInclude(i => i.HanhKhach)
                                                              .Include(i => i.NV_VTs).ThenInclude(i => i.NhanVien)
                                                              .Include(i => i.CTChitieus).ThenInclude(i => i.ChiTieu)
                                                              .FirstOrDefault();
        }


        public void Update(DoanKhach entity)
        {
            _context.DoanKhachs.Update(entity);
            _context.SaveChanges();
        }
    }
}
