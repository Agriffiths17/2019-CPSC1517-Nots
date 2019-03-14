using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KDContest
{
    public partial class KDContest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                if(AgreeToTerms.Checked)
                {
                    MessageLabel.Text = "Good luck on the contest!";
                    
                }
            }
        }

        protected void ClearForm_Click(object sender, EventArgs e)
        {

        }
    }
    public class Entrant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Age { get; set; }

        public Entrant(string firstName, string lastName, string email, string city, string prov, string postalCode, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            City = city;
            Province = prov;
            PostalCode = postalCode;
        }
    }
}