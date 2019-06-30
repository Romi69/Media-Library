using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForWCFCalcService
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["AttemptCount"] == null)
                {
                    Session["AttemptCount"] = new Hashtable(); //Because of this line.
                }
            }
        }

        ServiceReferenceCalc.CalcServiceClient client = new ServiceReferenceCalc.CalcServiceClient();

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = client.GetResult().ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int newValue;
            bool hasValue = int.TryParse(TextBox2.Text, out newValue);

            if (String.IsNullOrWhiteSpace(TextBox2.Text) || !hasValue)
            {
                TextBox1.Text = client.AddOne().ToString();
            }
            else
            {
                TextBox1.Text = client.Add(newValue).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int newValue;
            bool hasValue = int.TryParse(TextBox2.Text, out newValue);

            if (String.IsNullOrWhiteSpace(TextBox2.Text) || !hasValue)
            {
                TextBox1.Text = client.SubOne().ToString();
            }
            else
            {
                TextBox1.Text = client.Sub(newValue).ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            client.Clear();
            TextBox1.Text = client.GetResult().ToString();

        }
    }
}