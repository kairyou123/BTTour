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

        public IEnumerable<Tour> getWhere(string Ten,string LHDL, string ID, string MaTour,DateTime fromDate, DateTime toDate , int fromPrice, int toPrice, int isDeleted)
        {
            
            var result = _context.Tours.Include(t => t.Gias)
                                 .Include(t => t.LHDL)
                                 .Include(t => t.CTTours)
                                 .ThenInclude(dd => dd.DiaDiem)
                                 .Where(t => t.Ten.Contains(Ten))
                                 .Where(t => t.LHDL.Ten.Contains(LHDL))
                                 .Where(t => t.MaTour.Contains(MaTour))
                                 .Where(t => t.TourId.ToString().Contains(ID))
                                 .Where(t => t.Gias.Where(i => (
                                                                DateTime.Compare(i.TGBD, fromDate) >= 0
                                                             && DateTime.Compare(i.TGKT, toDate) <= 0
                                                             && i.GiaTri >= fromPrice
                                                             && i.GiaTri <= toPrice
                                                           ))
                                                    .Count() > 0)
                                 .Where(t => t.isDeleted == isDeleted)
                                 .ToList();

            return result;
        }

        public void Update(Tour entity)
        {
            _context.Tours.Update(entity);
            _context.SaveChanges();
        }
    }
}
