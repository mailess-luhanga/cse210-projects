using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

<<<<<<< HEAD
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
=======
        total += _customer.LivesInUSA() ? 5 : 35;
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        foreach (Product product in _products)
        {
            label.AppendLine(
<<<<<<< HEAD
                $"Product: {product.GetName()}, ID: {product.GetProductId()}");
=======
                $"Product: {product.GetName()} | ID: {product.GetProductId()}");
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
<<<<<<< HEAD
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
=======
        return $"{_customer.GetName()}\n" +
               $"{_customer.GetAddress().GetFullAddress()}";
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
    }
}