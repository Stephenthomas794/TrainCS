using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using Class1App;

namespace FormApp
{
    public partial class Form1 : Form
    {
        Class1 class1 = new Class1();
        private int speed;

        public Form1()
        {
            InitializeComponent();
            this.speed = 0;

        }

        public int updateSpeed()
        {
            //this.speed = this.class1.getSpeedValue();
            //return this.speed;
            return 0;
            //Refresh();
        }



    }
}


/*
 Guage value = from class1 this.class1.getSpeedValue(); // from form1 updateSpeed();








            public void checkboxs(bool mode1, bool mode2, bool mode3)
        {
            mode1 = this.class1.getMode1();
            mode2 = this.class1.getMode2();
            mode3 = this.class1.getMode3();

            if (mode1 == true)
            {
                this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            } else
            {
                this.checkBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            }
            string sAttr = ConfigurationManager.AppSettings.Get("speed");
            if (mode2 == true)
            {
                this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            }
            else
            {
                this.checkBox2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            }

            if (mode3 == true)
            {
                this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            }
            else
            {
                this.checkBox3.CheckState = System.Windows.Forms.CheckState.Unchecked;
            }
        }

        public bool updateCheckbox1(bool mode1)
        {
            if (mode1 == true)
            {
                return this.checkBox1.Checked = true;
            }
            else
            {
                return this.checkBox1.Checked = false;
            }
            
        }




     */
