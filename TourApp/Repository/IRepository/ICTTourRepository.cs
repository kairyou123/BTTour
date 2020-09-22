using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    interface ICTTourRepository
    {
        Task Add(CTTour entity);
        Task Delete(CTTour entity);
        
    }
}
