// ENCAPSULATION

public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private double _quantity;

    public Product(string productName, string id, double price, double quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;

    }
}


// public class Product
// {
//     private string _productName;
//     private string _productId;
//     private double _productPrice;
//     private int _productQty;

//     public Product(string productName, string productId, int productPrice, int productQty)
//     {
//         _productName = productName;
//         _productId = productId;
//         _productPrice = productPrice;
//         _productQty = productQty;
//     }

//     public double GetTotalProductCost()
//     {
//         return _productPrice * _productQty;
//     }
// }