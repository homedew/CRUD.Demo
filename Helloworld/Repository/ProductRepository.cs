using Helloworld.Models;

namespace Helloworld.Repository
{
    public static class Repository
    {
        private static List<Product> products = new List<Product>();

        public static IEnumerable<Product> productObserve
        {
            get { return products.Where(x=>x.isDelete == false); }
        }

        public static void CreateOrUpdate(Product model)
        {
            var getProductById = products.SingleOrDefault(x => x.Id == model.Id);
            var product = new Product();

            if(getProductById == null)
            {
                product.Id = Guid.NewGuid();
                product.Name = model.Name;
                product.Category = model.Category;
                product.Price = model.Price;

                products.Add(product);
            }
            else
            {
                getProductById.Name = model.Name;
                getProductById.Category = model.Category;
                getProductById.Price = model.Price;
            }
        }

        public static void Delete(Guid Id)
        {
            products.Single(x=>x.Id == Id).isDelete = true;
        }

        public static Product GetProductById(Guid? productId)
        {
            var product = products.SingleOrDefault(x => x.Id == productId);

            if (product == null)
            {
                product = new Product();
            }

            return product;
        }
    }

}

