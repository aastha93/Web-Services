using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class solarform : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SolarService.ServiceClient sol = new SolarService.ServiceClient();
        SolarService.ServiceClient sol3 = new SolarService.ServiceClient();
        
        ansL.Text = sol3.getSolarEnergyData(txt_Long.Text,txt_Lat.Text);
        ansLabel.Text = sol3.f();
    
    }
    
}