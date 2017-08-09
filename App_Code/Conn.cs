using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for Conn
/// </summary>
public class Conn
{ 
	public SqlConnection mycon()
	{

        string str = ConfigurationManager.ConnectionStrings["App"].ToString();
        SqlConnection con = new SqlConnection(str);
        return con;
    
    }
}