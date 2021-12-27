using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceExampleForm
{
    public partial class Dikdortgen : Form
    {
        public Dikdortgen()
        {
            InitializeComponent();
        }
        List<DikdortgenKutu> listkutu = new List<DikdortgenKutu>();
        private void btnekle_Click(object sender, EventArgs e)
        {
            DikdortgenKutu dk = new DikdortgenKutu();
            dk.Ad = tbad.Text;
            dk.ID = Convert.ToInt32(tbid.Text);
            dk.Yukseklik = Convert.ToInt32(tbyukseklik.Text);
            dk.KisaKenar = Convert.ToInt32(tbkisa.Text);
            dk.UzunKenar = Convert.ToInt32(tbuzun.Text);
            listkutu.Add(dk);

            Temizle();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            List<DikdortgenKutu> dkList = new List<DikdortgenKutu>();
            foreach (var item in listkutu)
            {
                DikdortgenKutu dgk = new DikdortgenKutu();
                dgk.Ad = item.Ad;
                dgk.ID = item.ID;
                dgk.Yukseklik = item.Yukseklik;
                dgk.KisaKenar = item.KisaKenar;
                dgk.UzunKenar = item.UzunKenar;
                dkList.Add(dgk);
            }
            dgv.DataSource = dkList;
        }

        public void Temizle()
        {
            tbid.Clear();
            tbad.Clear();
            tbyukseklik.Clear();
            tbkisa.Clear();
            tbuzun.Clear();
            tbhacim.Clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DikdortgenKutu selected = dgv.CurrentRow.DataBoundItem as DikdortgenKutu;
            tbid.Text = selected.ID.ToString();
            tbad.Text = selected.Ad;
            tbyukseklik.Text = selected.Yukseklik.ToString();
            tbkisa.Text = selected.KisaKenar.ToString();
            tbuzun.Text = selected.UzunKenar.ToString();
            tbhacim.Text = selected.Hacim().ToString();
        }
    }
}
