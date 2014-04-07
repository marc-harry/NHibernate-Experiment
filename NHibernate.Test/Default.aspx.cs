using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate.DataAccess.Repositories;
using NHibernate.DataAccess.Domain;
using NHibernate.DataAccess.Repositories;

namespace NHibernate.Test
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Product> products = session.CreateCriteria<Product>().List<Product>();

                foreach (Product product in products)
                {
                    productList.InnerHtml += string.Format("<li>Product name: {0} <br />Product type: {1} </li>", product.Name, product.Category);
                }                
            }
        }
    }
}