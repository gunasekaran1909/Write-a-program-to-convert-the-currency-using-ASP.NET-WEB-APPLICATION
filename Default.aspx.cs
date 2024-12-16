using System;

namespace CurrencyConverterWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            // Conversion rates
            double usdToEurRate = 0.85;  // 1 USD = 0.85 EUR
            double usdToInrRate = 83.0;  // 1 USD = 83 INR
            double eurToInrRate = 98.0;  // 1 EUR = 98 INR

            string sourceCurrency = ddlSourceCurrency.SelectedValue;
            string targetCurrency = ddlTargetCurrency.SelectedValue;
            double amount;

            if (!double.TryParse(txtAmount.Text, out amount))
            {
                lblResult.Text = "Please enter a valid amount.";
                return;
            }

            double convertedAmount = 0;

            // Conversion logic
            if (sourceCurrency == "USD" && targetCurrency == "EUR")
            {
                convertedAmount = amount * usdToEurRate;
            }
            else if (sourceCurrency == "USD" && targetCurrency == "INR")
            {
                convertedAmount = amount * usdToInrRate;
            }
            else if (sourceCurrency == "EUR" && targetCurrency == "INR")
            {
                convertedAmount = amount * eurToInrRate;
            }
            else if (sourceCurrency == "EUR" && targetCurrency == "USD")
            {
                convertedAmount = amount / usdToEurRate;
            }
            else if (sourceCurrency == "INR" && targetCurrency == "USD")
            {
                convertedAmount = amount / usdToInrRate;
            }
            else if (sourceCurrency == "INR" && targetCurrency == "EUR")
            {
                convertedAmount = amount / eurToInrRate;
            }
            else
            {
                lblResult.Text = "Invalid currency combination.";
                return;
            }

            // Display result
            lblResult.Text = $"Converted amount: {convertedAmount:F2} {targetCurrency}";
        }
    }
}
