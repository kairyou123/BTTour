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

        public void Add(Gia gia)
        {
            _context.Gias.Add(gia);
            _context.SaveChanges();
        }

        public void Delete(Gia gia)
        {
            _context.Gias.Remove(gia);
            _context.SaveChanges();
        }

        public IEnumerable<Gia> getAll()
        {
            return  _context.Gias.ToList();
        }

        public Gia getById(int GiaId)
        {
            return  _context.Gias.Find(GiaId);
        }


        public void Update(Gia gia)
        {
            _context.Gias.Update(gia);
            _context.SaveChanges();
        }
    }
}
