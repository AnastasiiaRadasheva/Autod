using Autod.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Autod
{
    public partial class Form1 : Form
    {
        private AutoDbContext _db;

        public Form1()
        {

            InitializeComponent();
            _db = new AutoDbContext();
            LaeOmanikud();
            LaeAutod();
            LaeService();

        }

        private void LaeOmanikud()
        {
            var data = _db.Owners
                .Include(o => o.Cars) // Подгружаем машины
                .Select(o => new
                {
                    o.Id,
                    o.FullName,
                    o.Phone,
                    CarCount = o.Cars.Count
                })
                .ToList();

            dataGridViewOmanik.DataSource = data;
        }


        private void KustutaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOmanik.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Palun valige kustutatav toode.",
                        "Viga",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string tooteNimetus = dataGridViewOmanik.SelectedRows[0]
                    .Cells["Toodenimetus"].Value?.ToString() ?? "valitud toode";

                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada toote: {tooteNimetus}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (vastus == DialogResult.Yes)
                {

                    int id = (int)dataGridViewOmanik.SelectedRows[0].Cells["Id"].Value;

                    //var toode = _db.Toodetabel.Find(id);

                    //if (toode != null)
                    //{
                    //    _db.Toodetabel.Remove(toode);
                    //    _db.SaveChanges();

                    //    LaeTooted();
                    //    PuhastaVorm();  
                    //}
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Viga kustutamisel: " + ex.Message,
                    "Viga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lisaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string nimi = textlisa.Text.Trim();
                string telefon = texttelefon.Text.Trim();

                if (string.IsNullOrWhiteSpace(nimi))
                {
                    MessageBox.Show("Palun sisestage omaniku nimi.");
                    return;
                }

                var uusOmanik = new Owner
                {
                    FullName = nimi,
                    Phone = telefon
                };

                _db.Owners.Add(uusOmanik);
                _db.SaveChanges();

                LaeOmanikud();

                textlisa.Clear();
                texttelefon.Clear();

                MessageBox.Show("Omanik lisatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga lisamisel: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void texttelefon_TextChanged(object sender, EventArgs e)
        {

        }




        private void comboBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaeService()
        {
            // Загружаем автомобили с владельцами
            var SERVISE = _db.Services;

            // Преобразуем данные в список анонимных объектов
            var carList = SERVISE.Select(c => new
            {

                c.Name,
                c.Price,

            }).ToList();

            // Привязываем данные к DataGridView2
            dataGridView3.DataSource = carList;
        }



        private void LaeAutod()
        {
            // Загружаем автомобили с владельцами
            var carsWithOwners = _db.Cars
                .Include(c => c.Owner)
                .Include(c => c.CarServices)
                .ThenInclude(cs => cs.Service)// Подгружаем владельцев
                .ToList();

            // Преобразуем данные в список анонимных объектов
            var carList = carsWithOwners.Select(c => new
            {
                c.Id,
                c.Brand,
                c.Model,
                c.RegistrationNumber,
                OwnerName = c.Owner.FullName,  // Имя владельца
                Services = string.Join(", ",
    c.CarServices
     .Where(cs => cs.Service != null)          // Только с ненулевым Service
     .Select(cs => cs.Service.Name))


            }).ToList();

            // Привязываем данные к DataGridView2
            dataGridView2.DataSource = carList;
        }



        private void AutoVali_Click(object sender, EventArgs e)
        {
            if (dataGridViewOmanik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige omaniku, kellele lisada autod.");
                return;
            }

            // Получаем выбранного владельца
            int ownerId = (int)dataGridViewOmanik.SelectedRows[0].Cells["Id"].Value;
            var owner = _db.Owners.Include(o => o.Cars).FirstOrDefault(o => o.Id == ownerId);

            if (owner == null)
            {
                MessageBox.Show("Valitud omanikut ei leitud!");
                return;
            }

            // Открываем форму выбора машин
            using (Form2 form2 = new Form2(_db))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    var selectedCarsDisplay = form2.GetSelectedCars();

                    foreach (var displayText in selectedCarsDisplay)
                    {
                        var parts = displayText.Split('/'); // Brand/RegistrationNumber
                        if (parts.Length == 2)
                        {
                            string brand = parts[0];
                            string regNum = parts[1];

                            var car = _db.Cars.FirstOrDefault(c => c.Brand == brand && c.RegistrationNumber == regNum);

                            if (car != null)
                            {
                                car.OwnerId = ownerId; // Связываем машину с владельцем
                            }
                        }
                    }

                    _db.SaveChanges(); // Сохраняем изменения в базе

                    // Обновляем таблицу владельцев и машин
                    LaeOmanikud();
                    LaeAutod();

                    MessageBox.Show("Valitud autod on lisatud omanikule!");
                }
            }
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uuendaBTN_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        //private void Shop_Load(object sender, EventArgs e)
        //{
        //    _keelLaetud = false;

        //    comboLanguage.Items.Clear();
        //    comboLanguage.Items.Add("Eesti");
        //    comboLanguage.Items.Add("English");

        //    string savedLangCode = Properties.Settings1.Default.UserLanguage;
        //    string displayLanguage = "Eesti";

        //    if (savedLangCode == "en-US")
        //        displayLanguage = "English";
        //    else
        //        displayLanguage = "Eesti";

        //    comboLanguage.SelectedItem = displayLanguage;

        //    _keelLaetud = true;
        //}

    }
}
