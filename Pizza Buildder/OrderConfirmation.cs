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
    public partial class OrderConfirmation : Form
    {

        private Order _order;
        private decimal _totalCost;
        public OrderConfirmation(Order order)
        {
            InitializeComponent();
            _order = order;
            _totalCost = _order.CalculateTheCost();
            DisplayOrderDetails();
        }

        private void DisplayOrderDetails()
        {
            // Check if _order and its properties are not null before accessing them
            if (_order == null)
            {
                MessageBox.Show("Order details are missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Handle missing Customer information
            var customer = _order.Customer;
            if (customer != null)
            {
                lblCustomerName.Text = !string.IsNullOrEmpty(customer.Name) ? customer.Name : "N/A";
                lblPhone.Text = !string.IsNullOrEmpty(customer.Phone) ? customer.Phone : "N/A";
                lblAddress.Text = $"{customer.Address ?? "N/A"}, State: {customer.State ?? "N/A"}, City: {customer.City ?? "N/A"}, Zip: {customer.Zip ?? "N/A"}";
            }
            else
            {
                lblCustomerName.Text = "N/A";
                lblPhone.Text = "N/A";
                lblAddress.Text = "N/A";
            }

            // Display order type 
            lblDeliveryOrPickup.Text = _order.OrderType?.ToString() ?? "Unknown";

            // Handle missing Pizza information
            var pizza = _order.Pizza;
            if (pizza != null)
            {
                lblPizzaSize.Text = pizza.Size?.ToString() ?? "N/A";
                lblCrustType.Text = pizza.CrustType?.ToString() ?? "N/A";
                lblSauce.Text = pizza.SauseSelection?.ToString() ?? "N/A";

                // Handle toppings and additions safely
                lblToppings.Text = (pizza.Toppings != null && pizza.Toppings.Any()) ? string.Join(", ", pizza.Toppings) : "none";
                lblPremiumAdditions.Text = (pizza.Additions != null && pizza.Additions.Any()) ? string.Join(", ", pizza.Additions) : "none";
            }
            else
            {
                lblPizzaSize.Text = "N/A";
                lblCrustType.Text = "N/A";
                lblSauce.Text = "N/A";
                lblToppings.Text = "none";
                lblPremiumAdditions.Text = "none";
            }

            // Display tip and total cost with proper formatting
            lblTip.Text = _order.Tips.ToString("C");
            lblTotalCost.Text = _totalCost.ToString("C");

            // Display order date and time with a default message if missing
            lblOrderDateTime.Text = _order.OrderDateTime != DateTime.MinValue ? _order.OrderDateTime.ToString("f") : "Date not available";

            // Calculate tax and display
            decimal taxRate = 0.20m;
            decimal taxAmount = _totalCost * taxRate;
            label13.Text = taxAmount.ToString("C");
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
