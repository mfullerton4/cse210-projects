using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost(); // Sum up each product"s total
        }

        // US Shipping fee based on customer's location
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetName()} ({product.GetProductId()})");
        }
        return label.ToString();
    }
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFormattedAddress());
        return label.ToString();
    }
}