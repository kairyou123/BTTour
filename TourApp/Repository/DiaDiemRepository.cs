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
    public class DiaDiemRepository : IDiaDiemRepository
    {
        private TourContext _context;

        public DiaDiemRepository(TourContext context)
        {
            _context = context;
        }


        public void Add(DiaDiem entity)
        {
            _context.DiaDiems.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(DiaDiem entity)
        {
            _context.DiaDiems.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<DiaDiem> getAll()
        {
            return _context.DiaDiems.Include(t => t.CTTours).ThenInclude(t => t.Tour).ToList();
        }

        public DiaDiem getById(int DDId)
        {
            return _context.DiaDiems.Where(dd => dd.DDId == DDId)
                                          .Include(t => t.CTTours)
                                          .ThenInclude(t => t.Tour)
                                          .FirstOrDefault();
        }

        public IEnumerable<DiaDiem> getWhere(string Ten)
        {
            return _context.DiaDiems.Where(dd => dd.TenDD.Contains(Ten))
                                          .Include(t => t.CTTours)
                                          .ThenInclude(t => t.Tour)
                                          .ToList();
        }

        public void Update(DiaDiem entity)
        {
            _context.DiaDiems.Update(entity);
            _context.SaveChanges();
        }
    }
}
