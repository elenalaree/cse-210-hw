using System;

class Customer
{
    private string _customerName;
    private Address _customerAddress;
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress; 
    }

    public string CustomerName{
        get{ return _customerName;}
    }
    public Address CustomerAddress{
        get{ return _customerAddress;}
    }

    public bool LocalOrNot()
    {
        return true;
    }
}