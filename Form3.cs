using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autod.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Autod
{
    public partial class Form3 : Form
    {
        private readonly AutoDbContext _db;

        public Form3(AutoDbContext db)
        {
            InitializeComponent();
            _db = db;

            PopulateCheckedListBox();
        }

        private void PopulateCheckedListBox()
        {
            var services = _db.Services
                .Select(s => new
                {
                    s.Id,
                    DisplayText = $"{s.Name} ({s.Price}€)"
                })
                .ToList();

            checkedListBoxTeenus.Items.Clear();

            foreach (var s in services)
            {
                checkedListBoxTeenus.Items.Add(new { s.Id, s.DisplayText });
            }
        }

        public List<int> GetSelectedServices()
        {
            List<int> selectedIds = new List<int>();

            foreach (var item in checkedListBoxTeenus.CheckedItems)
            {
                var service = _db.Services.FirstOrDefault(s => s.Name == item.ToString());
                if (service != null)
                    selectedIds.Add(service.Id);
            }

            return selectedIds;
        }


        private void koikBTNteen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public int GetSelectedServiceCount()
        {
            return checkedListBoxTeenus.CheckedItems.Count;
        }

    }
}
