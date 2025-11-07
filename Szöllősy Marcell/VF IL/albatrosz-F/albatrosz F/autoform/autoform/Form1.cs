using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace autoform
{
    public partial class Form1 : Form
    {
        private List<Auto> autok = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Autók";
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV fájlok|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    autok = Auto.BetoltFajlbol(ofd.FileName);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = autok;
                    listBoxEredmeny.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a fájl betöltésekor:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            listBoxEredmeny.Items.Clear();

            if (int.TryParse(txtEv.Text, out int keresettEv))
            {
                var eredmenyek = autok
                    .Where(a => a.Evjarat == keresettEv)
                    .Select(a => $"{a.Marka} {a.Modell}")
                    .ToList();

                if (eredmenyek.Count > 0)
                {
                    foreach (var auto in eredmenyek)
                    {
                        listBoxEredmeny.Items.Add(auto);
                    }
                }
                else
                {
                    MessageBox.Show("Nem található autó a megadott évben.", "Nincs találat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kérlek adj meg egy érvényes évszámot!", "Hibás adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            var valasz = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés megerõsítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
