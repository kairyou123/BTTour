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
    public class LoaiHinhDuLichRepository : ILoaiHinhDuLichRepository
    {
        private TourContext _context;

        public LoaiHinhDuLichRepository(TourContext context)
        {
            _context = context;
        }

        public void Add(LoaiHinhDL lhdl)
        {
            _context.LoaiHinhDLs.Add(lhdl);
            _context.SaveChanges();
        }

        public void Delete(LoaiHinhDL lhdl)
        {
            _context.LoaiHinhDLs.Remove(lhdl);
            _context.SaveChanges();
        }

        public IEnumerable<LoaiHinhDL> getAll()
        {
            return _context.LoaiHinhDLs.ToList();
        }

        public LoaiHinhDL getById(int lhdlId)
        {
            return _context.LoaiHinhDLs.Find(lhdlId);
        }
        public IEnumerable<LoaiHinhDL> getWhere(string ID,string Ten, string Mota)
        {
            return _context.LoaiHinhDLs.Where(i => i.LHDLId.ToString().Contains(ID)
                                                && i.Ten.Contains(Ten)
                                                && i.moTa.Contains(Mota)
                                                ).ToList();
        }

        public void Update(LoaiHinhDL lhdl)
        {
            _context.LoaiHinhDLs.Update(lhdl);
            _context.SaveChanges();
        }
    }
}
