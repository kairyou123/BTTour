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
    public class TourRepository : ITourRepository
    {
        private TourContext _context;

        public TourRepository(TourContext context)
        {
            _context = context;
        }


        public void Add(Tour entity)
        {
            _context.Tours.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Tour entity)
        {
            entity.isDeleted = Status.Deleted;
            _context.Tours.Update(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Tour> getAll()
        {
            return _context.Tours.Where(t => t.isDeleted == Status.NotDeleted).Include(t => t.Gias).Include(t => t.LHDL).Include(t => t.CTTours).ThenInclude(dd => dd.DiaDiem).ToList();
        }
        public IEnumerable<Tour> getAllDelete()
        {
            return _context.Tours.Include(t => t.Gias).Include(t => t.LHDL).Include(t => t.CTTours).ThenInclude(dd => dd.DiaDiem).ToList();
        }
        public Tour getById(int TourId = 1, string MaTour = "abc")
        {
            return  _context.Tours.Where(t => t.TourId == TourId || t.MaTour == MaTour)
                                       .Include(t => t.LHDL)
                                       .Include(t => t.Gias)
                                       .Include(t => t.CTTours)
                                       .ThenInclude(dd => dd.DiaDiem)
                                       .FirstOrDefault();
        }

        public IEnumerable<Tour> getWhere(string Ten, int isDeleted)
        {
            return _context.Tours.Where(t => t.Ten.Contains(Ten))
                                 .Where(t => t.isDeleted == isDeleted)
                                       .Include(t => t.Gias)
                                       .Include(t => t.CTTours)
                                       .ThenInclude(dd => dd.DiaDiem)
                                       .ToList();
        }

        public void Update(Tour entity)
        {
            _context.Tours.Update(entity);
            _context.SaveChanges();
        }
    }
}
