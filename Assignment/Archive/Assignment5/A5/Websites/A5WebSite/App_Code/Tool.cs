using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tool
/// </summary>
public class Tool
{
    public Tool()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int32 _id;
    public string _name;
    public double _price;
    public string _url;
    public bool _InCart;
    public Tool(string name, double price,string url,Int32 id)
    {
        _id = id;
        _name = name;
        _price = price;
        _url = url;
        _InCart = false;
    }
}