using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for KeyGenerator
/// </summary>
public static class KeyGenerator
{

    public static string keyData()
    {
        StringBuilder ss = new StringBuilder();
        Random r = new Random();
        char ch;
        for (int i = 0; i < 5; i++)
        { 
        
        ch=Convert.ToChar(Convert.ToInt32(Math.Floor(26*r.NextDouble()+65)));
        ss.Append(ch);
        }
        return ss.ToString();
    }
}