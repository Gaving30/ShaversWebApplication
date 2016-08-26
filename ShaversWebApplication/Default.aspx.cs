using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaversWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetImageURL();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SetImageURL();
        }

        private void SetImageURL()
        {
            if(ViewState["ImageDisplayed"] == null)
            {
                Image1.ImageUrl = "~/SlideImages/1.jpg";
                ViewState["ImageDisplayed"] = 1;
            }
            else
            {
                int i = (int)ViewState["ImageDisplayed"];

                if (i == 6)
                {
                    Image1.ImageUrl = "~/SlideImages/1.jpg";
                    ViewState["ImageDisplayed"] = 1;
                }
                else
                {
                    i = i + 1;
                    Image1.ImageUrl = "~/SlideImages/" + i.ToString() + ".jpg";
                    ViewState["ImageDisplayed"] = i;
                }
            }
        }
    }
}