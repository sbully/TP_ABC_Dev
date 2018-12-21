using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Recherche_Ville_chargement_CSV
{
    public partial class Demarrage : Form
    {
        List<Ville> listVilleFrançaise = new List<Ville>();
        List<Ville> listVilleFrançaise2 = new List<Ville>();
        ReadSaveCSV readWrite = new ReadSaveCSV();
        string path = "..\\Save\\testCSV.csv";

        
        public Demarrage()
        {
            InitializeComponent();
            listVilleFrançaise.Add(new Ville("39570","CONLIEGE"));
            listVilleFrançaise.Add(new Ville("39570", "conliège"));
            listVilleFrançaise.Add(new Ville("39210", "SAINTE AGNES"));
            listVilleFrançaise.Add(new Ville("39000", "LONS LE SAUNIER"));
            listVilleFrançaise.Add(new Ville("39100", "DOLE"));
            listVilleFrançaise.Add(new Ville("39200", "SAINT CLAUDE"));
        }

        private void buttonWriteCsv_Click(object sender, EventArgs e)
        {

            readWrite.Write_CSV<Ville>(path,listVilleFrançaise);
        }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            path = "..\\Save\\lapostel_mod.csv";
            listVilleFrançaise2 = readWrite.Read_CSV<Ville>(path);
            listVilleFrançaise2 = listVilleFrançaise2.FindAll(x=>x.CodePostal == textBoxCodePostal.Text).ToList();
            comboBoxVille.DataSource = listVilleFrançaise2;
            comboBoxVille.Text = null;
            listVilleFrançaise2.Max(x => x.CodePostal);

        }
    }
}
