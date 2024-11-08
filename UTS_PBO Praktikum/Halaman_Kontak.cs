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
    public partial class Halaman_Kontak : Form
    {
        public Halaman_Kontak()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Login homepage = new Login();

            homepage.Show();

            this.Hide();
        }

        private void ButtonAddFasilitasGym_Click(object sender, EventArgs e)
        {
            Addkontak addkontak = new Addkontak(this);

            addkontak.Show();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (DataGridView_FasilitasGym.SelectedRows.Count > 0)
            {
                var row = DataGridView_FasilitasGym.SelectedRows[0];
                int idkontak = Convert.ToInt32(row.Cells["id_fasilitas_gym"].Value);

                string namaorang = row.Cells["nama orang"].Value.ToString();
                string emailorang = row.Cells["email_orang"].Value.ToString();
                string notlp = row.Cells["no_tlp"].Value.ToString();

                ChangeKontak changekontak = new ChangeKontak(idkontak, namaorang, emailorang, notlp, this);
                changekontak.Show();
            }
            else
            {
                MessageBox.Show("Silakan pilih kontak yang ingin diubah.");
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridView_FasilitasGym.SelectedRows.Count > 0)
            {
                var row = DataGridView_FasilitasGym.SelectedRows[0];
                int idFasilitas = Convert.ToInt32(row.Cells["id_fasilitas_gym"].Value);

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus kontak ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CRUD_Kontak.DeleteMahasiswa(idFasilitas);

                        LoadDataKontak();
                        MessageBox.Show("kontak berhasil dihapus.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih kontak yang ingin dihapus.");
            }
        }

        private void FasilitasGym_Load(object sender, EventArgs e)
        {
            LoadDataKontak();
        }

        public void LoadDataKontak()
        {
            try
            {
                DataTable data = CRUD_Kontak.All();
                DataGridView_FasilitasGym.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


    }
}
