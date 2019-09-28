using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string myConnectionString = "Data Source=(local);Initial Catalog=MART391_HW-5;User ID=specialuser;Password=test123";
        SqlConnection myConnection = new SqlConnection(myConnectionString);
        myConnection.Open();

    }
}