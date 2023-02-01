using BlazorApp2.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp2.DataAccessLayer
{
    public interface IEmployee
    {
          void create( employe e);
          void update(employe e);
          void  delete(int id );
          IEnumerable employes();
          employe get(int id);
    }
}
