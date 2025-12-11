using Autod.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Autod
{
    public partial class Form3 : Form
    {
        private Form1 _mainForm;
        public Form3(Form1 mainForm, AutoDbContext db)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _db = db;


            LaeTeenCombo();
            LaeAutoCombo();
            startPicker.MinDate = DateTime.Today;
            timePicker.MinDate = DateTime.Now;
        }
        private AutoDbContext _db;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void LaeTeenCombo()
        {
            var owners = _db.Services

                .Select(o => new
                {
                    o.Id,
                    o.Name
                })
                .ToList();

            serviceCombo.DataSource = owners;
            serviceCombo.DisplayMember = "Name";
            serviceCombo.ValueMember = "Id";
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

            autoCombo.DataSource = auto;
            autoCombo.DisplayMember = "RegistrationNumber";
            autoCombo.ValueMember = "Id";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void formkoik_Click(object sender, EventArgs e)
        {
            if (autoCombo.SelectedItem == null)
            {
                MessageBox.Show("Выберите автомобиль!");
                return;
            }

            if (serviceCombo.SelectedItem == null)
            {
                MessageBox.Show("Выберите услугу!");
                return;
            }

            // дата
            DateTime date = startPicker.Value.Date;

            // время
            DateTime time = timePicker.Value;

            // объединяем дату и время
            DateTime start = date.Add(time.TimeOfDay);

            if (start < DateTime.Now)
            {
                MessageBox.Show("Нельзя выбрать время в прошлом!");
                return;
            }

            int duration = (int)durationUpDown.Value;
            DateTime end = start.AddHours(duration);

            var schedule = new Schedule
            {
                StartTime = start,
                EndTime = end,
                CarId = (int)autoCombo.SelectedValue,
                ServiceId = (int)serviceCombo.SelectedValue
            };

            _db.Schedules.Add(schedule);
            _db.SaveChanges();

            MessageBox.Show("Запись добавлена!");
            _mainForm.LaeSchedule();
        }

    }

}