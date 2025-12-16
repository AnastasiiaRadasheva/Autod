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
        private AutoDbContext _db;
        private Form1 _mainForm;
        private int _scheduleId = 0;

        public Form3(Form1 mainForm, AutoDbContext db)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _db = db;

            LoadCombos();

            startPicker.MinDate = DateTime.Today;
            timePicker.MinDate = DateTime.Now;
        }
        public Form3(Form1 mainForm, AutoDbContext db, int scheduleId) : this(mainForm, db)
        {
            _scheduleId = scheduleId;
            LoadSchedule();
        }

        private void LoadCombos()
        {
            autoCombo.DataSource = _db.Cars.ToList();
            autoCombo.DisplayMember = "RegistrationNumber";
            autoCombo.ValueMember = "Id";

            serviceCombo.DataSource = _db.Services.ToList();
            serviceCombo.DisplayMember = "Name";
            serviceCombo.ValueMember = "Id";

            workCOMBO.DataSource = _db.Workers.ToList();
            workCOMBO.DisplayMember = "FullName";
            workCOMBO.ValueMember = "Id";
        }

        private void LoadSchedule()
        {
            var s = _db.Schedules.First(x => x.Id == _scheduleId);

            autoCombo.SelectedValue = s.CarId;
            serviceCombo.SelectedValue = s.ServiceId;
            workCOMBO.SelectedValue = s.WorkerId;

            startPicker.Value = s.StartTime.Date;
            timePicker.Value = s.StartTime;
            durationUpDown.Value =
                (decimal)(s.EndTime - s.StartTime).TotalHours;
        }

        private void workCOMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
   
        }



        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }

        private void formkoik_Click(object sender, EventArgs e)
        {
            if (autoCombo.SelectedItem == null ||
                serviceCombo.SelectedItem == null ||
                workCOMBO.SelectedItem == null)
            {
                MessageBox.Show("lisa koik");
                return;
            }

            DateTime start =
                startPicker.Value.Date +
                timePicker.Value.TimeOfDay;

            if (start < DateTime.Now)
            {
                MessageBox.Show("Aeg ei saa olla minevikus");
                return;
            }

            DateTime end = start.AddHours((double)durationUpDown.Value);

            int carId = (int)autoCombo.SelectedValue;
            bool carBusy = _db.Schedules.Any(x =>
                x.CarId == carId &&
                x.Id != _scheduleId && 
                x.StartTime < end &&
                x.EndTime > start
            );

            if (carBusy)
            {
                MessageBox.Show("Aeg on hõivatud");
                return;
            }

            Schedule s;

            if (_scheduleId == 0)
            {
                s = new Schedule();
                _db.Schedules.Add(s);
            }
            else
            {
                s = _db.Schedules.First(x => x.Id == _scheduleId);
            }

            s.StartTime = start;
            s.EndTime = end;
            s.CarId = carId;
            s.ServiceId = (int)serviceCombo.SelectedValue;
            s.WorkerId = (int)workCOMBO.SelectedValue;

            _db.SaveChanges();

            MessageBox.Show("Salvesta");
            _mainForm.LaeSchedule();
            Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}