using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuieroPizza.Web.Models;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductosModel();
            producto1.id = 1;
            producto1.Descripcion = "Pizza Pepperoni";

            var producto2 = new ProductosModel();
            producto2.id = 2;
            producto2.Descripcion = "Pizza SuperCheese";

            var producto3 = new ProductosModel();
            producto3.id = 3;
            producto3.Descripcion = "Alitas de Pollo";

            var producto4 = new ProductosModel();
            producto4.id = 4;
            producto4.Descripcion = "Pizza Hawaina";

            var producto5 = new ProductosModel();
            producto5.id = 5;
            producto5.Descripcion = "Pizza Suprema";

            var listadeProductos = new List<ProductosModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);

            return View(listadeProductos);
        }
    }
}