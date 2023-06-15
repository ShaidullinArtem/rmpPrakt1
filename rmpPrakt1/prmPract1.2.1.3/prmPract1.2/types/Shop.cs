using System.Collections.Generic;

namespace prmPract1._2.types
{
    public class Shop
    {
        private Dictionary<Product, int> products;
        private decimal totaProfit = 0;

        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        public string getTotalProfit()
        {
            return $"Магазин заработал с продаж: {totaProfit} руб";
        }

        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }

        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
        
        public string Sell(string ProductName)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell);
                return "";
            }
            else
            {
                return "Товар не найден!";
            }
        }
        
        public string Sell(Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    return "Нет в наличии!";
                }
                else
                {
                    totaProfit += product.Price;
                    products[product]--;
                    return "Успешкая покупка";
                }
            }
            else
            {
                return "Товар не найден!";
            }
        }

        public string WriteAllProducts()
        {
            string productsList = "Список продуктов:\n";
            foreach (var product in products)
            { 
                productsList += $"{product.Key.GetInfo()}; Количество: {product.Value}\n";
            }

            return productsList;
        }
    }
}