using Autod.Data;
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
    public partial class Form2 : Form
    {
        private readonly AutoDbContext _db;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(AutoDbContext db) : this()
        {
            _db = db;
            PopulateCheckedListBox();
        }
        private class CarListItem
        {
            public int Id { get; set; }
            public string DisplayText { get; set; }
        }

        private void PopulateCheckedListBox()
        {
            var cars = _db.Cars
                .Select(c => new CarListItem
                {
                    Id = c.Id,
                    DisplayText = $"{c.Brand}/{c.RegistrationNumber}"
                })
                .ToList();

            checkedListBoxAutod.DataSource = cars;
            checkedListBoxAutod.DisplayMember = nameof(CarListItem.DisplayText);
            checkedListBoxAutod.ValueMember = nameof(CarListItem.Id);
        }
        public List<string> GetSelectedCars()
        {
            var selectedCars = new List<string>();

            foreach (var selectedItem in checkedListBoxAutod.CheckedItems)
            {
                var car = selectedItem as dynamic;
                if (car != null)
                {
                    selectedCars.Add(car.DisplayText);
                }
            }

            return selectedCars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
       
        }
    }
}
