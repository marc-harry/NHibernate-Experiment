using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.DataAccess.Domain;
using NHibernate.DataAccess.Repositories;

namespace NHibernate.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Product> products = session.CreateCriteria<Product>().List<Product>();

                foreach (Product product in products)
                {
                    Console.WriteLine("Product name: {0} \nProduct type: {1} \n", product.Name, product.Category);
                }

                Console.Read();
            }
        }
    }
}
