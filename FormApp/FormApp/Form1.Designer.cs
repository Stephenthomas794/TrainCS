using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        ////////////////////////////////////////////////////////////// 
        ///Set Speed Increase for Xbox
        public void SetSpeedIncrease()
        {
            float speed = this.Speedo.Value;
            float add = 3.0F;
            speed = speed + add;
            this.Speedo.Value = speed;
            
            //Label 4 Speed Value
            string SpeedString = speed.ToString();
            label4.Text = SpeedString;
            //Change Speedbox or label 4 color based on barrier value
            if (Speedo.RangeEndValue <= speed)
            {
                label4.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.Green;
            }
            Refresh();
        }

        //////////////////////////////////////////////////////////////
        ///Set Brake for Xbox Button
        public void SetBreakXbox()
        {
            float speed = this.Speedo.Value;
            float subtract = 3.0F;
            speed = speed - subtract;
            this.Speedo.Value = speed;

            //Label 4 Speed Value
            string SpeedString = speed.ToString();
            label4.Text = SpeedString;
            //Change Speedbox or label 4 color based on barrier value
            if (Speedo.RangeEndValue <= speed)
            {
                label4.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.Green;
            }
         
            Refresh();
        }

        //////////////////////////////////////////////////////////////
        // Set speed on main guage
        public void SetGuageValue(int speed)
        {
            this.Speedo.Value = speed;

            //Label 4 Speed Value
            string SpeedString = speed.ToString();
            label4.Text = SpeedString;
            Refresh();
        }

        /////////////////////////////////////////////////////////////
        ///Set Barrier Value
        public void SetBarrierValue(int barrier, int speed)
        {
            //Adjusting the green end Value for the current result 
            //DO NOT CHANGE DESIGN SEETING 
            Speedo.RangeEndValue = barrier;
            Speedo.RangesEndValue = new float[] {
                barrier,
                225F,
                0F,
                0F,
                0F};
            Speedo.RangesStartValue = new float[] {
                0F,
                barrier,
                0F,
                0F,
                0F};
            //Change Speedbox or label 4 color based on barrier value
            if (barrier <= speed)
            {
                label4.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.Green;
            }
            Refresh();
        }

        //////////////////////////////////////////////////////////////
        // Set each mode of the checkboxes by manually
        public void SetGuageMode(int mode)
        {
            label3.ForeColor = System.Drawing.Color.Snow;
            label6.ForeColor = System.Drawing.Color.Snow;
            label5.ForeColor = System.Drawing.Color.Snow;

            //checkBox1.Checked = false;
            //checkBox2.Checked = false;
            //checkBox3.Checked = false;

            switch(mode)
            {
                case 1:
                {
                        label3.ForeColor = System.Drawing.Color.Green;
                        //checkBox1.Checked = true;
                }
                break;
                case 2:
                {
                        label6.ForeColor = System.Drawing.Color.Green;
                        //checkBox2.Checked = true;
                }
                break;
                case 3:
                {
                        label5.ForeColor = System.Drawing.Color.Green;
                        //checkBox3.Checked = true;
                }
                break;
            }
            Refresh();
        }

        //////////////////////////////////////////////////////////////
        // Enabled the specified modes, disables the others
