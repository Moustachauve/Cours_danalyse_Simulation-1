using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_de_go_Senthé
{
    public partial class UserControl1 : UserControl
    {
        [Browsable(true)]
        public string NomControle
        {
            get;
            set;
        }

        [Browsable(true)]
        public string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public bool UseSystemPasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        public bool ValiderTexte()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Le " + NomControle + " ne peut pas être vide");
                return false;
            }
            return true;
        }
    }
}
