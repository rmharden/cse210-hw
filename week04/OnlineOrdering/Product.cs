public class Product
{
    private string _productName;
    private string _productId;
    private float _productPrice;

    private float _productQty;

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public float GetProductPrice()
    {
        return _productPrice;
    }

    public float GetProductQty()
    {
        return _productQty;
    }

    public void SetProduct(string productName, string productID, float productPrice, float productQty)
    {
        _productName = productName;
        _productId = productID;
        _productPrice = productPrice;
        _productQty = productQty;
    }

    public float ProductTotal()
    {
        return _productPrice * _productQty;
    }
}