
namespace CarEvaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStar5 = new System.Windows.Forms.Label();
            this.labelStar4 = new System.Windows.Forms.Label();
            this.labelStar3 = new System.Windows.Forms.Label();
            this.labelStar2 = new System.Windows.Forms.Label();
            this.labelStar1 = new System.Windows.Forms.Label();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSpecs = new System.Windows.Forms.Label();
            this.labelLuggage = new System.Windows.Forms.Label();
            this.labelPassenger = new System.Windows.Forms.Label();
            this.labelSafety = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDoor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.trackBarLuggage = new System.Windows.Forms.TrackBar();
            this.trackBarPassenger = new System.Windows.Forms.TrackBar();
            this.trackBarSafety = new System.Windows.Forms.TrackBar();
            this.trackBarCost = new System.Windows.Forms.TrackBar();
            this.trackBarDoor = new System.Windows.Forms.TrackBar();
            this.trackBarPrice = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdvance = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelLegend = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialogLearn = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLuggage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSafety)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice)).BeginInit();
            this.tabPageAdvance.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCar);
            this.tabControl1.Controls.Add(this.tabPageAdvance);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCar
            // 
            this.tabPageCar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCar.Controls.Add(this.panel1);
            this.tabPageCar.Controls.Add(this.buttonEvaluate);
            this.tabPageCar.Controls.Add(this.label7);
            this.tabPageCar.Controls.Add(this.pictureBoxCar);
            this.tabPageCar.Controls.Add(this.groupBox1);
            this.tabPageCar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCar.Name = "tabPageCar";
            this.tabPageCar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCar.Size = new System.Drawing.Size(527, 414);
            this.tabPageCar.TabIndex = 0;
            this.tabPageCar.Text = "Evaluation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.labelGrade);
            this.panel1.Controls.Add(this.labelRating);
            this.panel1.Controls.Add(this.labelStar5);
            this.panel1.Controls.Add(this.labelStar4);
            this.panel1.Controls.Add(this.labelStar3);
            this.panel1.Controls.Add(this.labelStar2);
            this.panel1.Controls.Add(this.labelStar1);
            this.panel1.Location = new System.Drawing.Point(174, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 50);
            this.panel1.TabIndex = 5;
            // 
            // labelStar5
            // 
            this.labelStar5.BackColor = System.Drawing.Color.Transparent;
            this.labelStar5.Font = new System.Drawing.Font("Google Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.labelStar5.Location = new System.Drawing.Point(201, 0);
            this.labelStar5.Margin = new System.Windows.Forms.Padding(0);
            this.labelStar5.Name = "labelStar5";
            this.labelStar5.Size = new System.Drawing.Size(35, 50);
            this.labelStar5.TabIndex = 0;
            this.labelStar5.Text = "★";
            this.labelStar5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStar4
            // 
            this.labelStar4.BackColor = System.Drawing.Color.Transparent;
            this.labelStar4.Font = new System.Drawing.Font("Google Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.labelStar4.Location = new System.Drawing.Point(166, 0);
            this.labelStar4.Margin = new System.Windows.Forms.Padding(0);
            this.labelStar4.Name = "labelStar4";
            this.labelStar4.Size = new System.Drawing.Size(35, 50);
            this.labelStar4.TabIndex = 0;
            this.labelStar4.Text = "★";
            this.labelStar4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStar3
            // 
            this.labelStar3.BackColor = System.Drawing.Color.Transparent;
            this.labelStar3.Font = new System.Drawing.Font("Google Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.labelStar3.Location = new System.Drawing.Point(131, 0);
            this.labelStar3.Margin = new System.Windows.Forms.Padding(0);
            this.labelStar3.Name = "labelStar3";
            this.labelStar3.Size = new System.Drawing.Size(35, 50);
            this.labelStar3.TabIndex = 0;
            this.labelStar3.Text = "★";
            this.labelStar3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStar2
            // 
            this.labelStar2.BackColor = System.Drawing.Color.Transparent;
            this.labelStar2.Font = new System.Drawing.Font("Google Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.labelStar2.Location = new System.Drawing.Point(96, 0);
            this.labelStar2.Margin = new System.Windows.Forms.Padding(0);
            this.labelStar2.Name = "labelStar2";
            this.labelStar2.Size = new System.Drawing.Size(35, 50);
            this.labelStar2.TabIndex = 0;
            this.labelStar2.Text = "★";
            this.labelStar2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStar1
            // 
            this.labelStar1.BackColor = System.Drawing.Color.Transparent;
            this.labelStar1.Font = new System.Drawing.Font("Google Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.labelStar1.Location = new System.Drawing.Point(61, 0);
            this.labelStar1.Margin = new System.Windows.Forms.Padding(0);
            this.labelStar1.Name = "labelStar1";
            this.labelStar1.Size = new System.Drawing.Size(35, 50);
            this.labelStar1.TabIndex = 0;
            this.labelStar1.Text = "★";
            this.labelStar1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.buttonEvaluate.FlatAppearance.BorderSize = 0;
            this.buttonEvaluate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.buttonEvaluate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.buttonEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvaluate.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvaluate.ForeColor = System.Drawing.Color.White;
            this.buttonEvaluate.Location = new System.Drawing.Point(18, 343);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(150, 50);
            this.buttonEvaluate.TabIndex = 4;
            this.buttonEvaluate.Text = "Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = false;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Google Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(11, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 40);
            this.label7.TabIndex = 2;
            this.label7.Text = "Car Evaluation";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::CarEvaluation.Properties.Resources.Car01;
            this.pictureBoxCar.Location = new System.Drawing.Point(271, 23);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(230, 100);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 1;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.Click += new System.EventHandler(this.pictureBoxCar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSpecs);
            this.groupBox1.Controls.Add(this.labelLuggage);
            this.groupBox1.Controls.Add(this.labelPassenger);
            this.groupBox1.Controls.Add(this.labelSafety);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelDoor);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.trackBarLuggage);
            this.groupBox1.Controls.Add(this.trackBarPassenger);
            this.groupBox1.Controls.Add(this.trackBarSafety);
            this.groupBox1.Controls.Add(this.trackBarCost);
            this.groupBox1.Controls.Add(this.trackBarDoor);
            this.groupBox1.Controls.Add(this.trackBarPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelSpecs
            // 
            this.labelSpecs.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelSpecs.Location = new System.Drawing.Point(15, 13);
            this.labelSpecs.Name = "labelSpecs";
            this.labelSpecs.Size = new System.Drawing.Size(192, 64);
            this.labelSpecs.TabIndex = 2;
            this.labelSpecs.Text = "Specifications";
            this.labelSpecs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLuggage
            // 
            this.labelLuggage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelLuggage.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuggage.ForeColor = System.Drawing.Color.White;
            this.labelLuggage.Location = new System.Drawing.Point(171, 238);
            this.labelLuggage.Margin = new System.Windows.Forms.Padding(0);
            this.labelLuggage.Name = "labelLuggage";
            this.labelLuggage.Size = new System.Drawing.Size(150, 25);
            this.labelLuggage.TabIndex = 1;
            this.labelLuggage.Text = "Small";
            this.labelLuggage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPassenger
            // 
            this.labelPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelPassenger.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassenger.ForeColor = System.Drawing.Color.White;
            this.labelPassenger.Location = new System.Drawing.Point(15, 238);
            this.labelPassenger.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassenger.Name = "labelPassenger";
            this.labelPassenger.Size = new System.Drawing.Size(150, 25);
            this.labelPassenger.TabIndex = 1;
            this.labelPassenger.Text = "2";
            this.labelPassenger.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSafety
            // 
            this.labelSafety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelSafety.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSafety.ForeColor = System.Drawing.Color.White;
            this.labelSafety.Location = new System.Drawing.Point(327, 238);
            this.labelSafety.Margin = new System.Windows.Forms.Padding(0);
            this.labelSafety.Name = "labelSafety";
            this.labelSafety.Size = new System.Drawing.Size(150, 25);
            this.labelSafety.TabIndex = 1;
            this.labelSafety.Text = "Low";
            this.labelSafety.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCost
            // 
            this.labelCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelCost.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.Color.White;
            this.labelCost.Location = new System.Drawing.Point(171, 142);
            this.labelCost.Margin = new System.Windows.Forms.Padding(0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(150, 25);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "$";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDoor
            // 
            this.labelDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelDoor.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoor.ForeColor = System.Drawing.Color.White;
            this.labelDoor.Location = new System.Drawing.Point(327, 142);
            this.labelDoor.Margin = new System.Windows.Forms.Padding(0);
            this.labelDoor.Name = "labelDoor";
            this.labelDoor.Size = new System.Drawing.Size(150, 25);
            this.labelDoor.TabIndex = 1;
            this.labelDoor.Text = "2";
            this.labelDoor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelPrice.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(15, 142);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(150, 25);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "$";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarLuggage
            // 
            this.trackBarLuggage.AutoSize = false;
            this.trackBarLuggage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.trackBarLuggage.LargeChange = 1;
            this.trackBarLuggage.Location = new System.Drawing.Point(171, 203);
            this.trackBarLuggage.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarLuggage.Maximum = 3;
            this.trackBarLuggage.Minimum = 1;
            this.trackBarLuggage.Name = "trackBarLuggage";
            this.trackBarLuggage.Size = new System.Drawing.Size(150, 35);
            this.trackBarLuggage.TabIndex = 1;
            this.trackBarLuggage.Value = 1;
            this.trackBarLuggage.Scroll += new System.EventHandler(this.trackBarPrice_Scroll);
            this.trackBarLuggage.ValueChanged += new System.EventHandler(this.trackBarLuggage_ValueChange);
            // 
            // trackBarPassenger
            // 
            this.trackBarPassenger.AutoSize = false;
            this.trackBarPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.trackBarPassenger.LargeChange = 1;
            this.trackBarPassenger.Location = new System.Drawing.Point(15, 203);
            this.trackBarPassenger.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarPassenger.Maximum = 3;
            this.trackBarPassenger.Minimum = 1;
            this.trackBarPassenger.Name = "trackBarPassenger";
            this.trackBarPassenger.Size = new System.Drawing.Size(150, 35);
            this.trackBarPassenger.TabIndex = 1;
            this.trackBarPassenger.Value = 1;
            this.trackBarPassenger.Scroll += new System.EventHandler(this.trackBarPrice_Scroll);
            this.trackBarPassenger.ValueChanged += new System.EventHandler(this.trackBarPassenger_ValueChange);
            // 
            // trackBarSafety
            // 
            this.trackBarSafety.AutoSize = false;
            this.trackBarSafety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.trackBarSafety.LargeChange = 1;
            this.trackBarSafety.Location = new System.Drawing.Point(327, 203);
            this.trackBarSafety.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarSafety.Maximum = 3;
            this.trackBarSafety.Minimum = 1;
            this.trackBarSafety.Name = "trackBarSafety";
            this.trackBarSafety.Size = new System.Drawing.Size(150, 35);
            this.trackBarSafety.TabIndex = 1;
            this.trackBarSafety.Value = 1;
            this.trackBarSafety.Scroll += new System.EventHandler(this.trackBarPrice_Scroll);
            this.trackBarSafety.ValueChanged += new System.EventHandler(this.trackBarSafety_ValueChange);
            // 
            // trackBarCost
            // 
            this.trackBarCost.AutoSize = false;
            this.trackBarCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.trackBarCost.LargeChange = 1;
            this.trackBarCost.Location = new System.Drawing.Point(171, 107);
            this.trackBarCost.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarCost.Maximum = -1;
            this.trackBarCost.Minimum = -4;
            this.trackBarCost.Name = "trackBarCost";
            this.trackBarCost.Size = new System.Drawing.Size(150, 35);
            this.trackBarCost.TabIndex = 1;
            this.trackBarCost.Value = -4;
            this.trackBarCost.Scroll += new System.EventHandler(this.trackBarPrice_Scroll);
            this.trackBarCost.ValueChanged += new System.EventHandler(this.trackBarCost_ValueChange);
            // 
            // trackBarDoor
            // 
            this.trackBarDoor.AutoSize = false;
            this.trackBarDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.trackBarDoor.LargeChange = 1;
            this.trackBarDoor.Location = new System.Drawing.Point(327, 107);
            this.trackBarDoor.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarDoor.Maximum = 5;
            this.trackBarDoor.Minimum = 2;
            this.trackBarDoor.Name = "trackBarDoor";
            this.trackBarDoor.Size = new System.Drawing.Size(150, 35);
            this.trackBarDoor.TabIndex = 1;
            this.trackBarDoor.Value = 2;
            this.trackBarDoor.Scroll += new System.EventHandler(this.trackBarPrice_Scroll);
            this.trackBarDoor.ValueChanged += new System.EventHandler(this.trackBarDoor_ValueChange);
            // 
            // trackBarPrice
            // 
            this.trackBarPrice.AutoSize = false;
            this.trackBarPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.trackBarPrice.LargeChange = 1;
            this.trackBarPrice.Location = new System.Drawing.Point(15, 107);
            this.trackBarPrice.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarPrice.Maximum = -1;
            this.trackBarPrice.Minimum = -4;
            this.trackBarPrice.Name = "trackBarPrice";
            this.trackBarPrice.Size = new System.Drawing.Size(150, 35);
            this.trackBarPrice.TabIndex = 1;
            this.trackBarPrice.Value = -4;
            this.trackBarPrice.Scroll += new System.EventHandler(this.trackBarPrice_Scroll);
            this.trackBarPrice.ValueChanged += new System.EventHandler(this.trackBarPrice_ValueChange);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(171, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Luggage Boot";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Passengers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(327, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Safety";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(171, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maintenance Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(327, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doors";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdvance
            // 
            this.tabPageAdvance.Controls.Add(this.groupBox5);
            this.tabPageAdvance.Controls.Add(this.groupBox4);
            this.tabPageAdvance.Controls.Add(this.groupBox3);
            this.tabPageAdvance.Controls.Add(this.groupBox2);
            this.tabPageAdvance.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvance.Name = "tabPageAdvance";
            this.tabPageAdvance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvance.Size = new System.Drawing.Size(527, 414);
            this.tabPageAdvance.TabIndex = 1;
            this.tabPageAdvance.Text = "Advance";
            this.tabPageAdvance.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(129, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 160);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Test";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelLegend);
            this.groupBox4.Location = new System.Drawing.Point(8, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 245);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Legend";
            // 
            // panelLegend
            // 
            this.panelLegend.Location = new System.Drawing.Point(6, 19);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(103, 220);
            this.panelLegend.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelMap);
            this.groupBox3.Location = new System.Drawing.Point(129, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 230);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Map";
            // 
            // panelMap
            // 
            this.panelMap.Location = new System.Drawing.Point(6, 19);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(201, 201);
            this.panelMap.TabIndex = 2;
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMap_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLearn);
            this.groupBox2.Controls.Add(this.buttonTest);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 145);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SOFM";
            // 
            // buttonLearn
            // 
            this.buttonLearn.Location = new System.Drawing.Point(6, 19);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(100, 23);
            this.buttonLearn.TabIndex = 0;
            this.buttonLearn.Text = "Learn Dataset";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(6, 106);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(100, 23);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(6, 48);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load Map";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 77);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save Map";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialogLearn
            // 
            this.openFileDialogLearn.DefaultExt = "sofm";
            this.openFileDialogLearn.Filter = "Text Files | *.txt";
            this.openFileDialogLearn.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLearn_FileOk);
            // 
            // openFileDialogLoad
            // 
            this.openFileDialogLoad.Filter = "SOFM files | *.sofm";
            this.openFileDialogLoad.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLoad_FileOk);
            // 
            // saveFileDialogSave
            // 
            this.saveFileDialogSave.DefaultExt = "sofm";
            this.saveFileDialogSave.Filter = "SOFM files | *.sofm";
            this.saveFileDialogSave.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogSave_FileOk);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.labelRating.Location = new System.Drawing.Point(4, 16);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(54, 18);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating:";
            // 
            // labelGrade
            // 
            this.labelGrade.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.Color.White;
            this.labelGrade.Location = new System.Drawing.Point(239, 0);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(100, 50);
            this.labelGrade.TabIndex = 2;
            this.labelGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(532, 436);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Evaluation";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCar.ResumeLayout(false);
            this.tabPageCar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLuggage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSafety)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice)).EndInit();
            this.tabPageAdvance.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCar;
        private System.Windows.Forms.TabPage tabPageAdvance;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.OpenFileDialog openFileDialogLearn;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSave;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLuggage;
        private System.Windows.Forms.Label labelPassenger;
        private System.Windows.Forms.Label labelSafety;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDoor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TrackBar trackBarLuggage;
        private System.Windows.Forms.TrackBar trackBarPassenger;
        private System.Windows.Forms.TrackBar trackBarSafety;
        private System.Windows.Forms.TrackBar trackBarCost;
        private System.Windows.Forms.TrackBar trackBarDoor;
        private System.Windows.Forms.TrackBar trackBarPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSpecs;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel panelLegend;
        private System.Windows.Forms.Label labelStar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStar5;
        private System.Windows.Forms.Label labelStar4;
        private System.Windows.Forms.Label labelStar3;
        private System.Windows.Forms.Label labelStar2;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelGrade;
    }
}

