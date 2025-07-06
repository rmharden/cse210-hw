public class Product
{
    public double _price;
    public double _quantity;
    public string _name;

    public double GetTotal()
    {
        return _price * _quantity;
    }




}