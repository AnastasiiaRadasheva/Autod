using Autod.Data;
using Microsoft.EntityFrameworkCore;

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

        }

        private void LaeOmanikud()
        {
            var data = _db.Owners
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
