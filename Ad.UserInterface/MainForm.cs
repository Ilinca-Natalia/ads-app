using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ad.UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //la apasarea butonului se deschide fereastra 
        private void button2_Click(object sender, EventArgs e)
        {
            var formAdaugareAnunt = new FormAdaugareAnunt();
            formAdaugareAnunt.ShowDialog();
        }

        private void cont_Click(object sender, EventArgs e)
        {
            var formCreareCont = new FormCreareCont();
            formCreareCont.ShowDialog();
        }

        private void stergere_Click(object sender, EventArgs e)
        {
            var formStergereAnunt = new FormStergereAnunt();
            formStergereAnunt.ShowDialog();
        }

        private void modificare_Click(object sender, EventArgs e)
        {
            var formModificareAnunt = new FormModificareAnunt();
            formModificareAnunt.ShowDialog();
        }

        private void cautare_Click(object sender, EventArgs e)
        {
            var formCautareAnunturi = new FormCautareAnunturi();
            formCautareAnunturi.ShowDialog();
        }

        private void afisare_Click(object sender, EventArgs e)
        {
            var formAfisareAnunturi = new FormAfisareAnunturi();
            formAfisareAnunturi.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
