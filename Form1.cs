namespace doga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnKosz.Click += BtnKosz_Click;
            btnEx.Click += BtnEx_Click;
            btnSzamol.Click += BtnSzamol_Click;
            btnOsszAd.Click += BtnOsszAd_Click;
            btnKivon.Click += BtnKivon_Click;
            btnSzoroz.Click += BtnSzoroz_Click;
            btnOszt.Click += BtnOszt_Click;
            btnAlaphely.Click += BtnAlaphely_Click;
            lblPiros.Click += LblPiros_Click;
            lblZold.Click += LblZold_Click;
            lblKek.Click += LblKek_Click;
        }

        private void LblKek_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Cyan;
        }

        private void LblZold_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Lime;
        }

        private void LblPiros_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void BtnAlaphely_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnOszt_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSzoroz_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnKivon_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnOsszAd_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSzamol_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnEx_Click(object? sender, EventArgs e)
        {
          Application.Exit();
        }

        private void BtnKosz_Click(object? sender, EventArgs e)
        {
            string nev = $"Szia {txtBoxNev.Text}";
            lblUdv.Text = nev;
        }


    }
}