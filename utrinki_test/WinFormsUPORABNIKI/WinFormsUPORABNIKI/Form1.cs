using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUPORABNIKI
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new UporabnikiModel())
            {
                //updateID();       TODO

                var id = labelID.Text;
                var ime = textBoxIme.Text;
                var priimek = textBoxPriimek.Text;
                var datum_rojstva = dateTimePicker1.Value;
                var komentar = textBoxKomentar.Text;

                var uporabnik = new UPORABNIKI
                {
                    IME = ime,
                    PRIIMEK = priimek,
                    DATUM_ROJSTVA = datum_rojstva,
                    KOMENTAR = komentar
                };

                db.UPORABNIKI.Add(uporabnik);
                db.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
