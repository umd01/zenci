using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList tckımlık = new ArrayList();
        ArrayList adi = new ArrayList();
        ArrayList soyadi = new ArrayList();
        ArrayList dogumt = new ArrayList();
        ArrayList sehir = new ArrayList();
        ArrayList adres = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Şehir Seçiniz";
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Ağrı");
            comboBox1.Items.Add("Artvin");
            comboBox1.Items.Add("Kilis");
            comboBox1.Items.Add("Osmaniye");
            comboBox1.Items.Add("Düzce");
            comboBox1.Items.Add("Hakkari");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Hatay");
            comboBox1.Items.Add("Gaziantep");
            comboBox1.Items.Add("Kars");
            comboBox1.Items.Add("Sakarya");



        }

             private void button1_Click(object sender, EventArgs e)
             {
               if (maskedTextBox1.Text == null || adTextbox.Text == null || soyadTextbox.Text == null || adresTextbox.Text==null || maskedTextBox2.Text==null)

               {
                MessageBox.Show("Bir yeri boş bıraktınız!")
                    ;
                
                }
                else
                {
                tckımlık.Add(maskedTextBox1.Text);
                adi.Add(adTextbox.Text);
                soyadi.Add(soyadTextbox.Text);
                dogumt.Add(maskedTextBox2.Text);
                sehir.Add(comboBox1.SelectedItem);
                adres.Add(adresTextbox.Text);

                maskedTextBox1.Clear();
                adTextbox.Clear();
                soyadTextbox.Clear();
                maskedTextBox2.Clear();
                comboBox1.Text = "Şehir Seçin";
                adresTextbox.Clear();

                maskedTextBox1.Select();
                
             }

       
             }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sec = listBox1.SelectedIndex;
            listBox2.SelectedIndex = sec;
            listBox3.SelectedIndex = sec;
            listBox4.SelectedIndex = sec;
            listBox5.SelectedIndex = sec;
            listBox6.SelectedIndex = sec;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sec = listBox2.SelectedIndex;
            listBox1.SelectedIndex = sec;
            listBox3.SelectedIndex = sec;
            listBox4.SelectedIndex = sec;
            listBox5.SelectedIndex = sec;
            listBox6.SelectedIndex = sec;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sec = listBox3.SelectedIndex;
            listBox1.SelectedIndex = sec;
            listBox2.SelectedIndex = sec;
            listBox4.SelectedIndex = sec;
            listBox5.SelectedIndex = sec;
            listBox6.SelectedIndex = sec;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sec = listBox4.SelectedIndex;
            listBox1.SelectedIndex = sec;
            listBox2.SelectedIndex = sec;
            listBox3.SelectedIndex = sec;
            listBox5.SelectedIndex = sec;
            listBox6.SelectedIndex = sec;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sec = listBox6.SelectedIndex;
            listBox1.SelectedIndex = sec;
            listBox2.SelectedIndex = sec;
            listBox3.SelectedIndex = sec;
            listBox4.SelectedIndex = sec;
            listBox5.SelectedIndex = sec;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int ind;
        private void button3_Click(object sender, EventArgs e)
        {

            ind = 0;

            string bulunacakTc = textBox1.Text;
            bool bulundu = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string tcc = listBox1.Items[i].ToString();

                if (tcc == bulunacakTc)
                {
                    ind = i;
                    bulundu = true;
                    break;
                }
            }

            if (bulundu == true)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();

                listBox1.Items.Add(tckımlık[ind]);
                listBox2.Items.Add(adi[ind]);
                listBox3.Items.Add(soyadi[ind]);
                listBox4.Items.Add(dogumt[ind]);
                listBox5.Items.Add(sehir[ind]);
                listBox6.Items.Add(adres[ind]);
            }
            else
            {
                MessageBox.Show("Aradığınız TC Bulunamadı";
            }
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            ind = 0;
            string bulunacakTc = textBox2.Text;
            bool bulundu = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string tcc = listBox1.Items[i].ToString();

                if (tcc == bulunacakTc)
                {
                    ind = i;
                    bulundu = true;

                    break;
                }
            }

            if (bulundu == true)
            {
                tckımlık.RemoveAt(ind);
                adi.RemoveAt(ind);
                soyadi.RemoveAt(ind);
                dogumt.RemoveAt(ind);
                sehir.RemoveAt(ind);
                adres.RemoveAt(ind);

               
            }
            else
            {
                
            }
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear(); listBox4.Items.Clear();
            listBox5.Items.Clear(); listBox6.Items.Clear();

            foreach (string adlar in adi)
            {
                listBox2.Items.Add(adlar);
            }
            foreach (string tcler in tckımlık)
            {
                listBox1.Items.Add(tcler);
            }
            foreach (string soyad in soyadi)
            {
                listBox3.Items.Add(soyad);
            }
            foreach (string dogumtarihi in dogumt)
            {
                listBox4.Items.Add(dogumtarihi);
            }
            foreach (string sehirler in sehir)
            {
                listBox5.Items.Add(sehirler);
            }
            foreach (string adresler in adres)
            {
                listBox6.Items.Add(adresler);
            }
        }
    }

}