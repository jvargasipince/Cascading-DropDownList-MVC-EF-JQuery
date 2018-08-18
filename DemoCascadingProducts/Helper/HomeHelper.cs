using DemoCascadingProducts.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DemoCascadingProducts.Helper
{
    public class HomeHelper
    {
        public IEnumerable<SelectListItem> GetCompanies()
        {
            var data = new KaizenForceEntities();

            return data.Empresa.Select(x => new SelectListItem
            {
                Text = x.nombre,
                Value = x.id_empresa.ToString()
            }).ToList();
        }

        public IEnumerable<SelectListItem> GetStores(int idCompany)
        {
            var data = new KaizenForceEntities();

            return data.Almacen.Where(y=> y.id_empresa == idCompany).Select(x => new SelectListItem
            {
                Text = x.nombre,
                Value = x.id_almacen.ToString()
            }).ToList();
        }

    }
}