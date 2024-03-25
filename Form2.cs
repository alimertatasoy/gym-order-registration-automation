using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sporSalon
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=database.db;Version=3;";
        public Form2()
        {
            InitializeComponent();
            LoadPeopleFromDatabase(); // Kişileri yükle
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

                            // Kişiyi ComboBox'a ekle
                            comboBox1.Items.Add(isim + " " + soyisim);
                        }
                    }
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //Bu kısım kişi sipariş kısmı
        private void button3_Click(object sender, EventArgs e)
        {
            // Seçilen kişiyi al
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPerson = comboBox1.SelectedItem.ToString();

            // Siparişleri bul
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT urun, tarih FROM siparisler WHERE kisi = @kisi";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kisi", selectedPerson);
                    using (var reader = command.ExecuteReader())
                    {
                        // ListBox içeriğini temizle
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            string urun = reader["urun"].ToString();
                            string tarih = reader["tarih"].ToString();

                            // Siparişi ListBox'a ekle
                            listBox1.Items.Add(urun + " - " + tarih);
                        }
                    }
                }
            }
        }



        //Bugünün Tarihini ayarlama
        private void button1_Click(object sender, EventArgs e)
        {
            // Bugünün tarihini al
            DateTime bugun = DateTime.Today;

            // Tarihi MaskedTextBox'a gönder
            maskedTextBox1.Text = bugun.ToString("yyyy/MM/dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MaskedTextBox'tan tarihi al
            DateTime secilenTarih;
            if (!DateTime.TryParse(maskedTextBox1.Text, out secilenTarih))
            {
                MessageBox.Show("Geçersiz tarih formatı!");
                return;
            }

            // Seçilen tarihte yapılan siparişleri bul
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT kisi, urun FROM siparisler WHERE DATE(tarih) = DATE(@tarih)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tarih", secilenTarih.ToString("yyyy-MM-dd"));
                    using (var reader = command.ExecuteReader())
                    {
                        // ListBox içeriğini temizle
                        listBox2.Items.Clear();
                        while (reader.Read())
                        {
                            string kisi = reader["kisi"].ToString();
                            string urun = reader["urun"].ToString();

                            // Siparişi ListBox'a ekle
                            listBox2.Items.Add(kisi + " - " + urun);
                        }
                    }
                }
            }

        }







        private void CalculateDailyRevenue()
        {
            // Bugünün tarihini al
            DateTime today = DateTime.Today;

            // Günlük ciroyu hesapla
            double dailyRevenue = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT urun FROM siparisler WHERE DATE(tarih) = DATE(@tarih)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tarih", today.ToString("yyyy-MM-dd"));
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string urun = reader["urun"].ToString();
                            // Ürün fiyatını al
                            double urunFiyat = GetProductPrice(urun);
                            // Sipariş miktarını varsayılan olarak 1 kabul ederek hesapla
                            double miktar = 1;
                            // Toplam geliri arttır
                            dailyRevenue += urunFiyat * miktar;
                        }
                    }
                }
            }

            // Label'a günlük ciroyu yaz
            label14.Text = dailyRevenue.ToString("C");
        }

        private void CalculateMonthlyRevenue()
        {
            // Ayın başlangıç ve bitiş tarihlerini al
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            // Aylık ciroyu hesapla
            double monthlyRevenue = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT urun FROM siparisler WHERE DATE(tarih) BETWEEN DATE(@startDate) AND DATE(@endDate)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"));
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string urun = reader["urun"].ToString();
                            // Ürün fiyatını al
                            double urunFiyat = GetProductPrice(urun);
                            // Sipariş miktarını varsayılan olarak 1 kabul ederek hesapla
                            double miktar = 1;
                            // Toplam geliri arttır
                            monthlyRevenue += urunFiyat * miktar;
                        }
                    }
                }
            }

            // Label'a aylık ciroyu yaz
            label15.Text = monthlyRevenue.ToString("C");
        }

        private double GetProductPrice(string productName)
        {
            double price = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT fiyat FROM urunler WHERE urunAdi = @productName";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDouble(result);
                    }
                }
            }
            return price;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CalculateDailyRevenue();
            CalculateMonthlyRevenue();
        }
    }
}
