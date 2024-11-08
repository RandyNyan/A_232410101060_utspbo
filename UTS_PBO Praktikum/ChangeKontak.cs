using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO_Praktikum.CRUD;
using UTS_PBO_Praktikum.StrukturData;

namespace UTS_PBO_Praktikum
{
    public partial class ChangeKontak : Form
    {
        private int idkontak;
        private Halaman_Kontak parentForm;
        public ChangeKontak(int id, string nama, string email, string notlp, Halaman_Kontak parent)
        {
            InitializeComponent();
            this.idkontak = id;
            this.parentForm = parent;

            // Isi kontrol dengan data yang diterima
            TextBoxtNamaFasilitas.Text = nama;
            TextBoxtJumlahFasilitas.Text = email;
            TextBoxtFasilitasBaik.Text = notlp;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            try
            {
                string namaFasilitas = TextBoxtNamaFasilitas.Text;
                string jumlahFasilitas = TextBoxtJumlahFasilitas.Text;
                string fasilitasBaik = TextBoxtFasilitasBaik.Text;

                Stukturkontak kontak = new Stukturkontak
                {
                    id_fasilitas_gym = idkontak, 
                    email_orang = jumlahFasilitas,
                    no_tlp = fasilitasBaik,
                };

                CRUD_Kontak.Updatekontak(kontak);

                parentForm.LoadDataKontak();

                MessageBox.Show("Fasilitas berhasil diperbarui.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
