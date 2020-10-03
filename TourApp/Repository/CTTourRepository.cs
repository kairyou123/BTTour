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
    public class CTTourRepository : ICTTourRepository
    {
        private TourContext _context;

        public CTTourRepository(TourContext context)
        {
            _context = context;
        }

        public void Add(CTTour entity)
        {
            _context.CTTours.Add(entity);
            _context.SaveChanges();
        }


        public void Delete(CTTour entity)
        {
            _context.CTTours.Remove(entity);
            _context.SaveChanges();
        }

    }
}
