using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourApp.Context;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp.Repository
{
    public class ChiTieuRepository : IChiTieuRepository
    {
        private TourContext _context;

        public ChiTieuRepository(TourContext context)
        {
            _context = context;
        }

        public void Add(ChiTieu chiTieu)
        {
            _context.ChiTieus.Add(chiTieu);
            _context.SaveChanges();
        }

        public void Delete(ChiTieu chiTieu)
        {
            _context.ChiTieus.Remove(chiTieu);
            _context.SaveChanges();
        }

        public IEnumerable<ChiTieu> getAll()
        {
            return  _context.ChiTieus.ToList();
        }

        public ChiTieu getById(int CTId)
        {
            return _context.ChiTieus.Find(CTId);
        }

        public IEnumerable<ChiTieu> getWhere(string Ten)
        {
            return _context.ChiTieus.Where(c => c.Ten.Contains(Ten)).ToList();
                                           
        }

        public void Update(ChiTieu chiTieu)
        {
            _context.ChiTieus.Update(chiTieu);
            _context.SaveChanges();
        }
    }
}
