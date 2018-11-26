using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Auto.view
{
    public partial class MainMenu : Form
    {
        controller.AutoRegisterHandler autoRegisterHandler;
        DatabaseControllerService.AutoTesti DbAuto = new DatabaseControllerService.AutoTesti();

        int valittuID=0;
        List<DatabaseControllerService.AutonMerkki> AutonMerkit;
        List<DatabaseControllerService.AutonMalli> AutonMallit;
        List<DatabaseControllerService.Polttoaine> Polttoaineet;
        List<DatabaseControllerService.Vari> Varit;
       
     
        
        public MainMenu()
        {
            autoRegisterHandler = new controller.AutoRegisterHandler();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            AutonMerkit = autoRegisterHandler.getAllAutoMakers();
            comboBox2.DisplayMember = "Merkki1";
            comboBox2.ValueMember = "ID1";
            comboBox2.DataSource = AutonMerkit;
            AutonMallit = autoRegisterHandler.getAutoModels(1);
            comboBox1.DisplayMember = "Auton_mallin_nimi1";
            comboBox1.ValueMember = "ID1";
            comboBox1.DataSource = AutonMallit;
            Polttoaineet = autoRegisterHandler.getFuel();
            comboBox3.DisplayMember = "Polttoaineen_nimi1";
            comboBox3.ValueMember = "ID1";
            comboBox3.DataSource = Polttoaineet;
            Varit = autoRegisterHandler.getColor();
            comboBox4.DisplayMember = "AutonVari1";
            comboBox4.ValueMember = "ID1";
            comboBox4.DataSource = Varit;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoRegisterHandler.TestDatabaseConnection())
            {
                MessageBox.Show("Tietokantayhteys toimii");
            }
            else
            {
                MessageBox.Show("Tietokantayhteys ei toimi");
            }
        }
        
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            int MalliID = Convert.ToInt32(comboBox2.SelectedValue);
            AutonMallit = autoRegisterHandler.getAutoModels(MalliID);
            comboBox1.DisplayMember = "Auton_mallin_nimi1";
            comboBox1.ValueMember = "ID1";
            comboBox1.DataSource = AutonMallit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedValue = "";
            comboBox1.SelectedValue = "";
            comboBox3.SelectedValue = "";
            comboBox4.SelectedValue = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseControllerService.AutoTesti auto = new DatabaseControllerService.AutoTesti();
            try
            { 
            auto.Mittarilukema1 = int.Parse(textBox1.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("Mittarilukeman pitää olla numeroita");
                return;
            }
            try
            {
                auto.Moottorin_tilavuus1 = Decimal.Parse(textBox2.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("Moottorintilavuus pitää olla numeroita");
                return;
            }
            try
            {
                auto.Hinta1 = Decimal.Parse(textBox3.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("Hinta pitää olla numeroita");
                return;
            }
            auto.AutonMerkkiID1 = (int)comboBox2.SelectedValue;
            auto.AutonMalliID1 = (int)comboBox1.SelectedValue;
            auto.PolttoaineID1 = (int)comboBox3.SelectedValue;
            auto.VaritID1 = (int)comboBox4.SelectedValue;
            auto.Rekisteri_paivamaara1 = dateTimePicker1.Value;
            if (autoRegisterHandler.saveAuto(auto))
            {
                MessageBox.Show("Tallennus onnistui");
            }
            else
            {
                MessageBox.Show("Jokin meni vikaan");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseControllerService.AutoTesti auto = autoRegisterHandler.getSeuraavaAuto(valittuID);
            label9.Text = Convert.ToString(auto.ID1);
            valittuID = auto.ID1;
            textBox1.Text = Convert.ToString(auto.Mittarilukema1);
            textBox2.Text = Convert.ToString(auto.Moottorin_tilavuus1);
            textBox3.Text = Convert.ToString(auto.Hinta1);
            comboBox2.SelectedValue = auto.AutonMerkkiID1;
            comboBox1.SelectedValue = auto.AutonMalliID1;
            comboBox3.SelectedValue = auto.PolttoaineID1;
            comboBox4.SelectedValue = auto.VaritID1;
            try
            {
                dateTimePicker1.Value = auto.Rekisteri_paivamaara1;
            }
            catch (Exception virhe)
            {

            }
            if (auto.ID1 == 0)
            {
                auto = autoRegisterHandler.getEkaAuto();
                label9.Text = Convert.ToString(auto.ID1);
                valittuID = auto.ID1;
                textBox1.Text = Convert.ToString(auto.Mittarilukema1);
                textBox2.Text = Convert.ToString(auto.Moottorin_tilavuus1);
                textBox3.Text = Convert.ToString(auto.Hinta1);
                comboBox2.SelectedValue = auto.AutonMerkkiID1;
                comboBox1.SelectedValue = auto.AutonMalliID1;
                comboBox3.SelectedValue = auto.PolttoaineID1;
                comboBox4.SelectedValue = auto.VaritID1;
                try
                {
                    dateTimePicker1.Value = auto.Rekisteri_paivamaara1;
                }
                catch (Exception virhe)
                {

                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseControllerService.AutoTesti auto = autoRegisterHandler.getEdellinenAuto(valittuID);
            label9.Text = Convert.ToString(auto.ID1);
            valittuID = auto.ID1;
            textBox1.Text = Convert.ToString(auto.Mittarilukema1);
            textBox2.Text = Convert.ToString(auto.Moottorin_tilavuus1);
            textBox3.Text = Convert.ToString(auto.Hinta1);
            comboBox2.SelectedValue = auto.AutonMerkkiID1;
            comboBox1.SelectedValue = auto.AutonMalliID1;
            comboBox3.SelectedValue = auto.PolttoaineID1;
            comboBox4.SelectedValue = auto.VaritID1;
            try
            {
                dateTimePicker1.Value = auto.Rekisteri_paivamaara1;
            }
            catch (Exception virhe)
            {

            }
            if(auto.ID1 == 0)
            {
                auto = autoRegisterHandler.getVikaAuto();
                label9.Text = Convert.ToString(auto.ID1);
                valittuID = auto.ID1;
                textBox1.Text = Convert.ToString(auto.Mittarilukema1);
                textBox2.Text = Convert.ToString(auto.Moottorin_tilavuus1);
                textBox3.Text = Convert.ToString(auto.Hinta1);
                comboBox2.SelectedValue = auto.AutonMerkkiID1;
                comboBox1.SelectedValue = auto.AutonMalliID1;
                comboBox3.SelectedValue = auto.PolttoaineID1;
                comboBox4.SelectedValue = auto.VaritID1;
                try
                {
                    dateTimePicker1.Value = auto.Rekisteri_paivamaara1;
                }
                catch (Exception virhe)
                {

                }
            }
            
        }


    }
}
