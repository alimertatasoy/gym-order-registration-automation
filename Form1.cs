using System.Data.SQLite;

namespace sporSalon
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=database.db;Version=3;";
        public Form1()
        {
            InitializeComponent();
            LoadPricesFromDatabase(); //Fiyatlarý güncelle
            LoadPeopleFromDatabase(); // Kiþileri yükle
            label3.Hide();
        }

        double toplamFiyat = 0;
        //Buradaki deðiþkenler veri tabanýndan alýancak urunler tablosundan
        double kucukSu;
        double buyukSu;
        double proteinToz;
        double karbToz;
        double bcaa;
        double tavukPilav;
        double birAy;
        double ucAy;
        double altiAy;
        double senelik;
        private void LoadPricesFromDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM urunler";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string urunAdi = reader["urunAdi"].ToString();
                            double fiyat = Convert.ToDouble(reader["fiyat"]);

                            switch (urunAdi)
                            {
                                case "kucukSu":
                                    kucukSu = fiyat;
                                    break;
                                case "buyukSu":
                                    buyukSu = fiyat;
                                    break;
                                case "proteinToz":
                                    proteinToz = fiyat;
                                    break;
                                case "karbonToz":
                                    karbToz = fiyat;
                                    break;
                                case "bcaa":
                                    bcaa = fiyat;
                                    break;
                                case "tavukPilav":
                                    tavukPilav = fiyat;
                                    break;
                                case "birAy":
                                    birAy = fiyat;
                                    break;
                                case "ucAy":
                                    ucAy = fiyat;
                                    break;
                                case "altiAy":
                                    altiAy = fiyat;
                                    break;
                                case "senelik":
                                    senelik = fiyat;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void LoadPeopleFromDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT isim, soyisim FROM kisiler";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string isim = reader["isim"].ToString();
                            string soyisim = reader["soyisim"].ToString();

                            // Kiþiyi ComboBox'a ekle
                            comboBox1.Items.Add(isim + " " + soyisim);
                        }
                    }
                }
            }
        }

        //Bu Kýsým Ürün Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Küçük Su --> " + kucukSu + " TL");
            toplamFiyat = toplamFiyat + kucukSu;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Büyük Su --> " + buyukSu + " TL");
            toplamFiyat = toplamFiyat + buyukSu;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Protein Tozu --> " + proteinToz + " TL");
            toplamFiyat = toplamFiyat + proteinToz;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Karbonhidrat Tozu --> " + karbToz + " TL");
            toplamFiyat = toplamFiyat + karbToz;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("BCAA --> " + bcaa + " TL");
            toplamFiyat = toplamFiyat + bcaa;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tavuk Pilav --> " + tavukPilav + " TL");
            toplamFiyat = toplamFiyat + tavukPilav;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1 Ay üye --> " + birAy + " TL");
            toplamFiyat = toplamFiyat + birAy;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("3 Ay üye --> " + ucAy + " TL");
            toplamFiyat = toplamFiyat + ucAy;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("6 Ay üye --> " + altiAy + " TL");
            toplamFiyat = toplamFiyat + altiAy;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1 sene üye --> " + senelik + " TL");
            toplamFiyat = toplamFiyat + senelik;
            label3.Text = toplamFiyat.ToString("0.00") + " TL";
            label3.Show();
        }

        //Bu kýsým Siparis gönderme islemi
        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kiþi seçiniz.");
                return;
            }

            // Seçili kiþiyi al
            string seciliKisi = comboBox1.SelectedItem.ToString();

            // Ürünleri ve tarihi ListBox'a ekle
            foreach (var item in listBox1.Items)
            {
                string urunAdi = item.ToString().Substring(0, item.ToString().IndexOf("-->") - 1).Trim();
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO siparisler (kisi, urun, tarih) VALUES (@kisi, @urun, @tarih)";
                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        DateTime now = DateTime.Now;
                        string tarih = now.ToString("yyyy-MM-dd"); // Yalnýzca tarih kýsmýný al
                        string saat = now.ToString("HH:mm"); // Sadece saat ve dakika kýsmýný al
                        string tarihVeSaat = tarih + " " + saat; // Tarih ve saat bilgisini birleþtir
                        command.Parameters.AddWithValue("@kisi", seciliKisi);
                        command.Parameters.AddWithValue("@urun", urunAdi);
                        command.Parameters.AddWithValue("@tarih", tarihVeSaat); ; // Þu anki tarih ve saat
                        command.ExecuteNonQuery();
                    }
                }
            }
            listBox1.Items.Clear();
            comboBox1.Text = " ";
            MessageBox.Show("Sipariþler baþarýyla kaydedildi.");
        }
        // Bu kýsým Silme Butonu
        private void button12_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Öðe seçiniz.");
            }
            else
            {
                // Öðenin fiyatýný alýp listeden ve toplam fiyattan çýkar
                string seciliUrun = listBox1.SelectedItem.ToString();
                double urunFiyati = double.Parse(seciliUrun.Substring(seciliUrun.LastIndexOf(">") + 2, seciliUrun.LastIndexOf("TL") - seciliUrun.LastIndexOf(">") - 2));
                toplamFiyat -= urunFiyati;

                listBox1.Items.Remove(listBox1.SelectedItem);
                label3.Text = toplamFiyat.ToString("0.00") + " TL"; // Toplam fiyatý güncelle
            }
        }
        // Yönetici Paneli butonu
        private void button13_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

    }
}