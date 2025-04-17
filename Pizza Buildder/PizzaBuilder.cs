using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Buildder
{
    public partial class frmPizzaBuillder : Form
    {
        public frmPizzaBuillder()
        {
            InitializeComponent();
        }

        private void frmPizzaBuillder_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name= txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            customer.City = txtCity.Text;   
            customer.State = txtState.Text;
            customer.Zip=txtZipcode.Text;

            Pizza pizza = new Pizza();
            pizza.Size = cbSize.SelectedItem.ToString();
            pizza.CrustType = cbCrustType.SelectedItem.ToString();

            pizza.Toppings = GetToppings();
            pizza.Additions = GetPremiumAdditions();
            pizza.SauseSelection = SauseSelected;

            string OrderType = rbDelivery.Checked ? rbDelivery.Text : rbPickup.Text;
            decimal Tips = 0m;
            
            if (txtTip.Text != "")
            {

                 decimal.TryParse(txtTip.Text,out Tips);
                
            }
            

            Order order = new Order(customer,pizza,OrderType,Tips);
            OrderConfirmation orderReceipt = new OrderConfirmation(order);
            orderReceipt.ShowDialog();
            

        }

        private List<string> GetToppings()
        {
            var toppings = new List<string>();
            foreach (CheckBox checkbox in gbToppings.Controls)
            {
                if (checkbox.Checked)
                {
                    toppings.Add(checkbox.Text);

                }
            }
            return toppings;
        }

        private List<string> GetPremiumAdditions()
        {
            var additions = new List<string>();
            foreach (CheckBox checkbox in gbPremiumAdditions.Controls)
            {
                if (checkbox.Checked)
                {
                    additions.Add(checkbox.Text);
                }
            }
            return additions;
        }

        private string SauseSelected
        {
            get
            {
                string selectedSauce = "";
                foreach (RadioButton radio in gbSauceSelection.Controls)
                {
                    {
                        if (radio.Checked)
                        {
                            selectedSauce = radio.Text;
                            break;
                        }
                    }
                   
                }

                return selectedSauce;

            }
        }
        private void  cbCrustType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCrust = cbCrustType.SelectedItem.ToString();
            switch (selectedCrust)
            {
                case "Regular":
                    picCrust.Image = Properties.Resources.regular;
                    break;
                case "Stuffed":
                    picCrust.Image = Properties.Resources.stuffed;
                    break;
                case "Deep Dish":
                    picCrust.Image = Properties.Resources.deepdish ;
                    break;
                case "Thin Crust":
                    picCrust.Image = Properties.Resources.thin;
                    break;
                case "Cheesy Garlic Butter":
                    picCrust.Image = Properties.Resources.cheesy;
                    break;

            }

        }

    }
}
