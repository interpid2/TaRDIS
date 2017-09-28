using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tardis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //Ukoliko se ulogira standardni korisnik, nije potrebno upisivati lozinku
            //Administrator mora unjeti lozinku i lozinka nakon programiranja se ne moze mjenjati
            
            if (pswdtBox.Text == "")
            {
                userForm user = new userForm(usertBx.Text);
                user.ShowDialog();
            }
            else if (pswdtBox.Text == "mmeisel" && usertBx.Text == "mmeisel")
            {
                adminForm admin = new adminForm();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Neispravna lozinka. Ukoliko ste standardni korisnik\npotrebno je polje lozinke ostaviti prazno.", "Greska", MessageBoxButtons.OK);
                pswdtBox.Text = "";
            }
        }

    }
}
