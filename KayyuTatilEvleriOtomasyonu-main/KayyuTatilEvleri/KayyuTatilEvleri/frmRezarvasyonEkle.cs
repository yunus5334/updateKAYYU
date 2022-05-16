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
    public partial class frmRezarvasyonEkle : Form
    {
        TatilEviContext db = new TatilEviContext();
        public frmRezarvasyonEkle()
        {
            InitializeComponent();
        }

        private void frmRezarvasyonEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Rezervasyon r = new Rezervasyon();
            //r.baslangıcTarihi.Value
            r.musteriID = Convert.ToInt32(txtMusteriID.Text);
            r.odemeTuru = (string)cmbOdemeYontemi.SelectedValue;
            r.tutar = Convert.ToInt32(txtTutar.Text);
            r.evID = Convert.ToInt32(txtEvID.Text);
            r.aciklama = txtAciklama.Text;
            db.Rezervasyon.Add(r);
            int sonuc = db.SaveChanges();

            if (sonuc == 1)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Abort;

            this.Close();
        }
            
    }
}
