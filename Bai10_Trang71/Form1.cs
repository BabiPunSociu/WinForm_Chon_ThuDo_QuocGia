using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10_Trang71
{
    public partial class Form1 : Form
    {
        Country_Capital[] country_Capitals = 
        {
            new Country_Capital("France", "Paris"),
            new Country_Capital("Japan", "Tokyo"),
            new Country_Capital("Hungary", "Budapest"),
            new Country_Capital("Spain", "Madrid"),
            new Country_Capital("Turkey", "Ankara"),
            new Country_Capital("The UK", "London"),
            new Country_Capital("Italy", "Rome"),
            new Country_Capital("The USA", "Washington"),
        };

        string Country;
        string Capital;

        public Form1()
        {
            InitializeComponent();
        }
        void Reset()
        {
            foreach(RadioButton rdo in grbCountry.Controls)
            {
                rdo.Checked = false;
            }
            foreach (RadioButton rdo in grbCapital.Controls)
            {
                rdo.Checked = false;
            }
        }
        void searchCapital(string Country)
        {
            foreach (Country_Capital CC in country_Capitals)
            {
                if(CC.Country == Country)
                {
                    Capital = CC.Capital;
                    return;
                }    
            }    
        }

        private void Country_CheckedChanged(object sender, EventArgs e)
        {
            foreach(RadioButton rdo in grbCountry.Controls)
            {
                if(rdo.Checked)
                {
                    Country = rdo.Text;
                    lblKetQua.Text = "Bạn hãy chọn thủ đô cho " + Country;
                    searchCapital(Country);
                    return;
                }    
            }    
        }

        private void Capital_checkedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdo in grbCapital.Controls)
            {
                if (rdo.Checked)
                {
                    if(rdo.Text == Capital)
                    {
                        MessageBox.Show("Chúc mừng bạn. Thủ đô của " + Country + " là: " + Capital);
                        Reset();
                        lblKetQua.Text = String.Empty;
                    }    
                    else
                    {
                        rdo.Checked = false;
                        MessageBox.Show("Bạn đã chọn sai. Hãy chọn lại");
                    }
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
