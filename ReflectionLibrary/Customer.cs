namespace ReflectionLibrary
{
    public class Customer:Person
    {
        public int CustomerNumber { get; set; }
        public Customer(Guid id, int customerNumber) { 
        
            this.Id = id;
            this.CustomerNumber = customerNumber;
        }
        public Customer(Guid id, int customerNumber, string name, string surname) : this(id, customerNumber)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void UpdateCustomerNumber(int customerNumber)
        {
            this.CustomerNumber = customerNumber;
        }

    }
}