namespace AbstractHomeWorkProduct
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }   
        public DateOnly DateOfManufacture {  get; set; }
        public DateOnly ExpirationDate { get; set; }
        protected BaseProduct(string name, double price, DateOnly dateOfManufacture, DateOnly expirationDate) 
        { 
            Name = name;    
            Price = price;  
            DateOfManufacture = dateOfManufacture;  
            ExpirationDate = expirationDate;
        }
        protected BaseProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract void DisplayInformation();
        public abstract bool IsExpiredDate();
    }
}
