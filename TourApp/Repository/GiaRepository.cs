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
    public class GiaRepository : IGiaRepository
    {
        private TourContext _context;

        public GiaRepository(TourContext context)
        {
            _context = context;
        }

        public async Task Add(Gia gia)
        {
            _context.Gias.Add(gia);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Gia gia)
        {
            _context.Gias.Remove(gia);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Gia>> getAll()
        {
            return await _context.Gias.ToListAsync();
        }

        public async Task<Gia> getById(int GiaId)
        {
            return await _context.Gias.FindAsync(GiaId);
        }


        public async Task Update(Gia gia)
        {
            _context.Gias.Update(gia);
            await _context.SaveChangesAsync();
        }
    }
}
