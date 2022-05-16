using KayyuTatilEvleri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayyuTatilEvleri
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAnasayfa fmanasayfa = new frmAnasayfa();
            this.Hide();
            fmanasayfa.Show();
        }
        TatilEviContext db = new TatilEviContext();
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            var liste = db.Musteri.Select(x => new
            {
                x.musteriID,
                x.ad,
                x.soyad,
                x.telefon,
                x.adres,
                x.kayitTarihi,
                x.tcNo,
                x.kullaniciID,

            }).ToList();


            dataGridView1.DataSource = liste;
        }
    }
}
