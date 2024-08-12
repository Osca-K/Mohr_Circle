
namespace Mohr_Circle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.cmbY = new System.Windows.Forms.ComboBox();
            this.cmbXY = new System.Windows.Forms.ComboBox();
            this.cmbX = new System.Windows.Forms.ComboBox();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRVE = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAngles = new System.Windows.Forms.Label();
            this.lblSStress = new System.Windows.Forms.Label();
            this.lblPstress = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblCenterP = new System.Windows.Forms.Label();
            this.lblSigmaAvg = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMohrCicle = new System.Windows.Forms.TabPage();
            this.pnlCanva = new System.Windows.Forms.Panel();
            this.tabRVE = new System.Windows.Forms.TabPage();
            this.pnlRVE = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMohrCicle.SuspendLayout();
            this.tabRVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.cmbY);
            this.groupBox1.Controls.Add(this.cmbXY);
            this.groupBox1.Controls.Add(this.cmbX);
            this.groupBox1.Controls.Add(this.txtXY);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Given Initial State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Magnitude";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(156, 18);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(36, 17);
            this.Label.TabIndex = 11;
            this.Label.Text = "MPa";
            // 
            // cmbY
            // 
            this.cmbY.AutoCompleteCustomSource.AddRange(new string[] {
            "Compression",
            "Tension"});
            this.cmbY.FormattingEnabled = true;
            this.cmbY.Items.AddRange(new object[] {
            "Compression",
            "Tension"});
            this.cmbY.Location = new System.Drawing.Point(228, 89);
            this.cmbY.Name = "cmbY";
            this.cmbY.Size = new System.Drawing.Size(121, 24);
            this.cmbY.TabIndex = 10;
            // 
            // cmbXY
            // 
            this.cmbXY.FormattingEnabled = true;
            this.cmbXY.Items.AddRange(new object[] {
            "Clockwise",
            "Counterclockwise"});
            this.cmbXY.Location = new System.Drawing.Point(228, 128);
            this.cmbXY.Name = "cmbXY";
            this.cmbXY.Size = new System.Drawing.Size(121, 24);
            this.cmbXY.TabIndex = 9;
            // 
            // cmbX
            // 
            this.cmbX.AutoCompleteCustomSource.AddRange(new string[] {
            "Compression",
            "Tension"});
            this.cmbX.FormattingEnabled = true;
            this.cmbX.Items.AddRange(new object[] {
            "Compression",
            "Tension"});
            this.cmbX.Location = new System.Drawing.Point(228, 50);
            this.cmbX.Name = "cmbX";
            this.cmbX.Size = new System.Drawing.Size(121, 24);
            this.cmbX.TabIndex = 7;
            // 
            // txtXY
            // 
            this.txtXY.Location = new System.Drawing.Point(138, 130);
            this.txtXY.Name = "txtXY";
            this.txtXY.Size = new System.Drawing.Size(65, 22);
            this.txtXY.TabIndex = 6;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(138, 91);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(65, 22);
            this.txtY.TabIndex = 5;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(138, 52);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(65, 22);
            this.txtX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shear Stress(xy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Normal Stress(y)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Normal Stress(x)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnRVE);
            this.groupBox2.Controls.Add(this.btnDraw);
            this.groupBox2.Location = new System.Drawing.Point(28, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contols";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Clear Inputs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Exit Entire Application";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Construction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Represented Volume Element ";
            // 
            // btnRVE
            // 
            this.btnRVE.Location = new System.Drawing.Point(225, 68);
            this.btnRVE.Name = "btnRVE";
            this.btnRVE.Size = new System.Drawing.Size(110, 23);
            this.btnRVE.TabIndex = 1;
            this.btnRVE.Text = "RVE";
            this.btnRVE.UseVisualStyleBackColor = true;
            this.btnRVE.Click += new System.EventHandler(this.btnRVE_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(225, 32);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(110, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Mohr Circle";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.lblAngles);
            this.groupBox3.Controls.Add(this.lblSStress);
            this.groupBox3.Controls.Add(this.lblPstress);
            this.groupBox3.Controls.Add(this.lblRadius);
            this.groupBox3.Controls.Add(this.lblPoint);
            this.groupBox3.Controls.Add(this.lblCenterP);
            this.groupBox3.Controls.Add(this.lblSigmaAvg);
            this.groupBox3.Location = new System.Drawing.Point(1218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 456);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // lblAngles
            // 
            this.lblAngles.AutoSize = true;
            this.lblAngles.Location = new System.Drawing.Point(31, 330);
            this.lblAngles.Name = "lblAngles";
            this.lblAngles.Size = new System.Drawing.Size(59, 17);
            this.lblAngles.TabIndex = 7;
            this.lblAngles.Text = "Angles :";
            // 
            // lblSStress
            // 
            this.lblSStress.AutoSize = true;
            this.lblSStress.Location = new System.Drawing.Point(31, 283);
            this.lblSStress.Name = "lblSStress";
            this.lblSStress.Size = new System.Drawing.Size(133, 17);
            this.lblSStress.TabIndex = 5;
            this.lblSStress.Text = "Max inplane Shear :";
            // 
            // lblPstress
            // 
            this.lblPstress.AutoSize = true;
            this.lblPstress.Location = new System.Drawing.Point(31, 236);
            this.lblPstress.Name = "lblPstress";
            this.lblPstress.Size = new System.Drawing.Size(129, 17);
            this.lblPstress.TabIndex = 4;
            this.lblPstress.Text = "Principal Stresses :";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(31, 189);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(64, 17);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Radius  :";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(31, 142);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(99, 17);
            this.lblPoint.TabIndex = 2;
            this.lblPoint.Text = "Circumf Point :";
            // 
            // lblCenterP
            // 
            this.lblCenterP.AutoSize = true;
            this.lblCenterP.Location = new System.Drawing.Point(31, 95);
            this.lblCenterP.Name = "lblCenterP";
            this.lblCenterP.Size = new System.Drawing.Size(94, 17);
            this.lblCenterP.TabIndex = 1;
            this.lblCenterP.Text = "Center Point :";
            // 
            // lblSigmaAvg
            // 
            this.lblSigmaAvg.AutoSize = true;
            this.lblSigmaAvg.Location = new System.Drawing.Point(31, 48);
            this.lblSigmaAvg.Name = "lblSigmaAvg";
            this.lblSigmaAvg.Size = new System.Drawing.Size(83, 17);
            this.lblSigmaAvg.TabIndex = 0;
            this.lblSigmaAvg.Text = "Sigma Avg :";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMohrCicle);
            this.tabControl.Controls.Add(this.tabRVE);
            this.tabControl.Location = new System.Drawing.Point(410, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(786, 736);
            this.tabControl.TabIndex = 5;
            // 
            // tabMohrCicle
            // 
            this.tabMohrCicle.Controls.Add(this.pnlCanva);
            this.tabMohrCicle.Location = new System.Drawing.Point(4, 25);
            this.tabMohrCicle.Name = "tabMohrCicle";
            this.tabMohrCicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabMohrCicle.Size = new System.Drawing.Size(778, 707);
            this.tabMohrCicle.TabIndex = 0;
            this.tabMohrCicle.Text = "Mohr Cicle";
            this.tabMohrCicle.UseVisualStyleBackColor = true;
            // 
            // pnlCanva
            // 
            this.pnlCanva.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCanva.Location = new System.Drawing.Point(3, 71);
            this.pnlCanva.Name = "pnlCanva";
            this.pnlCanva.Size = new System.Drawing.Size(779, 650);
            this.pnlCanva.TabIndex = 3;
            // 
            // tabRVE
            // 
            this.tabRVE.Controls.Add(this.pnlRVE);
            this.tabRVE.Location = new System.Drawing.Point(4, 25);
            this.tabRVE.Name = "tabRVE";
            this.tabRVE.Padding = new System.Windows.Forms.Padding(3);
            this.tabRVE.Size = new System.Drawing.Size(778, 707);
            this.tabRVE.TabIndex = 1;
            this.tabRVE.Text = "Element";
            this.tabRVE.UseVisualStyleBackColor = true;
            // 
            // pnlRVE
            // 
            this.pnlRVE.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlRVE.Location = new System.Drawing.Point(6, 3);
            this.pnlRVE.Name = "pnlRVE";
            this.pnlRVE.Size = new System.Drawing.Size(769, 698);
            this.pnlRVE.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1676, 763);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMohrCicle.ResumeLayout(false);
            this.tabRVE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbXY;
        private System.Windows.Forms.ComboBox cmbX;
        private System.Windows.Forms.TextBox txtXY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRVE;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSStress;
        private System.Windows.Forms.Label lblPstress;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblCenterP;
        private System.Windows.Forms.Label lblSigmaAvg;
        private System.Windows.Forms.Label lblAngles;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMohrCicle;
        private System.Windows.Forms.Panel pnlCanva;
        private System.Windows.Forms.TabPage tabRVE;
        private System.Windows.Forms.Panel pnlRVE;
    }
}

