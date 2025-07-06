public class Product
{
    public string _productName;
    public string _productId;
    public double _productPrice;
    public double _productQty;


    public double GetTotalProductCost()
    {
        return _productPrice * _productQty;
    }




}