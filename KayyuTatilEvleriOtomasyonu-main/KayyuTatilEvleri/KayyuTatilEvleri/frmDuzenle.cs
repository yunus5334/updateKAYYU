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
    public partial class frmDuzenle : Form
    {
        public int RezervasyonID;
        TatilEviContext db = new TatilEviContext();

        public frmDuzenle()
        {
            InitializeComponent();
        }

        private void frmDuzenle_Load(object sender, EventArgs e)
        {
            Rezervasyon r = db.Rezervasyon.Where(x => x.rezervasyonID == RezervasyonID).SingleOrDefault();
            if (r == null)
                MessageBox.Show("Hata");
            else
            {
                txtRezervasyonID.Text = r.rezervasyonID.ToString();
                dateTimeBaslangic.Value = r.baslangıcTarihi.Value;
                dateTimeBitis.Value = r.bitisTarihi.Value;
                txtMusteriID.Text = r.musteriID.ToString();
                cmbOdemeYontemi.Text = r.odemeTuru ;
                txtTutar.Text = r.tutar.ToString();
                txtEvID.Text = r.evID.ToString();
                txtAciklama.Text = r.aciklama;


                
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Rezervasyon r = db.Rezervasyon.Where(x => x.rezervasyonID == RezervasyonID).SingleOrDefault();
            //r.rezervasyonID =Convert.ToInt32( txtRezervasyonID.Text);
            //r.baslangıcTarihi. = dateTimeBaslangic.Value;
            r.musteriID = Convert.ToInt32(txtMusteriID.Text);
            r.odemeTuru =(string)cmbOdemeYontemi.SelectedValue;
            r.tutar = Convert.ToInt32(txtTutar.Text);
            r.evID = Convert.ToInt32(txtEvID.Text);
            r.aciklama = txtAciklama.Text;

            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        
    }
}
