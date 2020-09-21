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
    class ChiTieuRepository : IChiTieuRepository
    {
        private TourContext _context;

        public ChiTieuRepository(TourContext context)
        {
            _context = context;
        }

        public async Task Add(ChiTieu chiTieu)
        {
            _context.ChiTieus.Add(chiTieu);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(ChiTieu chiTieu)
        {
            _context.ChiTieus.Remove(chiTieu);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ChiTieu>> getAll()
        {
            return await _context.ChiTieus.ToListAsync();
        }

        public async Task<ChiTieu> getById(int CTId)
        {
            return await _context.ChiTieus.FindAsync(CTId);
        }

        public async Task<IEnumerable<ChiTieu>> getWhere(string Ten = "")
        {
            return await _context.ChiTieus.Where(c => c.Ten.Contains(Ten)).ToListAsync();
                                           
        }

        public async Task Update(ChiTieu chiTieu)
        {
            _context.ChiTieus.Update(chiTieu);
            await _context.SaveChangesAsync();
        }
    }
}
