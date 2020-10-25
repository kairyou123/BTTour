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
            return _context.DoanKhachs.Where(dk => dk.isDeleted == Status.NotDeleted).ToList();
        }

        public IEnumerable<DoanKhach> getAllDelete()
        {
            return _context.DoanKhachs.Where(dk => dk.isDeleted == Status.Deleted).ToList();
        }

        public IEnumerable<DoanKhach> getWhere(string name, int isDeleted, string nameTour)
        {
            return _context.DoanKhachs.Where(dk => dk.isDeleted == Status.NotDeleted && dk.TenDoan == name && dk.Tour.Ten == nameTour).ToList();
        }

        public DoanKhach getById(int id, string maDK = "")
        {
            return _context.DoanKhachs.Where(dk => dk.DoanId == id || dk.MaDoan == maDK).FirstOrDefault();
        }


        public void Update(DoanKhach entity)
        {
            _context.DoanKhachs.Update(entity);
            _context.SaveChanges();
        }
    }
}
