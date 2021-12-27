namespace InterfaceExampleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Iurun> listurun = new List<Iurun>();
        private void btnekle_Click(object sender, EventArgs e)
        {
            KupKutu kk = new KupKutu();
            kk.Ad = tbad.Text;
            kk.ID = Convert.ToInt32(tbid.Text);
            kk.Yukseklik = Convert.ToInt32(tbyukseklik.Text);
            listurun.Add(kk);

            Temizle();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            List<KupKutu> kkList = new List<KupKutu>();
            foreach( var item in listurun)
            {
            KupKutu k = new KupKutu();
                k.Ad = item.Ad;
                k.ID = item.ID;
                k.Yukseklik = item.Yukseklik;
                kkList.Add(k);
            }
            dgv.DataSource = kkList;
        }

        public void Temizle()
        {
            tbid.Clear();
            tbad.Clear();
            tbyukseklik.Clear();
            tbhacim.Clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KupKutu selected = dgv.CurrentRow.DataBoundItem as KupKutu;
            tbid.Text = selected.ID.ToString();
            tbad.Text = selected.Ad;
            tbyukseklik.Text = selected.Yukseklik.ToString();
            tbhacim.Text = selected.Hacim().ToString();
        }

    }
}