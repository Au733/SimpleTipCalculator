namespace SimpleTipCalculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Title = "Simple Tip Calculator";
    }

    private void Fifteen_OnClicked(object sender, EventArgs e)
    {
        double dblAmount;

        Double.TryParse(txtBillAmount.Text, out dblAmount);

        lblDisplay.Text =
            ("15% Tip: " + "$" + (dblAmount * .15) + " | " + "Total: " + "$" + (dblAmount + (dblAmount * .15))).ToString();
    }

    private void Twenty_OnClicked(object sender, EventArgs e)
    {
        double dblAmount;

        Double.TryParse(txtBillAmount.Text, out dblAmount);

        lblDisplay.Text =
            ("20% Tip: " + "$" + (dblAmount * .20) + " | " + "Total: " + "$" + (dblAmount + (dblAmount * .20))).ToString();
    }

    private void TwentyFive_OnClicked(object sender, EventArgs e)
    {
        double dblAmount;

        Double.TryParse(txtBillAmount.Text, out dblAmount);

        lblDisplay.Text =
            ("25% Tip: " + "$" + (dblAmount * .25) + " | " + "Total: " + "$" + (dblAmount + (dblAmount * .25))).ToString();
    }
}