using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMileage_Click(object sender, EventArgs e)
        {
            GetAnswer();
            MessageBox.Show("Done");
        }

        public void GetAnswer()
        {
            Decimal Mileage, Distance, Gallons;
            Distance = Convert.ToDecimal(txtDistance.Text);
            Gallons = Convert.ToDecimal(txtGallons.Text);
            Mileage = Distance / Gallons;

            MessageBox.Show(Mileage.ToString(), "Answer");
        }
    }
}
