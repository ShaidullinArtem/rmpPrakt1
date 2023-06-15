namespace prmPract1._2.types
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetInfo()
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}