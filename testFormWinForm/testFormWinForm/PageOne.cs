using System.Windows.Forms;

namespace testFormWinForm
{
    public partial class PageOne : Form
    {
        public PageOne()
        {
            InitializeComponent();
            FillPageNumber();
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
        }

        private void PrevButton_Click(object sender, System.EventArgs e)
        {
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FillAccountDropDown();
        }

        private void FillAccountDropDown()
        {
            string[] accountNames = { "test1", "test2", "test3" };
            foreach (string accountName in accountNames)
            {
                accountDropDown.Items.Add(accountName);
            }
        }


        private void AccountDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] addresses = GetAddresses(accountDropDown.SelectedItem.ToString());

            foreach (string address in addresses)
            {
                addressDropDown.Items.Add(address);
            }
        }

        private string[] GetAddresses(string account)
        {
            if (!(string.IsNullOrEmpty(account)))
            {
                switch (account)
                {
                    case "test1": return ["address12", "address13"];
                    case "test2": return ["address23", "address24"];
                    case "test3": return ["address27", "address28"];
                }

            }
            return [" ", " "];

        }

        private void FillPageNumber()
        {
            pageNumBox.SelectionFont = new Font("Calibri", 14, FontStyle.Bold);
            pageNumBox.SelectionColor = Color.Green;
            pageNumBox.AppendText("1");
            pageNumBox.SelectionColor = Color.Black;
            pageNumBox.AppendText(" 2 3 4 5 6");
            pageNumBox.SelectAll();
            pageNumBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void addressDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            advancedAddressPanel.Visible = true;
        }
    }

}
