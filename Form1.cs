using Autod.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
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
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo(); LaeSchedule();

        }
        public void LaeSchedule()
        {

            var data = _db.Schedules
        .Include(s => s.Car)
        .Include(cs => cs.Service)
        .Include(cs => cs.Worker)

        .Select(s => new
        {
            s.Id,
            s.StartTime,
            s.EndTime,
            Worker = s.Worker.FullName,
            Service = s.Service.Name,
            CarBrand = s.Car.Brand,
            CarRegNum = s.Car.RegistrationNumber
        })
        .ToList();

            dataGridView5.DataSource = data;

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
                int id = GetSelectedOwnerId();

                var owner = _db.Owners
                    .Include(o => o.Cars)
                    .FirstOrDefault(o => o.Id == id);

                if (owner == null)
                {
                    MessageBox.Show("Omanikku ei leitud.");
                    return;
                }

                if (owner.Cars != null && owner.Cars.Any())
                {
                    _db.Cars.RemoveRange(owner.Cars);
                }
                _db.Owners.Remove(owner);
                _db.SaveChanges();
                LaeOmanikud();
                MessageBox.Show("Omanik kustutatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo(); LaeSchedule();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int GetSelectedOwnerId()
        {
            if (dataGridViewOmanik.CurrentRow == null)
                throw new Exception("Palun vali omanik tabelist.");

            var obj = dataGridViewOmanik.CurrentRow.DataBoundItem;

            int id = (int)obj.GetType().GetProperty("Id").GetValue(obj);

            return id;
        }

        private void uuslisamine(int umber)
        {
            var servevis = "";

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
            var services = _db.Services
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Price
                })
                .ToList();

            dataGridView3.DataSource = services;
            if (dataGridView3.Columns["Id"] != null)
                dataGridView3.Columns["Id"].Visible = false;
        }

        private int GetSelectedServiceId()
        {
            if (dataGridView3.CurrentRow == null)
                throw new Exception("Palun vali hooldus tabelist.");
            var obj = dataGridView3.CurrentRow.DataBoundItem;
            int id = (int)obj.GetType().GetProperty("Id").GetValue(obj);

            return id;
        }



        private void LaeCarService()
        {
            var carServices = _db.CarServices
                .Include(cs => cs.Car)
                .Include(cs => cs.Service)
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

                    // Обновляем список автомобилей в listBoxAuto
                    LaeListBoxAuto(ownerId);


                    MessageBox.Show("Valitud autod on lisatud omanikule!");
                }
            }
        }


        private void LaeListBoxAuto(int ownerId)
        {
            var cars = _db.Cars
                .Where(c => c.OwnerId == ownerId)
                .OrderByDescending(c => c.Id)
                .Take(5)
                .Select(c => $"{c.Brand} {c.Model} ({c.RegistrationNumber})")
                .ToList();

            listBoxAuto.DataSource = cars;
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

        private void LaeAutoCombo()
        {
            var auto = _db.Cars

                .Select(o => new
                {
                    o.Id,
                    o.RegistrationNumber
                })
                .ToList();

            teenAUTO.DataSource = auto;
            teenAUTO.DisplayMember = "RegistrationNumber";
            teenAUTO.ValueMember = "Id";
        }
        private void LaeHooldusCombo()
        {
            var owners = _db.Services

                .Select(o => new
                {
                    o.Id,
                    o.Name
                })
                .ToList();

            teenHOOLD.DataSource = owners;
            teenHOOLD.DisplayMember = "Name";
            teenHOOLD.ValueMember = "Id";
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

            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo(); LaeSchedule();

            MessageBox.Show("Auto lisatud!");
        }

        private void UpdateAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali auto tabelist.");
                return;
            }

            int id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

            var car = _db.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                MessageBox.Show("Autot ei leitud.");
                return;
            }
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

            car.Brand = textBoxMARK.Text;
            car.Model = textBoxMODEL.Text;
            car.RegistrationNumber = textBoxRegNum.Text;
            car.OwnerId = (int)comboBoxOmanik.SelectedValue;

            _db.SaveChanges();

            LaeAutod();

            MessageBox.Show("Auto edukalt uuendatud!");
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo(); LaeSchedule();
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
                .Include(c => c.CarServices)
                .FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                MessageBox.Show("Autot ei leitud.");
                return;
            }
            if (car.CarServices != null && car.CarServices.Any())
            {
                _db.CarServices.RemoveRange(car.CarServices);
            }

            _db.Cars.Remove(car);
            _db.SaveChanges();

            LaeAutod();

            MessageBox.Show("Auto kustutatud!");
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo(); LaeSchedule();
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

        private void lisaHOLD_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NimiHOLD.Text))
            {
                MessageBox.Show("Palun sisesta hoolduse nimi.");
                return;
            }
            if (!float.TryParse(hindHOLD.Text, out float price))
            {
                MessageBox.Show("Palun sisesta korrektne hind (number).");
                return;
            }

            var service = new Service
            {
                Name = NimiHOLD.Text,
                Price = price
            };

            _db.Services.Add(service);
            _db.SaveChanges();
            LaeService(); LaeHooldusCombo();

            MessageBox.Show("Hooldus edukalt lisatud!");
        }

        private void uuendHOLD_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedServiceId();

                var service = _db.Services.FirstOrDefault(s => s.Id == id);
                if (service == null)
                {
                    MessageBox.Show("Hooldust ei leitud.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(NimiHOLD.Text))
                {
                    MessageBox.Show("Palun sisesta hoolduse nimi.");
                    return;
                }

                if (!float.TryParse(hindHOLD.Text, out float hind))
                {
                    MessageBox.Show("Hind peab olema number.");
                    return;
                }
                service.Name = NimiHOLD.Text;
                service.Price = hind;

                _db.SaveChanges();
                LaeService();
                MessageBox.Show("Hooldus edukalt uuendatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo();
        }


        private void kustHOLD_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedServiceId();

                var service = _db.Services
                    .Include(s => s.CarServices)
                    .FirstOrDefault(s => s.Id == id);

                if (service == null)
                {
                    MessageBox.Show("Hooldust ei leitud.");
                    return;
                }
                if (service.CarServices != null && service.CarServices.Any())
                {
                    _db.CarServices.RemoveRange(service.CarServices);
                }

                _db.Services.Remove(service);
                _db.SaveChanges();
                LaeService();
                MessageBox.Show("Hooldus kustutatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo();
        }


        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView3.Rows[e.RowIndex];

            NimiHOLD.Text = row.Cells["Name"].Value?.ToString();
            hindHOLD.Text = row.Cells["Price"].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedOwnerId();

                var owner = _db.Owners.FirstOrDefault(o => o.Id == id);
                if (owner == null)
                {
                    MessageBox.Show("Omanikku ei leitud.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textlisa.Text) || string.IsNullOrWhiteSpace(texttelefon.Text))
                {
                    MessageBox.Show("Palun täida kõik väljad.");
                    return;
                }

                owner.FullName = textlisa.Text;
                owner.Phone = texttelefon.Text;

                _db.SaveChanges();
                LaeOmanikud();
                MessageBox.Show("Omanik uuendatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo(); LaeSchedule();
        }

        private void dataGridViewOmanik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewOmanik.Rows[e.RowIndex];
            textlisa.Text = row.Cells["FullName"].Value?.ToString();
            texttelefon.Text = row.Cells["Phone"].Value?.ToString();
        }

        private void uuendTEEN_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedServiceId();

                var service = _db.Services.FirstOrDefault(s => s.Id == id);
                if (service == null)
                {
                    MessageBox.Show("Hooldust ei leitud.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(NimiHOLD.Text))
                {
                    MessageBox.Show("Palun sisesta hoolduse nimi.");
                    return;
                }

                if (!float.TryParse(hindHOLD.Text, out float hind))
                {
                    MessageBox.Show("Hind peab olema number.");
                    return;
                }
                service.Name = NimiHOLD.Text;
                service.Price = hind;

                _db.SaveChanges();
                LaeService();
                MessageBox.Show("Hooldus edukalt uuendatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo();
        }

        private void lisaTEEN_Click(object sender, EventArgs e)
        {
            try
            {
                if (teenAUTO.SelectedValue == null || teenHOOLD.SelectedValue == null)
                {
                    MessageBox.Show("Palun vali auto ja hooldus.");
                    return;
                }

                if (!DateTime.TryParse(teenKUUPAEV.Text, out DateTime kuup))
                {
                    MessageBox.Show("Palun sisesta korrektne kuupäev.");
                    return;
                }

                if (!int.TryParse(teenKIRJ.Text, out int mileage))
                {
                    MessageBox.Show("Palun sisesta korrektne läbisõit.");
                    return;
                }

                var carService = new CarService
                {
                    CarId = (int)teenAUTO.SelectedValue,
                    ServiceId = (int)teenHOOLD.SelectedValue,
                    DateOfService = kuup,
                    Mileage = mileage
                };

                _db.CarServices.Add(carService);
                _db.SaveChanges();

                LaeCarService();
                MessageBox.Show("Teenindus edukalt lisatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kustTEEN_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedServiceId();

                var service = _db.Services
                    .Include(s => s.CarServices)
                    .FirstOrDefault(s => s.Id == id);

                if (service == null)
                {
                    MessageBox.Show("Hooldust ei leitud.");
                    return;
                }
                if (service.CarServices != null && service.CarServices.Any())
                {
                    _db.CarServices.RemoveRange(service.CarServices);
                }

                _db.Services.Remove(service);
                _db.SaveChanges();
                LaeService();
                MessageBox.Show("Hooldus kustutatud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo();
        }


        private int GetSelectedCarServiceId()
        {
            if (dataGridView4.CurrentRow == null)
                throw new Exception("Palun vali teenindus tabelist.");

            var obj = dataGridView4.CurrentRow.DataBoundItem;


            int id = (int)obj.GetType().GetProperty("Id").GetValue(obj);
            return id;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form = new Form3(this, _db);
            form.Show();
            LaeSchedule();
            LaeOmanikud();
            LaeAutod();
            LaeService();
            LaeCarService();
            LaeOmanikudCombo(); LaeHooldusCombo(); LaeAutoCombo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись из расписания.");
                return;
            }

            int scheduleId = (int)dataGridView5.SelectedRows[0].Cells["Id"].Value;
            var form = new Form3(this, _db, scheduleId); // Передаем Id
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись из расписания.");
                return;
            }

            int scheduleId = (int)dataGridView5.SelectedRows[0].Cells["Id"].Value;

            var schedule = _db.Schedules.FirstOrDefault(s => s.Id == scheduleId);

            if (schedule == null)
            {
                MessageBox.Show("Запись не найдена.");
                return;
            }

            _db.Schedules.Remove(schedule);
            _db.SaveChanges();

            LaeSchedule();
            MessageBox.Show("Запись успешно удалена!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool _keelLaetud = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            _keelLaetud = false;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Eesti");
            comboBox1.Items.Add("English");
            comboBox1.SelectedItem = "Eesti";

            _keelLaetud = true;

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);

            var res = new ComponentResourceManager(typeof(Form1));

            ApplyResourcesToControl(this, res);
            res.ApplyResources(this, "$Form1");   // vormi pealkiri
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_keelLaetud)
                return;

            if (comboBox1.SelectedItem.ToString() == "English")
                ChangeLanguage("en-US");
            else
                ChangeLanguage("et-EE");
        }




        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textOTS_TextChanged(object sender, EventArgs e)
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
