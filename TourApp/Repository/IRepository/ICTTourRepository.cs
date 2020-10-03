using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface ICTTourRepository
    {
        void Add(CTTour entity);
        void Delete(CTTour entity);
        
    }
}
