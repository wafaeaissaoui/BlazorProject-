using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BlazorApp2.DataAccessLayer
{
    public class EmployeeAccessLayer : IEmployee
    {
        private ManagementContext _context;
        public EmployeeAccessLayer(ManagementContext context)
        {
            _context = context;
        }
        public void create(employe e)
        {
            try 
            {
                _context.Employes.Add(e);
                _context.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }

        public void delete(int id)
        {
            try
            {
             employe e = _context.Employes.Find(id);
             _context.Employes.Remove(e);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public IEnumerable GetEmployes()
        {
            try 
            {
                return _context.Employes.ToList();
            }
            catch
            {
                throw new Exception();
            }
        }

        public employe get(int id)
        {
            throw new NotImplementedException();
        }

        public void update(employe e)
        {
            _context.Entry(e).State = EntityState.Modified;
               }
    }
}