/*        public void SetGuageModes(bool mode1, bool mode2, bool mode3)
        {
            checkBox1.Checked = mode1;
            checkBox2.Checked = mode2;
            checkBox3.Checked = mode3;
        }*/

        //////////////////////////////////////////////////////////////
        // Set Second Guage Value
        public void SetArrivalsGuage(int percent)
        {
            this.aGauge2.Value = percent;
            Refresh();
        }

        //////////////////////////////////////////////////////////////
        // Set Progress Bar Value
        public void SetProgressBarValue(int value)
        {
            progressBar1.Value = value;
            Refresh();
        }

        /////////////////////////////////////////////////////////////
        ///Set Train ID
        public void SetTrainAs(int Id)
        {
            string LabelText = Id.ToString();
            label7.Text = LabelText;
            Refresh();
        }

        /////////////////////////////////////////////////////////////
        ///Set Radio Tags
        public void SetRadioTags(int tagNumber)
        {
            //////////////////////////////////////////////////////////////
            ///Declare Radio Hashtable
            Hashtable RadioHashTable = new Hashtable()
                {
                    { 1, radioButton1},
                    { 2, radioButton2},
                    { 3, radioButton3},
                    { 4, radioButton4},
                    { 5, radioButton5},
                    { 6, radioButton6},
                    { 7, radioButton7},
                    { 8, radioButton8},
                    { 9, radioButton9},
                    { 10, radioButton10},
                    { 11, radioButton11},
                    { 12, radioButton12},
                    { 13, radioButton13},
                    { 14, radioButton14},
                    { 15, radioButton15},
                    { 16, radioButton16},
                    { 17, radioButton17},
                    { 18, radioButton18},
                    { 19, radioButton19},
                    { 20, radioButton20},
                    { 21, radioButton21},
                    { 22, radioButton22},
                    { 23, radioButton23},
                    { 24, radioButton24},
                    { 25, radioButton25},
                    { 26, radioButton26},
                    { 27, radioButton27},
                    { 28, radioButton28},
                    { 29, radioButton29},
                    { 30, radioButton30},
                    { 31, radioButton31},
                    { 32, radioButton32},
                    { 33, radioButton33},
                    { 34, radioButton34},
                    { 35, radioButton35},
                    { 36, radioButton36},
                    { 37, radioButton37},
                    { 38, radioButton38},
                    { 39, radioButton39},
                    { 40, radioButton40},
                    { 41, radioButton41},
                    { 42, radioButton42},
                    { 43, radioButton43},
                    { 44, radioButton44},
                    { 45, radioButton45},
                    { 46, radioButton46},
                    { 47, radioButton47},
                    { 48, radioButton48},
                    { 49, radioButton49},
                    { 50, radioButton50},
                };

            foreach (DictionaryEntry item in RadioHashTable)
            {
                int keyVal = (int)item.Key;
                if (keyVal == tagNumber)
                {
                    (RadioHashTable[keyVal] as RadioButton).Checked = true;
                }
                
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acorn2020ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton36 = new System.Windows.Forms.RadioButton();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.radioButton38 = new System.Windows.Forms.RadioButton();
            this.radioButton39 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.radioButton41 = new System.Windows.Forms.RadioButton();
            this.radioButton42 = new System.Windows.Forms.RadioButton();
            this.radioButton43 = new System.Windows.Forms.RadioButton();
            this.radioButton44 = new System.Windows.Forms.RadioButton();
            this.radioButton45 = new System.Windows.Forms.RadioButton();
            this.radioButton46 = new System.Windows.Forms.RadioButton();
            this.radioButton47 = new System.Windows.Forms.RadioButton();
            this.radioButton48 = new System.Windows.Forms.RadioButton();
            this.radioButton49 = new System.Windows.Forms.RadioButton();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.radioButton51 = new System.Windows.Forms.RadioButton();
            this.radioButton52 = new System.Windows.Forms.RadioButton();
            this.radioButton53 = new System.Windows.Forms.RadioButton();
            this.radioButton54 = new System.Windows.Forms.RadioButton();
            this.radioButton55 = new System.Windows.Forms.RadioButton();
            this.radioButton56 = new System.Windows.Forms.RadioButton();
            this.radioButton57 = new System.Windows.Forms.RadioButton();
            this.radioButton58 = new System.Windows.Forms.RadioButton();
            this.radioButton59 = new System.Windows.Forms.RadioButton();
            this.radioButton60 = new System.Windows.Forms.RadioButton();
            this.radioButton61 = new System.Windows.Forms.RadioButton();
            this.radioButton62 = new System.Windows.Forms.RadioButton();
            this.radioButton63 = new System.Windows.Forms.RadioButton();
            this.radioButton64 = new System.Windows.Forms.RadioButton();
            this.radioButton65 = new System.Windows.Forms.RadioButton();
            this.radioButton66 = new System.Windows.Forms.RadioButton();
            this.radioButton67 = new System.Windows.Forms.RadioButton();
            this.radioButton68 = new System.Windows.Forms.RadioButton();
            this.radioButton69 = new System.Windows.Forms.RadioButton();
            this.radioButton70 = new System.Windows.Forms.RadioButton();
            this.radioButton71 = new System.Windows.Forms.RadioButton();
            this.radioButton72 = new System.Windows.Forms.RadioButton();
            this.radioButton73 = new System.Windows.Forms.RadioButton();
            this.radioButton74 = new System.Windows.Forms.RadioButton();
            this.radioButton75 = new System.Windows.Forms.RadioButton();
            this.radioButton76 = new System.Windows.Forms.RadioButton();
            this.radioButton77 = new System.Windows.Forms.RadioButton();
            this.radioButton78 = new System.Windows.Forms.RadioButton();
            this.radioButton79 = new System.Windows.Forms.RadioButton();
            this.radioButton80 = new System.Windows.Forms.RadioButton();
            this.radioButton81 = new System.Windows.Forms.RadioButton();
            this.radioButton82 = new System.Windows.Forms.RadioButton();
            this.radioButton83 = new System.Windows.Forms.RadioButton();
            this.radioButton84 = new System.Windows.Forms.RadioButton();
            this.radioButton85 = new System.Windows.Forms.RadioButton();
            this.radioButton86 = new System.Windows.Forms.RadioButton();
            this.radioButton87 = new System.Windows.Forms.RadioButton();
            this.radioButton88 = new System.Windows.Forms.RadioButton();
            this.radioButton89 = new System.Windows.Forms.RadioButton();
            this.radioButton90 = new System.Windows.Forms.RadioButton();
            this.radioButton91 = new System.Windows.Forms.RadioButton();
            this.radioButton92 = new System.Windows.Forms.RadioButton();
            this.radioButton93 = new System.Windows.Forms.RadioButton();
            this.radioButton94 = new System.Windows.Forms.RadioButton();
            this.radioButton95 = new System.Windows.Forms.RadioButton();
            this.radioButton96 = new System.Windows.Forms.RadioButton();
            this.radioButton97 = new System.Windows.Forms.RadioButton();
            this.radioButton98 = new System.Windows.Forms.RadioButton();
            this.radioButton99 = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            this.radioButton101 = new System.Windows.Forms.RadioButton();
            this.radioButton102 = new System.Windows.Forms.RadioButton();
            this.radioButton103 = new System.Windows.Forms.RadioButton();
            this.radioButton104 = new System.Windows.Forms.RadioButton();
            this.radioButton105 = new System.Windows.Forms.RadioButton();
            this.radioButton106 = new System.Windows.Forms.RadioButton();
            this.radioButton107 = new System.Windows.Forms.RadioButton();
            this.radioButton108 = new System.Windows.Forms.RadioButton();
            this.radioButton109 = new System.Windows.Forms.RadioButton();
            this.radioButton110 = new System.Windows.Forms.RadioButton();
            this.radioButton111 = new System.Windows.Forms.RadioButton();
            this.radioButton112 = new System.Windows.Forms.RadioButton();
            this.radioButton113 = new System.Windows.Forms.RadioButton();
            this.radioButton114 = new System.Windows.Forms.RadioButton();
            this.radioButton115 = new System.Windows.Forms.RadioButton();
            this.radioButton116 = new System.Windows.Forms.RadioButton();
            this.radioButton117 = new System.Windows.Forms.RadioButton();
            this.radioButton118 = new System.Windows.Forms.RadioButton();
            this.Speedo = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(297, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 55);
            this.label7.TabIndex = 4;
            this.label7.Text = "000";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.Location = new System.Drawing.Point(769, 924);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 72);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRAIN ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(117, 851);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 108);
            this.label4.TabIndex = 10;
            this.label4.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(917, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 55);
            this.label6.TabIndex = 9;
            this.label6.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(996, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(829, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(627, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "MODE:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 29);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(173, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acorn2020ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // acorn2020ToolStripMenuItem
            // 
            this.acorn2020ToolStripMenuItem.Name = "acorn2020ToolStripMenuItem";
            this.acorn2020ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.acorn2020ToolStripMenuItem.Text = "Acorn 2020";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(637, 648);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 261);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1211, 980);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.LightGreen;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(1065, 416);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 14);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Black;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(1105, 416);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 14);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1145, 416);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 14);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1185, 416);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 14);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1225, 416);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 14);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 66;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton9, 65, 16);
            this.tableLayoutPanel1.Controls.Add(this.radioButton10, 65, 14);
            this.tableLayoutPanel1.Controls.Add(this.radioButton11, 65, 12);
            this.tableLayoutPanel1.Controls.Add(this.radioButton12, 65, 10);
            this.tableLayoutPanel1.Controls.Add(this.radioButton13, 65, 8);
            this.tableLayoutPanel1.Controls.Add(this.radioButton14, 64, 7);
            this.tableLayoutPanel1.Controls.Add(this.radioButton15, 63, 6);
            this.tableLayoutPanel1.Controls.Add(this.radioButton16, 62, 5);
            this.tableLayoutPanel1.Controls.Add(this.radioButton17, 61, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton18, 59, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton19, 57, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton20, 55, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton8, 64, 17);
            this.tableLayoutPanel1.Controls.Add(this.radioButton7, 63, 18);
            this.tableLayoutPanel1.Controls.Add(this.radioButton6, 62, 19);
            this.tableLayoutPanel1.Controls.Add(this.radioButton5, 61, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton4, 59, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 57, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 55, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 53, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton21, 53, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton41, 13, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton42, 11, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton43, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton44, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton45, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton46, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.radioButton47, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.radioButton48, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.radioButton49, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.radioButton50, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.radioButton51, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.radioButton52, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.radioButton53, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.radioButton54, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.radioButton55, 3, 18);
            this.tableLayoutPanel1.Controls.Add(this.radioButton56, 4, 19);
            this.tableLayoutPanel1.Controls.Add(this.radioButton57, 5, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton58, 7, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton59, 9, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton60, 11, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton61, 13, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton62, 15, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton63, 17, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton64, 19, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton65, 21, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton66, 23, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton67, 25, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton68, 27, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton69, 29, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton70, 31, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton71, 33, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton72, 35, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton73, 37, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton74, 39, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton75, 41, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton76, 43, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton77, 45, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton78, 47, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton79, 49, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton80, 51, 20);
            this.tableLayoutPanel1.Controls.Add(this.radioButton99, 15, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton98, 17, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton97, 19, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton96, 21, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton95, 23, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton94, 25, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton93, 27, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton92, 29, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton91, 31, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton90, 33, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton89, 35, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton88, 37, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton87, 39, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton86, 41, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton85, 43, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton84, 45, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton83, 47, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton81, 51, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton82, 49, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton22, 50, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton23, 49, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton24, 47, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton25, 45, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton26, 43, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton27, 41, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton28, 39, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton29, 37, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton30, 35, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton31, 33, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton32, 31, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton33, 29, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton34, 27, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton35, 25, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton36, 23, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton37, 21, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton38, 19, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton39, 17, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton40, 16, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton118, 50, 21);
            this.tableLayoutPanel1.Controls.Add(this.radioButton117, 49, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton116, 47, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton115, 45, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton114, 43, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton113, 41, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton112, 39, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton111, 37, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton110, 35, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton109, 33, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton108, 31, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton107, 29, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton106, 27, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton105, 25, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton104, 23, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton103, 21, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton102, 19, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton101, 17, 22);
            this.tableLayoutPanel1.Controls.Add(this.radioButton100, 16, 21);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 25;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 514);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(1245, 396);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 14);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(1265, 376);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 14);
            this.radioButton7.TabIndex = 21;
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(1285, 356);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 14);
            this.radioButton8.TabIndex = 22;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(1305, 336);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(15, 14);
            this.radioButton9.TabIndex = 23;
            this.radioButton9.Text = "radioButton9";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(1305, 296);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(15, 14);
            this.radioButton10.TabIndex = 24;
            this.radioButton10.Text = "radioButton10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(1305, 256);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(15, 14);
            this.radioButton11.TabIndex = 25;
            this.radioButton11.Text = "radioButton11";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(1305, 216);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(15, 14);
            this.radioButton12.TabIndex = 26;
            this.radioButton12.Text = "radioButton12";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(1305, 176);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(15, 14);
            this.radioButton13.TabIndex = 27;
            this.radioButton13.Text = "radioButton13";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(1285, 156);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(14, 14);
            this.radioButton14.TabIndex = 28;
            this.radioButton14.Text = "radioButton14";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(1265, 136);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(14, 14);
            this.radioButton15.TabIndex = 29;
            this.radioButton15.Text = "radioButton15";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(1245, 116);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(14, 14);
            this.radioButton16.TabIndex = 30;
            this.radioButton16.Text = "radioButton16";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(1225, 96);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(14, 14);
            this.radioButton17.TabIndex = 31;
            this.radioButton17.Text = "radioButton17";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(1185, 96);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(14, 14);
            this.radioButton18.TabIndex = 32;
            this.radioButton18.Text = "radioButton18";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(1145, 96);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(14, 14);
            this.radioButton19.TabIndex = 33;
            this.radioButton19.Text = "radioButton19";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(1105, 96);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(14, 14);
            this.radioButton20.TabIndex = 34;
            this.radioButton20.Text = "radioButton20";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(1065, 96);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(14, 14);
            this.radioButton21.TabIndex = 35;
            this.radioButton21.Text = "radioButton21";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(1005, 74);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(14, 16);
            this.radioButton22.TabIndex = 36;
            this.radioButton22.Text = "radioButton22";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(985, 53);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(14, 15);
            this.radioButton23.TabIndex = 37;
            this.radioButton23.Text = "radioButton23";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(945, 53);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(14, 15);
            this.radioButton24.TabIndex = 38;
            this.radioButton24.Text = "radioButton24";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(905, 53);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(14, 15);
            this.radioButton25.TabIndex = 39;
            this.radioButton25.Text = "radioButton25";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(865, 53);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(14, 15);
            this.radioButton26.TabIndex = 40;
            this.radioButton26.Text = "radioButton26";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.Location = new System.Drawing.Point(825, 53);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(14, 15);
            this.radioButton27.TabIndex = 41;
            this.radioButton27.Text = "radioButton27";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.Location = new System.Drawing.Point(785, 53);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(14, 15);
            this.radioButton28.TabIndex = 42;
            this.radioButton28.Text = "radioButton28";
            this.radioButton28.UseVisualStyleBackColor = true;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.Location = new System.Drawing.Point(745, 53);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(14, 15);
            this.radioButton29.TabIndex = 43;
            this.radioButton29.Text = "radioButton29";
            this.radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(705, 53);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(14, 15);
            this.radioButton30.TabIndex = 44;
            this.radioButton30.Text = "radioButton30";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.Location = new System.Drawing.Point(665, 53);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(14, 15);
            this.radioButton31.TabIndex = 45;
            this.radioButton31.Text = "radioButton31";
            this.radioButton31.UseVisualStyleBackColor = true;
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Location = new System.Drawing.Point(625, 53);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(14, 15);
            this.radioButton32.TabIndex = 46;
            this.radioButton32.Text = "radioButton32";
            this.radioButton32.UseVisualStyleBackColor = true;
            // 
            // radioButton33
            // 
            this.radioButton33.AutoSize = true;
            this.radioButton33.Location = new System.Drawing.Point(585, 53);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(14, 15);
            this.radioButton33.TabIndex = 47;
            this.radioButton33.Text = "radioButton33";
            this.radioButton33.UseVisualStyleBackColor = true;
            // 
            // radioButton34
            // 
            this.radioButton34.AutoSize = true;
            this.radioButton34.Location = new System.Drawing.Point(545, 53);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(14, 15);
            this.radioButton34.TabIndex = 48;
            this.radioButton34.Text = "radioButton34";
            this.radioButton34.UseVisualStyleBackColor = true;
            // 
            // radioButton35
            // 
            this.radioButton35.AutoSize = true;
            this.radioButton35.Location = new System.Drawing.Point(505, 53);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(14, 15);
            this.radioButton35.TabIndex = 49;
            this.radioButton35.Text = "radioButton35";
            this.radioButton35.UseVisualStyleBackColor = true;
            // 
            // radioButton36
            // 
            this.radioButton36.AutoSize = true;
            this.radioButton36.Location = new System.Drawing.Point(465, 53);
            this.radioButton36.Name = "radioButton36";
            this.radioButton36.Size = new System.Drawing.Size(14, 15);
            this.radioButton36.TabIndex = 50;
            this.radioButton36.Text = "radioButton36";
            this.radioButton36.UseVisualStyleBackColor = true;
            // 
            // radioButton37
            // 
            this.radioButton37.AutoSize = true;
            this.radioButton37.Location = new System.Drawing.Point(425, 53);
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.Size = new System.Drawing.Size(14, 15);
            this.radioButton37.TabIndex = 51;
            this.radioButton37.Text = "radioButton37";
            this.radioButton37.UseVisualStyleBackColor = true;
            // 
            // radioButton38
            // 
            this.radioButton38.AutoSize = true;
            this.radioButton38.Location = new System.Drawing.Point(385, 53);
            this.radioButton38.Name = "radioButton38";
            this.radioButton38.Size = new System.Drawing.Size(14, 15);
            this.radioButton38.TabIndex = 52;
            this.radioButton38.Text = "radioButton38";
            this.radioButton38.UseVisualStyleBackColor = true;
            // 
            // radioButton39
            // 
            this.radioButton39.AutoSize = true;
            this.radioButton39.Location = new System.Drawing.Point(345, 53);
            this.radioButton39.Name = "radioButton39";
            this.radioButton39.Size = new System.Drawing.Size(14, 15);
            this.radioButton39.TabIndex = 53;
            this.radioButton39.Text = "radioButton39";
            this.radioButton39.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(325, 74);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(14, 16);
            this.radioButton40.TabIndex = 54;
            this.radioButton40.Text = "radioButton40";
            this.radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton41
            // 
            this.radioButton41.AutoSize = true;
            this.radioButton41.Location = new System.Drawing.Point(265, 96);
            this.radioButton41.Name = "radioButton41";
            this.radioButton41.Size = new System.Drawing.Size(14, 14);
            this.radioButton41.TabIndex = 55;
            this.radioButton41.Text = "radioButton41";
            this.radioButton41.UseVisualStyleBackColor = true;
            // 
            // radioButton42
            // 
            this.radioButton42.AutoSize = true;
            this.radioButton42.Location = new System.Drawing.Point(225, 96);
            this.radioButton42.Name = "radioButton42";
            this.radioButton42.Size = new System.Drawing.Size(14, 14);
            this.radioButton42.TabIndex = 56;
            this.radioButton42.Text = "radioButton42";
            this.radioButton42.UseVisualStyleBackColor = true;
            // 
            // radioButton43
            // 
            this.radioButton43.AutoSize = true;
            this.radioButton43.Location = new System.Drawing.Point(185, 96);
            this.radioButton43.Name = "radioButton43";
            this.radioButton43.Size = new System.Drawing.Size(14, 14);
            this.radioButton43.TabIndex = 57;
            this.radioButton43.Text = "radioButton43";
            this.radioButton43.UseVisualStyleBackColor = true;
            // 
            // radioButton44
            // 
            this.radioButton44.AutoSize = true;
            this.radioButton44.Location = new System.Drawing.Point(145, 96);
            this.radioButton44.Name = "radioButton44";
            this.radioButton44.Size = new System.Drawing.Size(14, 14);
            this.radioButton44.TabIndex = 58;
            this.radioButton44.Text = "radioButton44";
            this.radioButton44.UseVisualStyleBackColor = true;
            // 
            // radioButton45
            // 
            this.radioButton45.AutoSize = true;
            this.radioButton45.Location = new System.Drawing.Point(105, 96);
            this.radioButton45.Name = "radioButton45";
            this.radioButton45.Size = new System.Drawing.Size(14, 14);
            this.radioButton45.TabIndex = 59;
            this.radioButton45.Text = "radioButton45";
            this.radioButton45.UseVisualStyleBackColor = true;
            // 
            // radioButton46
            // 
            this.radioButton46.AutoSize = true;
            this.radioButton46.Location = new System.Drawing.Point(85, 116);
            this.radioButton46.Name = "radioButton46";
            this.radioButton46.Size = new System.Drawing.Size(14, 14);
            this.radioButton46.TabIndex = 60;
            this.radioButton46.Text = "radioButton46";
            this.radioButton46.UseVisualStyleBackColor = true;
            // 
            // radioButton47
            // 
            this.radioButton47.AutoSize = true;
            this.radioButton47.Location = new System.Drawing.Point(65, 136);
            this.radioButton47.Name = "radioButton47";
            this.radioButton47.Size = new System.Drawing.Size(14, 14);
            this.radioButton47.TabIndex = 61;
            this.radioButton47.Text = "radioButton47";
            this.radioButton47.UseVisualStyleBackColor = true;
            // 
            // radioButton48
            // 
            this.radioButton48.AutoSize = true;
            this.radioButton48.Location = new System.Drawing.Point(45, 156);
            this.radioButton48.Name = "radioButton48";
            this.radioButton48.Size = new System.Drawing.Size(14, 14);
            this.radioButton48.TabIndex = 62;
            this.radioButton48.Text = "radioButton48";
            this.radioButton48.UseVisualStyleBackColor = true;
            // 
            // radioButton49
            // 
            this.radioButton49.AutoSize = true;
            this.radioButton49.Location = new System.Drawing.Point(24, 176);
            this.radioButton49.Name = "radioButton49";
            this.radioButton49.Size = new System.Drawing.Size(15, 14);
            this.radioButton49.TabIndex = 63;
            this.radioButton49.Text = "radioButton49";
            this.radioButton49.UseVisualStyleBackColor = true;
            // 
            // radioButton50
            // 
            this.radioButton50.AutoSize = true;
            this.radioButton50.Location = new System.Drawing.Point(24, 216);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(15, 14);
            this.radioButton50.TabIndex = 64;
            this.radioButton50.Text = "radioButton50";
            this.radioButton50.UseVisualStyleBackColor = true;
            // 
            // radioButton51
            // 
            this.radioButton51.AutoSize = true;
            this.radioButton51.Location = new System.Drawing.Point(24, 256);
            this.radioButton51.Name = "radioButton51";
            this.radioButton51.Size = new System.Drawing.Size(15, 14);
            this.radioButton51.TabIndex = 65;
            this.radioButton51.Text = "radioButton51";
            this.radioButton51.UseVisualStyleBackColor = true;
            // 
            // radioButton52
            // 
            this.radioButton52.AutoSize = true;
            this.radioButton52.Location = new System.Drawing.Point(24, 296);
            this.radioButton52.Name = "radioButton52";
            this.radioButton52.Size = new System.Drawing.Size(15, 14);
            this.radioButton52.TabIndex = 66;
            this.radioButton52.Text = "radioButton52";
            this.radioButton52.UseVisualStyleBackColor = true;
            // 
            // radioButton53
            // 
            this.radioButton53.AutoSize = true;
            this.radioButton53.Location = new System.Drawing.Point(24, 336);
            this.radioButton53.Name = "radioButton53";
            this.radioButton53.Size = new System.Drawing.Size(15, 14);
            this.radioButton53.TabIndex = 67;
            this.radioButton53.Text = "radioButton53";
            this.radioButton53.UseVisualStyleBackColor = true;
            // 
            // radioButton54
            // 
            this.radioButton54.AutoSize = true;
            this.radioButton54.Location = new System.Drawing.Point(45, 356);
            this.radioButton54.Name = "radioButton54";
            this.radioButton54.Size = new System.Drawing.Size(14, 14);
            this.radioButton54.TabIndex = 68;
            this.radioButton54.Text = "radioButton54";
            this.radioButton54.UseVisualStyleBackColor = true;
            // 
            // radioButton55
            // 
            this.radioButton55.AutoSize = true;
            this.radioButton55.Location = new System.Drawing.Point(65, 376);
            this.radioButton55.Name = "radioButton55";
            this.radioButton55.Size = new System.Drawing.Size(14, 14);
            this.radioButton55.TabIndex = 69;
            this.radioButton55.Text = "radioButton55";
            this.radioButton55.UseVisualStyleBackColor = true;
            // 
            // radioButton56
            // 
            this.radioButton56.AutoSize = true;
            this.radioButton56.Location = new System.Drawing.Point(85, 396);
            this.radioButton56.Name = "radioButton56";
            this.radioButton56.Size = new System.Drawing.Size(14, 14);
            this.radioButton56.TabIndex = 70;
            this.radioButton56.Text = "radioButton56";
            this.radioButton56.UseVisualStyleBackColor = true;
            // 
            // radioButton57
            // 
            this.radioButton57.AutoSize = true;
            this.radioButton57.Location = new System.Drawing.Point(105, 416);
            this.radioButton57.Name = "radioButton57";
            this.radioButton57.Size = new System.Drawing.Size(14, 14);
            this.radioButton57.TabIndex = 71;
            this.radioButton57.Text = "radioButton57";
            this.radioButton57.UseVisualStyleBackColor = true;
            // 
            // radioButton58
            // 
            this.radioButton58.AutoSize = true;
            this.radioButton58.Location = new System.Drawing.Point(145, 416);
            this.radioButton58.Name = "radioButton58";
            this.radioButton58.Size = new System.Drawing.Size(14, 14);
            this.radioButton58.TabIndex = 72;
            this.radioButton58.Text = "radioButton58";
            this.radioButton58.UseVisualStyleBackColor = true;
            // 
            // radioButton59
            // 
            this.radioButton59.AutoSize = true;
            this.radioButton59.Location = new System.Drawing.Point(185, 416);
            this.radioButton59.Name = "radioButton59";
            this.radioButton59.Size = new System.Drawing.Size(14, 14);
            this.radioButton59.TabIndex = 73;
            this.radioButton59.Text = "radioButton59";
            this.radioButton59.UseVisualStyleBackColor = true;
            // 
            // radioButton60
            // 
            this.radioButton60.AutoSize = true;
            this.radioButton60.Location = new System.Drawing.Point(225, 416);
            this.radioButton60.Name = "radioButton60";
            this.radioButton60.Size = new System.Drawing.Size(14, 14);
            this.radioButton60.TabIndex = 74;
            this.radioButton60.Text = "radioButton60";
            this.radioButton60.UseVisualStyleBackColor = true;
            // 
            // radioButton61
            // 
            this.radioButton61.AutoSize = true;
            this.radioButton61.Location = new System.Drawing.Point(265, 416);
            this.radioButton61.Name = "radioButton61";
            this.radioButton61.Size = new System.Drawing.Size(14, 14);
            this.radioButton61.TabIndex = 75;
            this.radioButton61.Text = "radioButton61";
            this.radioButton61.UseVisualStyleBackColor = true;
            // 
            // radioButton62
            // 
            this.radioButton62.AutoSize = true;
            this.radioButton62.Location = new System.Drawing.Point(305, 416);
            this.radioButton62.Name = "radioButton62";
            this.radioButton62.Size = new System.Drawing.Size(14, 14);
            this.radioButton62.TabIndex = 76;
            this.radioButton62.Text = "radioButton62";
            this.radioButton62.UseVisualStyleBackColor = true;
            // 
            // radioButton63
            // 
            this.radioButton63.AutoSize = true;
            this.radioButton63.Location = new System.Drawing.Point(345, 416);
            this.radioButton63.Name = "radioButton63";
            this.radioButton63.Size = new System.Drawing.Size(14, 14);
            this.radioButton63.TabIndex = 77;
            this.radioButton63.Text = "radioButton63";
            this.radioButton63.UseVisualStyleBackColor = true;
            // 
            // radioButton64
            // 
            this.radioButton64.AutoSize = true;
            this.radioButton64.Location = new System.Drawing.Point(385, 416);
            this.radioButton64.Name = "radioButton64";
            this.radioButton64.Size = new System.Drawing.Size(14, 14);
            this.radioButton64.TabIndex = 78;
            this.radioButton64.Text = "radioButton64";
            this.radioButton64.UseVisualStyleBackColor = true;
            // 
            // radioButton65
            // 
            this.radioButton65.AutoSize = true;
            this.radioButton65.Location = new System.Drawing.Point(425, 416);
            this.radioButton65.Name = "radioButton65";
            this.radioButton65.Size = new System.Drawing.Size(14, 14);
            this.radioButton65.TabIndex = 79;
            this.radioButton65.Text = "radioButton65";
            this.radioButton65.UseVisualStyleBackColor = true;
            // 
            // radioButton66
            // 
            this.radioButton66.AutoSize = true;
            this.radioButton66.Location = new System.Drawing.Point(465, 416);
            this.radioButton66.Name = "radioButton66";
            this.radioButton66.Size = new System.Drawing.Size(14, 14);
            this.radioButton66.TabIndex = 80;
            this.radioButton66.Text = "radioButton66";
            this.radioButton66.UseVisualStyleBackColor = true;
            // 
            // radioButton67
            // 
            this.radioButton67.AutoSize = true;
            this.radioButton67.Location = new System.Drawing.Point(505, 416);
            this.radioButton67.Name = "radioButton67";
            this.radioButton67.Size = new System.Drawing.Size(14, 14);
            this.radioButton67.TabIndex = 81;
            this.radioButton67.Text = "radioButton67";
            this.radioButton67.UseVisualStyleBackColor = true;
            // 
            // radioButton68
            // 
            this.radioButton68.AutoSize = true;
            this.radioButton68.Location = new System.Drawing.Point(545, 416);
            this.radioButton68.Name = "radioButton68";
            this.radioButton68.Size = new System.Drawing.Size(14, 14);
            this.radioButton68.TabIndex = 82;
            this.radioButton68.Text = "radioButton68";
            this.radioButton68.UseVisualStyleBackColor = true;
            // 
            // radioButton69
            // 
            this.radioButton69.AutoSize = true;
            this.radioButton69.Location = new System.Drawing.Point(585, 416);
            this.radioButton69.Name = "radioButton69";
            this.radioButton69.Size = new System.Drawing.Size(14, 14);
            this.radioButton69.TabIndex = 83;
            this.radioButton69.Text = "radioButton69";
            this.radioButton69.UseVisualStyleBackColor = true;
            // 
            // radioButton70
            // 
            this.radioButton70.AutoSize = true;
            this.radioButton70.Location = new System.Drawing.Point(625, 416);
            this.radioButton70.Name = "radioButton70";
            this.radioButton70.Size = new System.Drawing.Size(14, 14);
            this.radioButton70.TabIndex = 84;
            this.radioButton70.Text = "radioButton70";
            this.radioButton70.UseVisualStyleBackColor = true;
            // 
            // radioButton71
            // 
            this.radioButton71.AutoSize = true;
            this.radioButton71.Location = new System.Drawing.Point(665, 416);
            this.radioButton71.Name = "radioButton71";
            this.radioButton71.Size = new System.Drawing.Size(14, 14);
            this.radioButton71.TabIndex = 85;
            this.radioButton71.Text = "radioButton71";
            this.radioButton71.UseVisualStyleBackColor = true;
            // 
            // radioButton72
            // 
            this.radioButton72.AutoSize = true;
            this.radioButton72.Location = new System.Drawing.Point(705, 416);
            this.radioButton72.Name = "radioButton72";
            this.radioButton72.Size = new System.Drawing.Size(14, 14);
            this.radioButton72.TabIndex = 86;
            this.radioButton72.Text = "radioButton72";
            this.radioButton72.UseVisualStyleBackColor = true;
            // 
            // radioButton73
            // 
            this.radioButton73.AutoSize = true;
            this.radioButton73.Location = new System.Drawing.Point(745, 416);
            this.radioButton73.Name = "radioButton73";
            this.radioButton73.Size = new System.Drawing.Size(14, 14);
            this.radioButton73.TabIndex = 87;
            this.radioButton73.Text = "radioButton73";
            this.radioButton73.UseVisualStyleBackColor = true;
            // 
            // radioButton74
            // 
            this.radioButton74.AutoSize = true;
            this.radioButton74.Location = new System.Drawing.Point(785, 416);
            this.radioButton74.Name = "radioButton74";
            this.radioButton74.Size = new System.Drawing.Size(14, 14);
            this.radioButton74.TabIndex = 88;
            this.radioButton74.Text = "radioButton74";
            this.radioButton74.UseVisualStyleBackColor = true;
            // 
            // radioButton75
            // 
            this.radioButton75.AutoSize = true;
            this.radioButton75.Location = new System.Drawing.Point(825, 416);
            this.radioButton75.Name = "radioButton75";
            this.radioButton75.Size = new System.Drawing.Size(14, 14);
            this.radioButton75.TabIndex = 89;
            this.radioButton75.Text = "radioButton75";
            this.radioButton75.UseVisualStyleBackColor = true;
            // 
            // radioButton76
            // 
            this.radioButton76.AutoSize = true;
            this.radioButton76.Location = new System.Drawing.Point(865, 416);
            this.radioButton76.Name = "radioButton76";
            this.radioButton76.Size = new System.Drawing.Size(14, 14);
            this.radioButton76.TabIndex = 90;
            this.radioButton76.Text = "radioButton76";
            this.radioButton76.UseVisualStyleBackColor = true;
            // 
            // radioButton77
            // 
            this.radioButton77.AutoSize = true;
            this.radioButton77.Location = new System.Drawing.Point(905, 416);
            this.radioButton77.Name = "radioButton77";
            this.radioButton77.Size = new System.Drawing.Size(14, 14);
            this.radioButton77.TabIndex = 91;
            this.radioButton77.Text = "radioButton77";
            this.radioButton77.UseVisualStyleBackColor = true;
            // 
            // radioButton78
            // 
            this.radioButton78.AutoSize = true;
            this.radioButton78.Location = new System.Drawing.Point(945, 416);
            this.radioButton78.Name = "radioButton78";
            this.radioButton78.Size = new System.Drawing.Size(14, 14);
            this.radioButton78.TabIndex = 92;
            this.radioButton78.Text = "radioButton78";
            this.radioButton78.UseVisualStyleBackColor = true;
            // 
            // radioButton79
            // 
            this.radioButton79.AutoSize = true;
            this.radioButton79.Location = new System.Drawing.Point(985, 416);
            this.radioButton79.Name = "radioButton79";
            this.radioButton79.Size = new System.Drawing.Size(14, 14);
            this.radioButton79.TabIndex = 93;
            this.radioButton79.Text = "radioButton79";
            this.radioButton79.UseVisualStyleBackColor = true;
            // 
            // radioButton80
            // 
            this.radioButton80.AutoSize = true;
            this.radioButton80.Location = new System.Drawing.Point(1025, 416);
            this.radioButton80.Name = "radioButton80";
            this.radioButton80.Size = new System.Drawing.Size(14, 14);
            this.radioButton80.TabIndex = 94;
            this.radioButton80.Text = "radioButton80";
            this.radioButton80.UseVisualStyleBackColor = true;
            // 
            // radioButton81
            // 
            this.radioButton81.AutoSize = true;
            this.radioButton81.Location = new System.Drawing.Point(1025, 96);
            this.radioButton81.Name = "radioButton81";
            this.radioButton81.Size = new System.Drawing.Size(14, 14);
            this.radioButton81.TabIndex = 95;
            this.radioButton81.Text = "radioButton81";
            this.radioButton81.UseVisualStyleBackColor = true;
            // 
            // radioButton82
            // 
            this.radioButton82.AutoSize = true;
            this.radioButton82.Location = new System.Drawing.Point(985, 96);
            this.radioButton82.Name = "radioButton82";
            this.radioButton82.Size = new System.Drawing.Size(14, 14);
            this.radioButton82.TabIndex = 96;
            this.radioButton82.Text = "radioButton82";
            this.radioButton82.UseVisualStyleBackColor = true;
            // 
            // radioButton83
            // 
            this.radioButton83.AutoSize = true;
            this.radioButton83.Location = new System.Drawing.Point(945, 96);
            this.radioButton83.Name = "radioButton83";
            this.radioButton83.Size = new System.Drawing.Size(14, 14);
            this.radioButton83.TabIndex = 97;
            this.radioButton83.Text = "radioButton83";
            this.radioButton83.UseVisualStyleBackColor = true;
            // 
            // radioButton84
            // 
            this.radioButton84.AutoSize = true;
            this.radioButton84.Location = new System.Drawing.Point(905, 96);
            this.radioButton84.Name = "radioButton84";
            this.radioButton84.Size = new System.Drawing.Size(14, 14);
            this.radioButton84.TabIndex = 98;
            this.radioButton84.Text = "radioButton84";
            this.radioButton84.UseVisualStyleBackColor = true;
            // 
            // radioButton85
            // 
            this.radioButton85.AutoSize = true;
            this.radioButton85.Location = new System.Drawing.Point(865, 96);
            this.radioButton85.Name = "radioButton85";
            this.radioButton85.Size = new System.Drawing.Size(14, 14);
            this.radioButton85.TabIndex = 99;
            this.radioButton85.Text = "radioButton85";
            this.radioButton85.UseVisualStyleBackColor = true;
            // 
            // radioButton86
            // 
            this.radioButton86.AutoSize = true;
            this.radioButton86.Location = new System.Drawing.Point(825, 96);
            this.radioButton86.Name = "radioButton86";
            this.radioButton86.Size = new System.Drawing.Size(14, 14);
            this.radioButton86.TabIndex = 100;
            this.radioButton86.Text = "radioButton86";
            this.radioButton86.UseVisualStyleBackColor = true;
            // 
            // radioButton87
            // 
            this.radioButton87.AutoSize = true;
            this.radioButton87.Location = new System.Drawing.Point(785, 96);
            this.radioButton87.Name = "radioButton87";
            this.radioButton87.Size = new System.Drawing.Size(14, 14);
            this.radioButton87.TabIndex = 101;
            this.radioButton87.Text = "radioButton87";
            this.radioButton87.UseVisualStyleBackColor = true;
            // 
            // radioButton88
            // 
            this.radioButton88.AutoSize = true;
            this.radioButton88.Location = new System.Drawing.Point(745, 96);
            this.radioButton88.Name = "radioButton88";
            this.radioButton88.Size = new System.Drawing.Size(14, 14);
            this.radioButton88.TabIndex = 102;
            this.radioButton88.Text = "radioButton88";
            this.radioButton88.UseVisualStyleBackColor = true;
            // 
            // radioButton89
            // 
            this.radioButton89.AutoSize = true;
            this.radioButton89.Location = new System.Drawing.Point(705, 96);
            this.radioButton89.Name = "radioButton89";
            this.radioButton89.Size = new System.Drawing.Size(14, 14);
            this.radioButton89.TabIndex = 103;
            this.radioButton89.Text = "radioButton89";
            this.radioButton89.UseVisualStyleBackColor = true;
            // 
            // radioButton90
            // 
            this.radioButton90.AutoSize = true;
            this.radioButton90.Location = new System.Drawing.Point(665, 96);
            this.radioButton90.Name = "radioButton90";
            this.radioButton90.Size = new System.Drawing.Size(14, 14);
            this.radioButton90.TabIndex = 104;
            this.radioButton90.Text = "radioButton90";
            this.radioButton90.UseVisualStyleBackColor = true;
            // 
            // radioButton91
            // 
            this.radioButton91.AutoSize = true;
            this.radioButton91.Location = new System.Drawing.Point(625, 96);
            this.radioButton91.Name = "radioButton91";
            this.radioButton91.Size = new System.Drawing.Size(14, 14);
            this.radioButton91.TabIndex = 105;
            this.radioButton91.Text = "radioButton91";
            this.radioButton91.UseVisualStyleBackColor = true;
            // 
            // radioButton92
            // 
            this.radioButton92.AutoSize = true;
            this.radioButton92.Location = new System.Drawing.Point(585, 96);
            this.radioButton92.Name = "radioButton92";
            this.radioButton92.Size = new System.Drawing.Size(14, 14);
            this.radioButton92.TabIndex = 106;
            this.radioButton92.Text = "radioButton92";
            this.radioButton92.UseVisualStyleBackColor = true;
            // 
            // radioButton93
            // 
            this.radioButton93.AutoSize = true;
            this.radioButton93.Location = new System.Drawing.Point(545, 96);
            this.radioButton93.Name = "radioButton93";
            this.radioButton93.Size = new System.Drawing.Size(14, 14);
            this.radioButton93.TabIndex = 107;
            this.radioButton93.Text = "radioButton93";
            this.radioButton93.UseVisualStyleBackColor = true;
            // 
            // radioButton94
            // 
            this.radioButton94.AutoSize = true;
            this.radioButton94.Location = new System.Drawing.Point(505, 96);
            this.radioButton94.Name = "radioButton94";
            this.radioButton94.Size = new System.Drawing.Size(14, 14);
            this.radioButton94.TabIndex = 108;
            this.radioButton94.Text = "radioButton94";
            this.radioButton94.UseVisualStyleBackColor = true;
            // 
            // radioButton95
            // 
            this.radioButton95.AutoSize = true;
            this.radioButton95.Location = new System.Drawing.Point(465, 96);
            this.radioButton95.Name = "radioButton95";
            this.radioButton95.Size = new System.Drawing.Size(14, 14);
            this.radioButton95.TabIndex = 109;
            this.radioButton95.Text = "radioButton95";
            this.radioButton95.UseVisualStyleBackColor = true;
            // 
            // radioButton96
            // 
            this.radioButton96.AutoSize = true;
            this.radioButton96.Location = new System.Drawing.Point(425, 96);
            this.radioButton96.Name = "radioButton96";
            this.radioButton96.Size = new System.Drawing.Size(14, 14);
            this.radioButton96.TabIndex = 110;
            this.radioButton96.Text = "radioButton96";
            this.radioButton96.UseVisualStyleBackColor = true;
            // 
            // radioButton97
            // 
            this.radioButton97.AutoSize = true;
            this.radioButton97.Location = new System.Drawing.Point(385, 96);
            this.radioButton97.Name = "radioButton97";
            this.radioButton97.Size = new System.Drawing.Size(14, 14);
            this.radioButton97.TabIndex = 111;
            this.radioButton97.Text = "radioButton97";
            this.radioButton97.UseVisualStyleBackColor = true;
            // 
            // radioButton98
            // 
            this.radioButton98.AutoSize = true;
            this.radioButton98.Location = new System.Drawing.Point(345, 96);
            this.radioButton98.Name = "radioButton98";
            this.radioButton98.Size = new System.Drawing.Size(14, 14);
            this.radioButton98.TabIndex = 112;
            this.radioButton98.Text = "radioButton98";
            this.radioButton98.UseVisualStyleBackColor = true;
            // 
            // radioButton99
            // 
            this.radioButton99.AutoSize = true;
            this.radioButton99.Location = new System.Drawing.Point(305, 96);
            this.radioButton99.Name = "radioButton99";
            this.radioButton99.Size = new System.Drawing.Size(14, 14);
            this.radioButton99.TabIndex = 113;
            this.radioButton99.Text = "radioButton99";
            this.radioButton99.UseVisualStyleBackColor = true;
            // 
            // radioButton100
            // 
            this.radioButton100.AutoSize = true;
            this.radioButton100.Location = new System.Drawing.Point(325, 436);
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.Size = new System.Drawing.Size(14, 14);
            this.radioButton100.TabIndex = 114;
            this.radioButton100.Text = "radioButton100";
            this.radioButton100.UseVisualStyleBackColor = true;
            // 
            // radioButton101
            // 
            this.radioButton101.AutoSize = true;
            this.radioButton101.Location = new System.Drawing.Point(345, 456);
            this.radioButton101.Name = "radioButton101";
            this.radioButton101.Size = new System.Drawing.Size(14, 14);
            this.radioButton101.TabIndex = 115;
            this.radioButton101.Text = "radioButton101";
            this.radioButton101.UseVisualStyleBackColor = true;
            // 
            // radioButton102
            // 
            this.radioButton102.AutoSize = true;
            this.radioButton102.Location = new System.Drawing.Point(385, 456);
            this.radioButton102.Name = "radioButton102";
            this.radioButton102.Size = new System.Drawing.Size(14, 14);
            this.radioButton102.TabIndex = 116;
            this.radioButton102.Text = "radioButton102";
            this.radioButton102.UseVisualStyleBackColor = true;
            // 
            // radioButton103
            // 
            this.radioButton103.AutoSize = true;
            this.radioButton103.Location = new System.Drawing.Point(425, 456);
            this.radioButton103.Name = "radioButton103";
            this.radioButton103.Size = new System.Drawing.Size(14, 14);
            this.radioButton103.TabIndex = 117;
            this.radioButton103.Text = "radioButton103";
            this.radioButton103.UseVisualStyleBackColor = true;
            // 
            // radioButton104
            // 
            this.radioButton104.AutoSize = true;
            this.radioButton104.Location = new System.Drawing.Point(465, 456);
            this.radioButton104.Name = "radioButton104";
            this.radioButton104.Size = new System.Drawing.Size(14, 14);
            this.radioButton104.TabIndex = 118;
            this.radioButton104.Text = "radioButton104";
            this.radioButton104.UseVisualStyleBackColor = true;
            // 
            // radioButton105
            // 
            this.radioButton105.AutoSize = true;
            this.radioButton105.Location = new System.Drawing.Point(505, 456);
            this.radioButton105.Name = "radioButton105";
            this.radioButton105.Size = new System.Drawing.Size(14, 14);
            this.radioButton105.TabIndex = 119;
            this.radioButton105.Text = "radioButton105";
            this.radioButton105.UseVisualStyleBackColor = true;
            // 
            // radioButton106
            // 
            this.radioButton106.AutoSize = true;
            this.radioButton106.Location = new System.Drawing.Point(545, 456);
            this.radioButton106.Name = "radioButton106";
            this.radioButton106.Size = new System.Drawing.Size(14, 14);
            this.radioButton106.TabIndex = 120;
            this.radioButton106.Text = "radioButton106";
            this.radioButton106.UseVisualStyleBackColor = true;
            // 
            // radioButton107
            // 
            this.radioButton107.AutoSize = true;
            this.radioButton107.Location = new System.Drawing.Point(585, 456);
            this.radioButton107.Name = "radioButton107";
            this.radioButton107.Size = new System.Drawing.Size(14, 14);
            this.radioButton107.TabIndex = 121;
            this.radioButton107.Text = "radioButton107";
            this.radioButton107.UseVisualStyleBackColor = true;
            // 
            // radioButton108
            // 
            this.radioButton108.AutoSize = true;
            this.radioButton108.Location = new System.Drawing.Point(625, 456);
            this.radioButton108.Name = "radioButton108";
            this.radioButton108.Size = new System.Drawing.Size(14, 14);
            this.radioButton108.TabIndex = 122;
            this.radioButton108.Text = "radioButton108";
            this.radioButton108.UseVisualStyleBackColor = true;
            // 
            // radioButton109
            // 
            this.radioButton109.AutoSize = true;
            this.radioButton109.Location = new System.Drawing.Point(665, 456);
            this.radioButton109.Name = "radioButton109";
            this.radioButton109.Size = new System.Drawing.Size(14, 14);
            this.radioButton109.TabIndex = 123;
            this.radioButton109.Text = "radioButton109";
            this.radioButton109.UseVisualStyleBackColor = true;
            // 
            // radioButton110
            // 
            this.radioButton110.AutoSize = true;
            this.radioButton110.Location = new System.Drawing.Point(705, 456);
            this.radioButton110.Name = "radioButton110";
            this.radioButton110.Size = new System.Drawing.Size(14, 14);
            this.radioButton110.TabIndex = 124;
            this.radioButton110.Text = "radioButton110";
            this.radioButton110.UseVisualStyleBackColor = true;
            // 
            // radioButton111
            // 
            this.radioButton111.AutoSize = true;
            this.radioButton111.Location = new System.Drawing.Point(745, 456);
            this.radioButton111.Name = "radioButton111";
            this.radioButton111.Size = new System.Drawing.Size(14, 14);
            this.radioButton111.TabIndex = 125;
            this.radioButton111.Text = "radioButton111";
            this.radioButton111.UseVisualStyleBackColor = true;
            // 
            // radioButton112
            // 
            this.radioButton112.AutoSize = true;
            this.radioButton112.Location = new System.Drawing.Point(785, 456);
            this.radioButton112.Name = "radioButton112";
            this.radioButton112.Size = new System.Drawing.Size(14, 14);
            this.radioButton112.TabIndex = 126;
            this.radioButton112.Text = "radioButton112";
            this.radioButton112.UseVisualStyleBackColor = true;
            // 
            // radioButton113
            // 
            this.radioButton113.AutoSize = true;
            this.radioButton113.Location = new System.Drawing.Point(825, 456);
            this.radioButton113.Name = "radioButton113";
            this.radioButton113.Size = new System.Drawing.Size(14, 14);
            this.radioButton113.TabIndex = 127;
            this.radioButton113.Text = "radioButton113";
            this.radioButton113.UseVisualStyleBackColor = true;
            // 
            // radioButton114
            // 
            this.radioButton114.AutoSize = true;
            this.radioButton114.Location = new System.Drawing.Point(865, 456);
            this.radioButton114.Name = "radioButton114";
            this.radioButton114.Size = new System.Drawing.Size(14, 14);
            this.radioButton114.TabIndex = 128;
            this.radioButton114.Text = "radioButton114";
            this.radioButton114.UseVisualStyleBackColor = true;
            // 
            // radioButton115
            // 
            this.radioButton115.AutoSize = true;
            this.radioButton115.Location = new System.Drawing.Point(905, 456);
            this.radioButton115.Name = "radioButton115";
            this.radioButton115.Size = new System.Drawing.Size(14, 14);
            this.radioButton115.TabIndex = 129;
            this.radioButton115.Text = "radioButton115";
            this.radioButton115.UseVisualStyleBackColor = true;
            // 
            // radioButton116
            // 
            this.radioButton116.AutoSize = true;
            this.radioButton116.Location = new System.Drawing.Point(945, 456);
            this.radioButton116.Name = "radioButton116";
            this.radioButton116.Size = new System.Drawing.Size(14, 14);
            this.radioButton116.TabIndex = 130;
            this.radioButton116.Text = "radioButton116";
            this.radioButton116.UseVisualStyleBackColor = true;
            // 
            // radioButton117
            // 
            this.radioButton117.AutoSize = true;
            this.radioButton117.Location = new System.Drawing.Point(985, 456);
            this.radioButton117.Name = "radioButton117";
            this.radioButton117.Size = new System.Drawing.Size(14, 14);
            this.radioButton117.TabIndex = 131;
            this.radioButton117.Text = "radioButton117";
            this.radioButton117.UseVisualStyleBackColor = true;
            // 
            // radioButton118
            // 
            this.radioButton118.AutoSize = true;
            this.radioButton118.Location = new System.Drawing.Point(1005, 436);
            this.radioButton118.Name = "radioButton118";
            this.radioButton118.Size = new System.Drawing.Size(14, 14);
            this.radioButton118.TabIndex = 132;
            this.radioButton118.Text = "radioButton118";
            this.radioButton118.UseVisualStyleBackColor = true;
            // 
            // Speedo
            // 
            this.Speedo.BackColor = System.Drawing.Color.Black;
            this.Speedo.BaseArcColor = System.Drawing.Color.Transparent;
            this.Speedo.BaseArcRadius = 80;
            this.Speedo.BaseArcStart = 135;
            this.Speedo.BaseArcSweep = 270;
            this.Speedo.BaseArcWidth = 2;
            this.Speedo.Cap_Idx = ((byte)(1));
            this.Speedo.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Speedo.CapPosition = new System.Drawing.Point(10, 10);
            this.Speedo.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Speedo.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.Speedo.CapText = "";
            this.Speedo.Center = new System.Drawing.Point(100, 100);
            this.Speedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speedo.Location = new System.Drawing.Point(117, 668);
            this.Speedo.MaxValue = 225F;
            this.Speedo.MinValue = 0F;
            this.Speedo.Name = "Speedo";
            this.Speedo.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Speedo.NeedleColor2 = System.Drawing.Color.White;
            this.Speedo.NeedleRadius = 80;
            this.Speedo.NeedleType = 0;
            this.Speedo.NeedleWidth = 2;
            this.Speedo.Range_Idx = ((byte)(0));
            this.Speedo.RangeColor = System.Drawing.Color.LawnGreen;
            this.Speedo.RangeEnabled = true;
            this.Speedo.RangeEndValue = 101F;
            this.Speedo.RangeInnerRadius = 70;
            this.Speedo.RangeOuterRadius = 80;
            this.Speedo.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LawnGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Speedo.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.Speedo.RangesEndValue = new float[] {
        101F,
        225F,
        0F,
        0F,
        0F};
            this.Speedo.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.Speedo.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.Speedo.RangesStartValue = new float[] {
        0F,
        101F,
        0F,
        0F,
        0F};
            this.Speedo.RangeStartValue = 0F;
            this.Speedo.ScaleLinesInterColor = System.Drawing.Color.FloralWhite;
            this.Speedo.ScaleLinesInterInnerRadius = 73;
            this.Speedo.ScaleLinesInterOuterRadius = 80;
            this.Speedo.ScaleLinesInterWidth = 1;
            this.Speedo.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.Speedo.ScaleLinesMajorInnerRadius = 70;
            this.Speedo.ScaleLinesMajorOuterRadius = 80;
            this.Speedo.ScaleLinesMajorStepValue = 25F;
            this.Speedo.ScaleLinesMajorWidth = 2;
            this.Speedo.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.Speedo.ScaleLinesMinorInnerRadius = 75;
            this.Speedo.ScaleLinesMinorNumOf = 9;
            this.Speedo.ScaleLinesMinorOuterRadius = 80;
            this.Speedo.ScaleLinesMinorWidth = 1;
            this.Speedo.ScaleNumbersColor = System.Drawing.Color.WhiteSmoke;
            this.Speedo.ScaleNumbersFormat = null;
            this.Speedo.ScaleNumbersRadius = 95;
            this.Speedo.ScaleNumbersRotation = 0;
            this.Speedo.ScaleNumbersStartScaleLine = 0;
            this.Speedo.ScaleNumbersStepScaleLines = 1;
            this.Speedo.Size = new System.Drawing.Size(207, 180);
            this.Speedo.TabIndex = 7;
            this.Speedo.Text = "Speedo";
            this.Speedo.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge2.BaseArcRadius = 1;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 360;
            this.aGauge2.BaseArcWidth = 10;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 15);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 15),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            this.aGauge2.Location = new System.Drawing.Point(769, 668);
            this.aGauge2.MaxValue = 255F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Blue;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.FloralWhite;
            this.aGauge2.NeedleRadius = 120;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 5;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.Color.Red;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 212.5F;
            this.aGauge2.RangeInnerRadius = 10;
            this.aGauge2.RangeOuterRadius = 100;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.Color.Gray,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        127.5F,
        212.5F,
        297.5F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        1,
        10,
        1,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        100,
        100,
        100,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        42.5F,
        127.5F,
        212.5F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 127.5F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Transparent;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 90;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Transparent;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Transparent;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(202, 217);
            this.aGauge2.TabIndex = 1;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 127.5F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1349, 1028);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Speedo);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Acorn";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private AGaugeApp.AGauge aGauge2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private AGaugeApp.AGauge Speedo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private RadioButton radioButton21;
        private RadioButton radioButton22;
        private RadioButton radioButton23;
        private RadioButton radioButton24;
        private RadioButton radioButton25;
        private RadioButton radioButton26;
        private RadioButton radioButton27;
        private RadioButton radioButton28;
        private RadioButton radioButton29;
        private RadioButton radioButton30;
        private RadioButton radioButton31;
        private RadioButton radioButton32;
        private RadioButton radioButton33;
        private RadioButton radioButton34;
        private RadioButton radioButton35;
        private RadioButton radioButton36;
        private RadioButton radioButton37;
        private RadioButton radioButton38;
        private RadioButton radioButton39;
        private RadioButton radioButton40;
        private RadioButton radioButton41;
        private RadioButton radioButton42;
        private RadioButton radioButton43;
        private RadioButton radioButton44;
        private RadioButton radioButton45;
        private RadioButton radioButton46;
        private RadioButton radioButton47;
        private RadioButton radioButton48;
        private RadioButton radioButton49;
        private RadioButton radioButton50;
        private RadioButton radioButton51;
        private RadioButton radioButton52;
        private RadioButton radioButton53;
        private RadioButton radioButton54;
        private RadioButton radioButton55;
        private RadioButton radioButton56;
        private RadioButton radioButton57;
        private RadioButton radioButton58;
        private RadioButton radioButton59;
        private RadioButton radioButton60;
        private RadioButton radioButton61;
        private RadioButton radioButton62;
        private RadioButton radioButton63;
        private RadioButton radioButton64;
        private RadioButton radioButton65;
        private RadioButton radioButton66;
        private RadioButton radioButton67;
        private RadioButton radioButton68;
        private RadioButton radioButton69;
        private RadioButton radioButton70;
        private RadioButton radioButton71;
        private RadioButton radioButton72;
        private RadioButton radioButton73;
        private RadioButton radioButton74;
        private RadioButton radioButton75;
        private RadioButton radioButton76;
        private RadioButton radioButton77;
        private RadioButton radioButton78;
        private RadioButton radioButton79;
        private RadioButton radioButton80;
        private RadioButton radioButton81;
        private RadioButton radioButton82;
        private RadioButton radioButton83;
        private RadioButton radioButton84;
        private RadioButton radioButton85;
        private RadioButton radioButton86;
        private RadioButton radioButton87;
        private RadioButton radioButton88;
        private RadioButton radioButton89;
        private RadioButton radioButton90;
        private RadioButton radioButton91;
        private RadioButton radioButton92;
        private RadioButton radioButton93;
        private RadioButton radioButton94;
        private RadioButton radioButton95;
        private RadioButton radioButton96;
        private RadioButton radioButton97;
        private RadioButton radioButton98;
        private RadioButton radioButton99;
        private RadioButton radioButton100;
        private RadioButton radioButton101;
        private RadioButton radioButton102;
        private RadioButton radioButton103;
        private RadioButton radioButton104;
        private RadioButton radioButton105;
        private RadioButton radioButton106;
        private RadioButton radioButton107;
        private RadioButton radioButton108;
        private RadioButton radioButton109;
        private RadioButton radioButton110;
        private RadioButton radioButton111;
        private RadioButton radioButton112;
        private RadioButton radioButton113;
        private RadioButton radioButton114;
        private RadioButton radioButton115;
        private RadioButton radioButton116;
        private RadioButton radioButton117;
        private RadioButton radioButton118;
        private ToolStripMenuItem acorn2020ToolStripMenuItem;
    }
}

 