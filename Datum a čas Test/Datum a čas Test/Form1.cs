using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datum_a_čas_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DateTime DatumNarozeni = new DateTime();
        public DateTime zmenaRC = new DateTime();
        public int rok, mesic, den;
        public int cislo1, cislo2, cislo3, cislo4;
        public int pocitadloZena = 0, pocitadloMuz = 0, pocetRC = 0;
        public bool konec = false;
        public bool zmena = false;
        public Random rng = new Random();
        public string Rcislo1 = "";
        public string Rcislo2 = "";
        

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "000000000";
            maskedTextBox2.Text = "0000000000";
            DatumNarozeni = dateTimePicker1.Value;
            rok = DatumNarozeni.Year;
            mesic = DatumNarozeni.Month;
            den = DatumNarozeni.Day;
            rok = rok % 100;
            cislo1 = rng.Next(1,9);
            cislo2 = rng.Next(1, 9);
            cislo3 = rng.Next(1, 9);
            cislo4 = rng.Next(1, 9);
            if(zmena == false)
            {
                zmenaRC = zmenaRC.AddYears(1953);
                zmena = true;
            }
            label1.Text = zmenaRC.ToString();

            if (radioButton1.Checked)
            {
                mesic = mesic + 50;
                pocitadloZena++;
                pocetRC++;
                konec = false;
            }
            else if (radioButton2.Checked)
            {
                pocitadloMuz++;
                pocetRC++;
                konec = false;
            }
            else
            {
                MessageBox.Show("Vyplňte Všechyn informace!" + "Chyba!");
                konec = true;
            }
            if(pocetRC>=2)
            {
                button2.Visible = true;
                button2.Enabled = true;
            }

            if (DatumNarozeni < zmenaRC && konec == false)
            {
                if (rok < 10)
                {
                    if (mesic < 10)
                    {
                        if (den < 10)
                        {
                            Rcislo1 = "0" + rok.ToString() + "0" + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                        else
                        {
                            Rcislo1 = "0" + rok.ToString() + "0" + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                    }
                    else
                    {
                        if (den < 10)
                        {
                            Rcislo1 = "0" + rok.ToString() + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                        else
                        {
                            Rcislo1 = "0" + rok.ToString() + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                    }
                }
                else
                {
                    if (mesic < 10)
                    {
                        if (den < 10)
                        {
                            Rcislo1 = rok.ToString() + "0" + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                        else
                        {
                            Rcislo1 = rok.ToString() + "0" + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                    }
                    else
                    {
                        if (den < 10)
                        {
                            Rcislo1 = rok.ToString() + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                        else
                        {
                            Rcislo1 = rok.ToString() + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3;
                        }
                    }
                }
                listBox1.Items.Add(Rcislo1);
            }
            else if(DatumNarozeni > zmenaRC && konec == false)
            {
                if (rok < 10)
                {
                    if (mesic < 10)
                    {
                        if (den < 10)
                        {
                            Rcislo2 = "0" + rok.ToString() + "0" + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                        else
                        {
                            Rcislo2 = "0" + rok.ToString() + "0" + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                    }
                    else
                    {
                        if (den < 10)
                        {
                            Rcislo2 = "0" + rok.ToString() + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                        else
                        {
                            Rcislo2 = "0" + rok.ToString() + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                    }
                }
                else
                {
                    if (mesic < 10)
                    {
                        if (den < 10)
                        {
                            Rcislo2 = rok.ToString() + "0" + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                        else
                        {
                            Rcislo2 = rok.ToString() + "0" + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                    }
                    else
                    {
                        if (den < 10)
                        {
                            Rcislo2 = rok.ToString() + mesic.ToString() + "0" + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                        else
                        {
                            Rcislo2 = rok.ToString() + mesic.ToString() + den.ToString() + cislo1 + cislo2 + cislo3 + cislo4;
                        }
                    }
                }
                listBox1.Items.Add(Rcislo2);
            }
            maskedTextBox1.Text = Rcislo1;
            maskedTextBox2.Text = Rcislo2;
        }

        public int Nejmladsi;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Počet žen: " + pocitadloZena + "\nPočet Mužů: " + pocitadloMuz);
        }
    }
}
