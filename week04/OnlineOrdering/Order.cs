public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double _totalCost;
    private int _shipping;

    public double TotalCost => _totalCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public void CalculateTotalCost()
    {
        _shipping = _customer.InformUSA() == "Yes" ? 5 : 35;

        _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.Price * product.Quantity;
        }

        _totalCost += _shipping;
    }

    public string PackingLabel()
    {
        string text = "";
        foreach (Product product in _products)
        {
            text += $"Product: {product.Name}, ID: {product.ProductId} " + Environment.NewLine;
        }
        return text;
    }

    public string ShippingLabel()
    {
        return $"Customer: {_customer.Name} { Environment.NewLine} {_customer.Address.ShowAddress()}";
    }
}