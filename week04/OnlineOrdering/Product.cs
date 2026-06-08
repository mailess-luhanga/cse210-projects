public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

<<<<<<< HEAD
=======
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
<<<<<<< HEAD
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
=======
    }}
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
