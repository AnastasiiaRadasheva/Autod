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
        private readonly AutoDbContext _db;  // Declare _db as a private field

        // Constructor that accepts AutoDbContext
        public Form2(AutoDbContext db)
        {
            InitializeComponent();
            _db = db;  // Store the passed AutoDbContext instance
            PopulateCheckedListBox();  // Populate the CheckedListBox with car data
        }
        private void PopulateCheckedListBox()
        {
            var cars = _db.Cars
                .Select(c => new
                {
                    c.Id,
                    DisplayText = $"{c.Brand}/{c.RegistrationNumber}"
                })
                .ToList();

            // Clear any existing items in the CheckedListBox
            checkedListBoxAutod.Items.Clear();

            // Add each car to the CheckedListBox
            foreach (var car in cars)
            {
                checkedListBoxAutod.Items.Add(new { car.Id, car.DisplayText });
            }
        }

        // This method will return the selected cars' DisplayText (Brand/Registration Number)
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
    }
}
