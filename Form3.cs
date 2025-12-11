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
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

            DateTime start = startPicker.Value;
            if (start < DateTime.Now.Date)
            {
                MessageBox.Show("Дата должна быть сегодня или в будущем!");
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
            
        }
    }
}
