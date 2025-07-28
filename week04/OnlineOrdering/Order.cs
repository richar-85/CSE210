using System.Collections.Generic;
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

    public double GetSubtotal()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalPrice();
        }
        return subtotal;
    }

    public double GetShippingCost()
    {
        string country = _customer.GetAddress().GetCountry().Trim().ToLower();
        if (country == "usa")
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public double GetTotalCost()
    {
        return GetSubtotal() + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().GetAddress() + "\n";
        return label;
    }
}