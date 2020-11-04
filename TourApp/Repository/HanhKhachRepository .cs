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
    public class HanhKhachRepository : IHanhKhachRepository
    {
        private TourContext _context;

        public HanhKhachRepository(TourContext context)
        {
            _context = context;
        }

        public void Add(HanhKhach entity)
        {
            _context.HanhKhachs.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(HanhKhach entity)
        {
            entity.isDeleted = Status.Deleted;
            _context.HanhKhachs.Update(entity);
            _context.SaveChanges();
        }

        public IEnumerable<HanhKhach> getAll()
        {
            return _context.HanhKhachs.Where(hk => hk.isDeleted == Status.NotDeleted).ToList();
        }

        public IEnumerable<HanhKhach> getAllDelete()
        {
            return _context.HanhKhachs.Where(hk => hk.isDeleted == Status.Deleted).ToList();
        }

        public IEnumerable<HanhKhach> getWhere(string ID, string MaHK, string Ten,string SDT, string Email, string CMND, string Diachi,string Gioitinh, string Passport, int isDeleted)
        {
            return _context.HanhKhachs.Where(hk => hk.isDeleted == isDeleted
                                                && hk.KhachId.ToString().Contains(ID)
                                                && hk.MaKhach.Contains(MaHK)
                                                && hk.Ten.Contains(Ten)
                                                && hk.SDT.Contains(SDT)
                                                && hk.Email.Contains(Email)
                                                && hk.CMND.Contains(CMND)
                                                && hk.DiaChi.Contains(Diachi)
                                                && hk.GioiTinh.Contains(Gioitinh)
                                                && hk.Passport.Contains(Passport)

                                             )
                                      .ToList();
        }

        public HanhKhach getById(int id, string maHK = "")
        {
            return _context.HanhKhachs.Where(hk => hk.KhachId == id || hk.MaKhach == maHK).FirstOrDefault();
        }


        public void Update(HanhKhach entity)
        {
            _context.HanhKhachs.Update(entity);
            _context.SaveChanges();
        }
    }
}
