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
        private int? _editScheduleId = null;

        public Form3(Form1 mainForm, AutoDbContext db, int? scheduleId = null)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _db = db;
            _editScheduleId = scheduleId;

            LaeTeenCombo();
            LaeAutoCombo();
            LaeWorkerCombo();
            startPicker.MinDate = DateTime.Today;
            timePicker.MinDate = DateTime.Now;

            if (_editScheduleId.HasValue)
                LaeScheduleData(_editScheduleId.Value);
        }

        private void LaeScheduleData(int scheduleId)
        {
            var schedule = _db.Schedules
                .Include(s => s.Car)
                .Include(s => s.Service)
                .Include(s => s.Worker)
                .FirstOrDefault(s => s.Id == scheduleId);

            if (schedule != null)
            {
                autoCombo.SelectedValue = schedule.CarId;
                serviceCombo.SelectedValue = schedule.ServiceId;
                workCOMBO.SelectedValue = schedule.WorkerId;
                startPicker.Value = schedule.StartTime.Date;
                timePicker.Value = schedule.StartTime;
                durationUpDown.Value = (decimal)(schedule.EndTime - schedule.StartTime).TotalHours;
            }
        }
        private AutoDbContext _db;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
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
        private void LaeWorkerCombo()
        {
            var owners = _db.Workers

                .Select(o => new
                {
                    o.Id,
                    o.FullName
                })
                .ToList();

            workCOMBO.DataSource = owners;
            workCOMBO.DisplayMember = "FullName";
            workCOMBO.ValueMember = "Id";
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

        private void ApplyLanguage()
        {
            var res = new ComponentResourceManager(this.GetType());
            ApplyResourcesToControl(this, res);
            res.ApplyResources(this, "$this");
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
            bool ShowError(string msg)
            {
                MessageBox.Show(msg);
                return false;
            }

            if (autoCombo.SelectedItem == null)
                if (!ShowError("Vali auto!")) return;

            if (serviceCombo.SelectedItem == null)
                if (!ShowError("Vali teenus!")) return;

            if (workCOMBO.SelectedItem == null)
                if (!ShowError("Vali töötaja!")) return;

            DateTime start = startPicker.Value.Date.Add(timePicker.Value.TimeOfDay);

            if (start < DateTime.Now)
                if (!ShowError("Aeg ei saa olla minevikus!")) return;

            int duration = (int)durationUpDown.Value;
            DateTime end = start.AddHours(duration);

            int workerId = (int)workCOMBO.SelectedValue;
            int carId = (int)autoCombo.SelectedValue;

            bool isWorkerBusy = _db.Schedules.Any(s =>
                s.WorkerId == workerId &&
                (!_editScheduleId.HasValue || s.Id != _editScheduleId.Value) &&
                ((start >= s.StartTime && start < s.EndTime) ||
                 (end > s.StartTime && end <= s.EndTime) ||
                 (start <= s.StartTime && end >= s.EndTime))
            );

            if (isWorkerBusy)
                if (!ShowError("See töötaja on valitud ajal juba hõivatud!")) return;

            bool isCarBusy = _db.Schedules.Any(s =>
                s.CarId == carId &&
                (!_editScheduleId.HasValue || s.Id != _editScheduleId.Value) &&
                ((start >= s.StartTime && start < s.EndTime) ||
                 (end > s.StartTime && end <= s.EndTime) ||
                 (start <= s.StartTime && end >= s.EndTime))
            );

            if (isCarBusy)
                if (!ShowError("See auto on valitud ajal juba hõivatud!")) return;

            if (_editScheduleId.HasValue)
            {
                var schedule = _db.Schedules.FirstOrDefault(s => s.Id == _editScheduleId.Value);
                if (schedule != null)
                {
                    schedule.StartTime = start;
                    schedule.EndTime = end;
                    schedule.CarId = carId;
                    schedule.ServiceId = (int)serviceCombo.SelectedValue;
                    schedule.WorkerId = workerId;

                    _db.SaveChanges();
                    MessageBox.Show("Kirje on uuendatud!");
                    _mainForm.LaeSchedule();
                    this.Close();
                }
            }
            else
            {
                var schedule = new Schedule
                {
                    StartTime = start,
                    EndTime = end,
                    CarId = carId,
                    ServiceId = (int)serviceCombo.SelectedValue,
                    WorkerId = workerId
                };

                _db.Schedules.Add(schedule);
                _db.SaveChanges();

                MessageBox.Show("Kirje on lisatud!");
                _mainForm.LaeSchedule();
                this.Close();
            }
        }

        private void workCOMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}