namespace AutoComp
{
    public partial class Form1 : Form
    {
        decimal startPrice;
        public Form1()
        {
            InitializeComponent();
            startPrice = 2500000;
            lbToltal.Text+=startPrice.ToString("c");
        }
    }
}