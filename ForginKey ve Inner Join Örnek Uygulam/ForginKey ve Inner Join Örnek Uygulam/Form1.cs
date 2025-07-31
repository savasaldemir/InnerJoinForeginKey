using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ForginKey_ve_Inner_Join_Örnek_Uygulam
{
    public partial class forginKey_Join_Alistirma : Form
    {
        
        public forginKey_Join_Alistirma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Join_Alistirma;Integrated Security=True");
        private void VerileriListele()
        {
            string sorgu = @"
    SELECT 
        a.id AS arac_id,
        a.plaka, a.marka, a.model, a.yil,
        m.musteri_ID,
        m.adi_soyadi,
        m.telefon
    FROM araclar a
    INNER JOIN musteri m ON a.musteri_ID = m.musteri_ID";

            using (SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Join_Alistirma;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtGrid_Bilgiler.DataSource = dt;
            }
        }

        private void forginKey_Join_Alistirma_Load(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void txt_Plaka_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM araclar WHERE araclar LIKE @plaka", baglanti))
            {
                adtr.SelectCommand.Parameters.AddWithValue("@arama", "%" + txt_Plaka.Text + "%");
                adtr.Fill(tablo);
            }
            dtGrid_Bilgiler.DataSource = tablo;
        }

        private void AraclariPlakayaGoreListele(string plaka)
        {
        }

        //private void txt_Plaka_TextChanged(object sender, EventArgs e)
        //{
        //}

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AdiSoyadi.Text) ||
                string.IsNullOrWhiteSpace(txt_Telefon.Text) ||
                string.IsNullOrWhiteSpace(txt_Plaka.Text) ||
                string.IsNullOrWhiteSpace(txt_Marka.Text) ||
                string.IsNullOrWhiteSpace(txt_Model.Text) ||
                string.IsNullOrWhiteSpace(txt_Yil.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                baglanti.Open();

                // 1️⃣ Önce müşteri ekle
                string musteriEkle = "INSERT INTO musteri (adi_soyadi, telefon) VALUES (@ad, @tel); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdMusteri = new SqlCommand(musteriEkle, baglanti);
                cmdMusteri.Parameters.AddWithValue("@ad", txt_AdiSoyadi.Text);
                cmdMusteri.Parameters.AddWithValue("@tel", txt_Telefon.Text);

                int musteriID = Convert.ToInt32(cmdMusteri.ExecuteScalar()); // Yeni müşteri_ID

                // 2️⃣ Şimdi aracı ekle
                string aracEkle = "INSERT INTO araclar (plaka, marka, model, yil, musteri_ID) VALUES (@plaka, @marka, @model, @yil, @musteriID)";
                SqlCommand cmdArac = new SqlCommand(aracEkle, baglanti);
                cmdArac.Parameters.AddWithValue("@plaka", txt_Plaka.Text);
                cmdArac.Parameters.AddWithValue("@marka", txt_Marka.Text);
                cmdArac.Parameters.AddWithValue("@model", txt_Model.Text);
                cmdArac.Parameters.AddWithValue("@yil", txt_Yil.Text);
                cmdArac.Parameters.AddWithValue("@musteriID", musteriID);

                cmdArac.ExecuteNonQuery();

                MessageBox.Show("Müşteri ve araç başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            VerileriListele();

            // Temizleme (isteğe bağlı)
            txt_Plaka.Clear();
            txt_Marka.Clear();
            txt_Model.Clear();
            txt_Yil.Clear();
            txt_AdiSoyadi.Clear();
            txt_Telefon.Clear();
            lbl_id.Text = "";
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string guncelle = "UPDATE musteri SET adi_soyadi=@adi_soyadi, telefon=@telefon WHERE musteri_ID=@id";
            SqlCommand cmd = new SqlCommand(guncelle, baglanti);
            cmd.Parameters.AddWithValue("@adi_soyadi", txt_AdiSoyadi.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_Telefon.Text);
            cmd.Parameters.AddWithValue("@id", lbl_id.Text); // lbl_id doğru ID'yi içeriyorsa

            try
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veriler Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            VerileriListele();
        }



        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_id.Text))
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçiniz.");
                return;
            }

            DialogResult onay = MessageBox.Show("Bu müşteriyi ve ilişkili araçlarını silmek istediğinize emin misiniz?",
                                                "Silme Onayı",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();

                    // 1️⃣ Önce araclar tablosundan sil
                    string aracSilSorgusu = "DELETE FROM araclar WHERE musteri_ID = @id";
                    SqlCommand aracSilKomut = new SqlCommand(aracSilSorgusu, baglanti);
                    aracSilKomut.Parameters.AddWithValue("@id", Convert.ToInt32(lbl_id.Text));
                    aracSilKomut.ExecuteNonQuery();

                    // 2️⃣ Sonra müşteri tablosundan sil
                    string musteriSilSorgusu = "DELETE FROM musteri WHERE musteri_ID = @id";
                    SqlCommand musteriSilKomut = new SqlCommand(musteriSilSorgusu, baglanti);
                    musteriSilKomut.Parameters.AddWithValue("@id", Convert.ToInt32(lbl_id.Text));
                    musteriSilKomut.ExecuteNonQuery();

                    MessageBox.Show("Müşteri ve ilgili araçlar silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                VerileriListele();

                // Temizleme işlemi (opsiyonel)
                txt_Plaka.Clear();
                txt_Marka.Clear();
                txt_Model.Clear();
                txt_Yil.Clear();
                txt_AdiSoyadi.Clear();
                txt_Telefon.Clear();
                lbl_id.Text = "";
            }
        }

        private void dtGrid_Bilgiler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //DataGrid özelliklerinden CellClik çift tıklanarak CellClik olayı aktif edildikten sonra kodlar buraya yazılmalı

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGrid_Bilgiler.Rows[e.RowIndex];

                // Diğer textbox doldurmaları
                txt_Plaka.Text = row.Cells["plaka"].Value.ToString();
                txt_Marka.Text = row.Cells["marka"].Value.ToString();
                txt_Model.Text = row.Cells["model"].Value.ToString();
                txt_Yil.Text = row.Cells["yil"].Value.ToString();
                txt_AdiSoyadi.Text = row.Cells["adi_soyadi"].Value.ToString();
                txt_Telefon.Text = row.Cells["telefon"].Value.ToString();

                // 👇 Burada ID’yi al
                lbl_id.Text = row.Cells["musteri_ID"].Value.ToString(); // doğru sütun adını kullandığından emin ol

                
            }
        }
    }
}
