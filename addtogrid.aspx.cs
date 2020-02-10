using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace xmlapp
{
    public partial class addtogrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader xmlFile;
                xmlFile = XmlReader.Create("C:/Users/Dell/source/repos/xmlapp/Product.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                gdview1.DataSource = ds.Tables[0];
                gdview1.DataBind();
            }
            catch (Exception ex)
            {
                lblmessage.Text = ex.ToString();
            }
        }
    }
}