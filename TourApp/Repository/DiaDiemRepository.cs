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
    class DiaDiemRepository : IDiaDiemRepository
    {
        private TourContext _context;

        public DiaDiemRepository(TourContext context)
        {
            _context = context;
        }


        public async Task Add(DiaDiem entity)
        {
            _context.DiaDiems.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(DiaDiem entity)
        {
            _context.DiaDiems.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DiaDiem>> getAll()
        {
            return await _context.DiaDiems.Include(t => t.CTTours).ThenInclude(t => t.Tour).ToListAsync();
        }

        public async Task<DiaDiem> getById(int DDId)
        {
            return await _context.DiaDiems.Where(dd => dd.DDId == DDId)
                                          .Include(t => t.CTTours)
                                          .ThenInclude(t => t.Tour)
                                          .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<DiaDiem>> getWhere(string Ten)
        {
            return await _context.DiaDiems.Where(dd => dd.TenDD.Contains(Ten))
                                          .Include(t => t.CTTours)
                                          .ThenInclude(t => t.Tour)
                                          .ToListAsync();
        }

        public async Task Update(DiaDiem entity)
        {
            _context.DiaDiems.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
