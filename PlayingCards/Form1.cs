using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCards
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numberBetween0And3 = random.Next(4);
            int numberBetween1And13 = random.Next(1, 14);
            int anyRandomNumber = random.Next();
            Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));

            MessageBox.Show(card.Name);
                

        }
    }
}
