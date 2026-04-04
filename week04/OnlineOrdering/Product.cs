public class Product
{
    private string _productName;
    private int _productId;
    private float _price;
    private int _quantity;
    public float GetTotalCost()
    {
        return _price * _quantity;
    }
    public Product(string name, int id, float price, int quantity)
    {
    _productName = name;
    _productId = id;
    _price = price;
    _quantity = quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public int GetId()
    {
        return _productId;
    }
}