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
    class TourRepository : ITourRepository
    {
        private TourContext _context;

        public TourRepository(TourContext context)
        {
            _context = context;
        }


        public async Task Add(Tour entity)
        {
            _context.Tours.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Tour entity)
        {
            _context.Tours.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tour>> getAll()
        {
            return await _context.Tours.Include(t => t.Gias).Include(t => t.CTTours).ThenInclude(dd => dd.DiaDiem).ToListAsync();
        }

        public async Task<Tour> getById(int TourId = 1, string MaTour = "abc")
        {
            return await _context.Tours.Where(t => t.TourId == TourId || t.MaTour == MaTour)
                                       .Include(t => t.Gias)
                                       .Include(t => t.CTTours)
                                       .ThenInclude(dd => dd.DiaDiem)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Tour>> getWhere(string Ten)
        {
            return await _context.Tours.Where(t => t.Ten.Contains(Ten))
                                       .Include(t => t.Gias)
                                       .Include(t => t.CTTours)
                                       .ThenInclude(dd => dd.DiaDiem)
                                       .ToListAsync();
        }

        public async Task Update(Tour entity)
        {
            _context.Tours.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
