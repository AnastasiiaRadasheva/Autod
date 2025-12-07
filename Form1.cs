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
            LaeCarService();
            LaeOmanikudCombo();

        }

        private void LaeOmanikud()
        {
            var data = _db.Owners
                .Include(o => o.Cars)
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
            var SERVISE = _db.Services;
            var carList = SERVISE.Select(c => new
            {

                c.Name,
                c.Price,

            }).ToList();
            dataGridView3.DataSource = carList;
        }



        private void LaeCarService()
        {
            var carServices = _db.CarServices
                .Include(cs => cs.Car)       // Загружаем машину
                .Include(cs => cs.Service)   // Загружаем услугу
                .ToList();

            var list = carServices.Select(cs => new
            {
                Auto = $"{cs.Car.Brand} {cs.Car.Model} ({cs.Car.RegistrationNumber})",
                Service = cs.Service.Name,
                Price = cs.Service.Price,
                Date = cs.DateOfService.ToShortDateString(),
                Mileage = cs.Mileage
            }).ToList();

            dataGridView4.DataSource = list;
        }


        private void LaeAutod()
        {
            var cars = _db.Cars
                .Include(c => c.Owner)
                .Include(c => c.CarServices)
                .ThenInclude(cs => cs.Service)
                .ToList();

            var carList = cars.Select(c => new
            {
                c.Id,
                c.Brand,
                c.Model,
                c.RegistrationNumber,
                OwnerName = c.Owner.FullName,

                Services = c.CarServices?.Count ?? 0

            })
            .ToList();

            dataGridView2.DataSource = carList;
        }




        private void AutoVali_Click(object sender, EventArgs e)
        {
            if (dataGridViewOmanik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige omaniku, kellele lisada autod.");
                return;
            }

            int ownerId = (int)dataGridViewOmanik.SelectedRows[0].Cells["Id"].Value;
            var owner = _db.Owners.Include(o => o.Cars).FirstOrDefault(o => o.Id == ownerId);

            if (owner == null)
            {
                MessageBox.Show("Valitud omanikut ei leitud!");
                return;
            }


            using (Form2 form2 = new Form2(_db))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    var selectedCarsDisplay = form2.GetSelectedCars();

                    foreach (var displayText in selectedCarsDisplay)
                    {
                        var parts = displayText.Split('/');
                        if (parts.Length == 2)
                        {
                            string brand = parts[0];
                            string regNum = parts[1];

                            var car = _db.Cars.FirstOrDefault(c => c.Brand == brand && c.RegistrationNumber == regNum);

                            if (car != null)
                            {
                                car.OwnerId = ownerId;
                            }
                        }
                    }

                    _db.SaveChanges();

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxOmanik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LaeOmanikudCombo()
        {
            var owners = _db.Owners

                .Select(o => new
                {
                    o.Id,
                    o.FullName
                })
                .ToList();

            comboBoxOmanik.DataSource = owners;
            comboBoxOmanik.DisplayMember = "FullName";
            comboBoxOmanik.ValueMember = "Id";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Dictionary<int, int> _carServiceTemp = new Dictionary<int, int>();

        private void valiteen_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige auto.");
                return;
            }

            int carId = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

            using (Form3 form3 = new Form3(_db))
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    var selectedServiceIds = form3.GetSelectedServices(); // Список Id выбранных услуг

                    foreach (var serviceId in selectedServiceIds)
                    {
                        var carService = new CarService
                        {
                            CarId = carId,
                            ServiceId = serviceId,
                            DateOfService = DateTime.Now,
                            Mileage = 0
                        };
                        _db.CarServices.Add(carService);
                    }

                    _db.SaveChanges(); // Сохраняем в базу

                    LaeAutod();
                }
            }
        }
        private void LisaAuto_Click(object sender, EventArgs e)
        {
            if (comboBoxOmanik.SelectedValue == null)
            {
                MessageBox.Show("Palun vali omanik.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxMARK.Text) ||
                string.IsNullOrWhiteSpace(textBoxMODEL.Text) ||
                string.IsNullOrWhiteSpace(textBoxRegNum.Text))
            {
                MessageBox.Show("Palun täida kõik väljad.");
                return;
            }

            int ownerId = (int)comboBoxOmanik.SelectedValue;

            var car = new Car
            {
                Brand = textBoxMARK.Text,
                Model = textBoxMODEL.Text,
                RegistrationNumber = textBoxRegNum.Text,
                OwnerId = ownerId
            };

            _db.Cars.Add(car);
            _db.SaveChanges();

            LaeAutod();

            MessageBox.Show("Auto lisatud!");
        }

        private void UpdateAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali auto tabelist.");
                return;
            }

            // Võtame valitud auto ID
            int id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

            // Otsime andmebaasist
            var car = _db.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                MessageBox.Show("Autot ei leitud.");
                return;
            }

            // Kontrollime väljad
            if (string.IsNullOrWhiteSpace(textBoxMARK.Text) ||
                string.IsNullOrWhiteSpace(textBoxMODEL.Text) ||
                string.IsNullOrWhiteSpace(textBoxRegNum.Text))
            {
                MessageBox.Show("Palun täida kõik väljad.");
                return;
            }

            if (comboBoxOmanik.SelectedValue == null)
            {
                MessageBox.Show("Palun vali omanik.");
                return;
            }

            // Uuendame väärtused
            car.Brand = textBoxMARK.Text;
            car.Model = textBoxMODEL.Text;
            car.RegistrationNumber = textBoxRegNum.Text;
            car.OwnerId = (int)comboBoxOmanik.SelectedValue;

            _db.SaveChanges();

            LaeAutod();

            MessageBox.Show("Auto edukalt uuendatud!");
        }

        private void KustutaAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali auto tabelist.");
                return;
            }

            int id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

            var car = _db.Cars
                .Include(c => c.CarServices)  // kui autol on teenused, peame need eemaldama
                .FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                MessageBox.Show("Autot ei leitud.");
                return;
            }

            // Kui autol on teenused – kustutame need esmalt
            if (car.CarServices != null && car.CarServices.Any())
            {
                _db.CarServices.RemoveRange(car.CarServices);
            }

            _db.Cars.Remove(car);
            _db.SaveChanges();

            LaeAutod();

            MessageBox.Show("Auto kustutatud!");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            textBoxMARK.Text = row.Cells["Brand"].Value?.ToString();
            textBoxMODEL.Text = row.Cells["Model"].Value?.ToString();
            textBoxRegNum.Text = row.Cells["RegistrationNumber"].Value?.ToString();


            comboBoxOmanik.Text = row.Cells["OwnerName"].Value?.ToString();
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
