public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public float TotalCost()
    {
        float Total = 0;
        foreach (Product product in _products)
        {
            Total += product.GetTotalCost();
        }
        Total += _customer.LivesInUSA() ? 5 : 35;
        return Total;
    }
    public string Label()
{
    string label = "Packing Label:\n";

    foreach (Product product in _products)
    {
        label += $"Product: {product.GetProductName()}, ID: {product.GetId()}\n";
    }

    return label;
}
    public string ShippingLabel()
    {
        return $"Shipping Label:\nName: {_customer.GetName()}\nAddress:\n{_customer.GetAddress().GetFullAddress()}";
    }
    
}