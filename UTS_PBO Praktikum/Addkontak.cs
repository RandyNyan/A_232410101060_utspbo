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
    public partial class Addkontak : Form
    {
        private Halaman_Kontak _parentForm;
        public Addkontak(Halaman_Kontak parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNamaFasilitas.Text) ||
                string.IsNullOrWhiteSpace(TextBoxJumlahFasilitas.Text) ||
                string.IsNullOrWhiteSpace(Textboxttlp.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kontakbaru = new Stukturkontak
            {
                nama_orang = TextBoxNamaFasilitas.Text,
                email_orang = TextBoxJumlahFasilitas.Text,
                no_tlp = Textboxttlp.Text,
            };

            try
            {
                CRUD_Kontak.Addkontak(kontakbaru);
                MessageBox.Show("Kontak berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.LoadDataKontak();
                TextBoxNamaFasilitas.Clear();
                TextBoxJumlahFasilitas.Clear();
                Textboxttlp.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menambahkan kontak: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
