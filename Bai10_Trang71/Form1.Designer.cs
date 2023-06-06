namespace Bai10_Trang71
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
			this.grbCountry = new System.Windows.Forms.GroupBox();
			this.rdoTheUSA = new System.Windows.Forms.RadioButton();
			this.rdoItaly = new System.Windows.Forms.RadioButton();
			this.rdoTheUK = new System.Windows.Forms.RadioButton();
			this.rdoTurkey = new System.Windows.Forms.RadioButton();
			this.rdoSpain = new System.Windows.Forms.RadioButton();
			this.rdoHungary = new System.Windows.Forms.RadioButton();
			this.rdoJapan = new System.Windows.Forms.RadioButton();
			this.rdoFrance = new System.Windows.Forms.RadioButton();
			this.grbCapital = new System.Windows.Forms.GroupBox();
			this.rdoParis = new System.Windows.Forms.RadioButton();
			this.rdoBudapest = new System.Windows.Forms.RadioButton();
			this.rdoAnkara = new System.Windows.Forms.RadioButton();
			this.rdoLondon = new System.Windows.Forms.RadioButton();
			this.rdoMadrid = new System.Windows.Forms.RadioButton();
			this.rdoRome = new System.Windows.Forms.RadioButton();
			this.rdoTokyo = new System.Windows.Forms.RadioButton();
			this.rdoBuenosAires = new System.Windows.Forms.RadioButton();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.grbCountry.SuspendLayout();
			this.grbCapital.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbCountry
			// 
			this.grbCountry.Controls.Add(this.rdoTheUSA);
			this.grbCountry.Controls.Add(this.rdoItaly);
			this.grbCountry.Controls.Add(this.rdoTheUK);
			this.grbCountry.Controls.Add(this.rdoTurkey);
			this.grbCountry.Controls.Add(this.rdoSpain);
			this.grbCountry.Controls.Add(this.rdoHungary);
			this.grbCountry.Controls.Add(this.rdoJapan);
			this.grbCountry.Controls.Add(this.rdoFrance);
			this.grbCountry.Location = new System.Drawing.Point(25, 19);
			this.grbCountry.Name = "grbCountry";
			this.grbCountry.Size = new System.Drawing.Size(203, 404);
			this.grbCountry.TabIndex = 0;
			this.grbCountry.TabStop = false;
			this.grbCountry.Text = "Country";
			// 
			// rdoTheUSA
			// 
			this.rdoTheUSA.AutoSize = true;
			this.rdoTheUSA.Location = new System.Drawing.Point(21, 340);
			this.rdoTheUSA.Name = "rdoTheUSA";
			this.rdoTheUSA.Size = new System.Drawing.Size(97, 24);
			this.rdoTheUSA.TabIndex = 7;
			this.rdoTheUSA.TabStop = true;
			this.rdoTheUSA.Text = "The USA";
			this.rdoTheUSA.UseVisualStyleBackColor = true;
			this.rdoTheUSA.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoItaly
			// 
			this.rdoItaly.AutoSize = true;
			this.rdoItaly.Location = new System.Drawing.Point(21, 293);
			this.rdoItaly.Name = "rdoItaly";
			this.rdoItaly.Size = new System.Drawing.Size(60, 24);
			this.rdoItaly.TabIndex = 6;
			this.rdoItaly.TabStop = true;
			this.rdoItaly.Text = "Italy";
			this.rdoItaly.UseVisualStyleBackColor = true;
			this.rdoItaly.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoTheUK
			// 
			this.rdoTheUK.AutoSize = true;
			this.rdoTheUK.Location = new System.Drawing.Point(21, 249);
			this.rdoTheUK.Name = "rdoTheUK";
			this.rdoTheUK.Size = new System.Drawing.Size(86, 24);
			this.rdoTheUK.TabIndex = 5;
			this.rdoTheUK.TabStop = true;
			this.rdoTheUK.Text = "The UK";
			this.rdoTheUK.UseVisualStyleBackColor = true;
			this.rdoTheUK.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoTurkey
			// 
			this.rdoTurkey.AutoSize = true;
			this.rdoTurkey.Location = new System.Drawing.Point(21, 203);
			this.rdoTurkey.Name = "rdoTurkey";
			this.rdoTurkey.Size = new System.Drawing.Size(80, 24);
			this.rdoTurkey.TabIndex = 4;
			this.rdoTurkey.TabStop = true;
			this.rdoTurkey.Text = "Turkey";
			this.rdoTurkey.UseVisualStyleBackColor = true;
			this.rdoTurkey.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoSpain
			// 
			this.rdoSpain.AutoSize = true;
			this.rdoSpain.Location = new System.Drawing.Point(21, 158);
			this.rdoSpain.Name = "rdoSpain";
			this.rdoSpain.Size = new System.Drawing.Size(72, 24);
			this.rdoSpain.TabIndex = 3;
			this.rdoSpain.TabStop = true;
			this.rdoSpain.Text = "Spain";
			this.rdoSpain.UseVisualStyleBackColor = true;
			this.rdoSpain.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoHungary
			// 
			this.rdoHungary.AutoSize = true;
			this.rdoHungary.Location = new System.Drawing.Point(21, 116);
			this.rdoHungary.Name = "rdoHungary";
			this.rdoHungary.Size = new System.Drawing.Size(93, 24);
			this.rdoHungary.TabIndex = 2;
			this.rdoHungary.TabStop = true;
			this.rdoHungary.Text = "Hungary";
			this.rdoHungary.UseVisualStyleBackColor = true;
			this.rdoHungary.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoJapan
			// 
			this.rdoJapan.AutoSize = true;
			this.rdoJapan.Location = new System.Drawing.Point(21, 74);
			this.rdoJapan.Name = "rdoJapan";
			this.rdoJapan.Size = new System.Drawing.Size(75, 24);
			this.rdoJapan.TabIndex = 1;
			this.rdoJapan.TabStop = true;
			this.rdoJapan.Text = "Japan";
			this.rdoJapan.UseVisualStyleBackColor = true;
			this.rdoJapan.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// rdoFrance
			// 
			this.rdoFrance.AutoSize = true;
			this.rdoFrance.Location = new System.Drawing.Point(21, 34);
			this.rdoFrance.Name = "rdoFrance";
			this.rdoFrance.Size = new System.Drawing.Size(82, 24);
			this.rdoFrance.TabIndex = 0;
			this.rdoFrance.TabStop = true;
			this.rdoFrance.Text = "France";
			this.rdoFrance.UseVisualStyleBackColor = true;
			this.rdoFrance.CheckedChanged += new System.EventHandler(this.Country_CheckedChanged);
			// 
			// grbCapital
			// 
			this.grbCapital.Controls.Add(this.rdoParis);
			this.grbCapital.Controls.Add(this.rdoBudapest);
			this.grbCapital.Controls.Add(this.rdoAnkara);
			this.grbCapital.Controls.Add(this.rdoLondon);
			this.grbCapital.Controls.Add(this.rdoMadrid);
			this.grbCapital.Controls.Add(this.rdoRome);
			this.grbCapital.Controls.Add(this.rdoTokyo);
			this.grbCapital.Controls.Add(this.rdoBuenosAires);
			this.grbCapital.Location = new System.Drawing.Point(264, 19);
			this.grbCapital.Name = "grbCapital";
			this.grbCapital.Size = new System.Drawing.Size(203, 404);
			this.grbCapital.TabIndex = 8;
			this.grbCapital.TabStop = false;
			this.grbCapital.Text = "Capital";
			// 
			// rdoParis
			// 
			this.rdoParis.AutoSize = true;
			this.rdoParis.Location = new System.Drawing.Point(21, 340);
			this.rdoParis.Name = "rdoParis";
			this.rdoParis.Size = new System.Drawing.Size(69, 24);
			this.rdoParis.TabIndex = 7;
			this.rdoParis.TabStop = true;
			this.rdoParis.Text = "Paris";
			this.rdoParis.UseVisualStyleBackColor = true;
			this.rdoParis.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoBudapest
			// 
			this.rdoBudapest.AutoSize = true;
			this.rdoBudapest.Location = new System.Drawing.Point(21, 293);
			this.rdoBudapest.Name = "rdoBudapest";
			this.rdoBudapest.Size = new System.Drawing.Size(101, 24);
			this.rdoBudapest.TabIndex = 6;
			this.rdoBudapest.TabStop = true;
			this.rdoBudapest.Text = "Budapest";
			this.rdoBudapest.UseVisualStyleBackColor = true;
			this.rdoBudapest.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoAnkara
			// 
			this.rdoAnkara.AutoSize = true;
			this.rdoAnkara.Location = new System.Drawing.Point(21, 249);
			this.rdoAnkara.Name = "rdoAnkara";
			this.rdoAnkara.Size = new System.Drawing.Size(82, 24);
			this.rdoAnkara.TabIndex = 5;
			this.rdoAnkara.TabStop = true;
			this.rdoAnkara.Text = "Ankara";
			this.rdoAnkara.UseVisualStyleBackColor = true;
			this.rdoAnkara.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoLondon
			// 
			this.rdoLondon.AutoSize = true;
			this.rdoLondon.Location = new System.Drawing.Point(21, 203);
			this.rdoLondon.Name = "rdoLondon";
			this.rdoLondon.Size = new System.Drawing.Size(85, 24);
			this.rdoLondon.TabIndex = 4;
			this.rdoLondon.TabStop = true;
			this.rdoLondon.Text = "London";
			this.rdoLondon.UseVisualStyleBackColor = true;
			this.rdoLondon.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoMadrid
			// 
			this.rdoMadrid.AutoSize = true;
			this.rdoMadrid.Location = new System.Drawing.Point(21, 158);
			this.rdoMadrid.Name = "rdoMadrid";
			this.rdoMadrid.Size = new System.Drawing.Size(81, 24);
			this.rdoMadrid.TabIndex = 3;
			this.rdoMadrid.TabStop = true;
			this.rdoMadrid.Text = "Madrid";
			this.rdoMadrid.UseVisualStyleBackColor = true;
			this.rdoMadrid.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoRome
			// 
			this.rdoRome.AutoSize = true;
			this.rdoRome.Location = new System.Drawing.Point(21, 116);
			this.rdoRome.Name = "rdoRome";
			this.rdoRome.Size = new System.Drawing.Size(74, 24);
			this.rdoRome.TabIndex = 2;
			this.rdoRome.TabStop = true;
			this.rdoRome.Text = "Rome";
			this.rdoRome.UseVisualStyleBackColor = true;
			this.rdoRome.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoTokyo
			// 
			this.rdoTokyo.AutoSize = true;
			this.rdoTokyo.Location = new System.Drawing.Point(21, 74);
			this.rdoTokyo.Name = "rdoTokyo";
			this.rdoTokyo.Size = new System.Drawing.Size(74, 24);
			this.rdoTokyo.TabIndex = 1;
			this.rdoTokyo.TabStop = true;
			this.rdoTokyo.Text = "Tokyo";
			this.rdoTokyo.UseVisualStyleBackColor = true;
			this.rdoTokyo.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// rdoBuenosAires
			// 
			this.rdoBuenosAires.AutoSize = true;
			this.rdoBuenosAires.Location = new System.Drawing.Point(21, 34);
			this.rdoBuenosAires.Name = "rdoBuenosAires";
			this.rdoBuenosAires.Size = new System.Drawing.Size(118, 24);
			this.rdoBuenosAires.TabIndex = 0;
			this.rdoBuenosAires.TabStop = true;
			this.rdoBuenosAires.Text = "Washington";
			this.rdoBuenosAires.UseVisualStyleBackColor = true;
			this.rdoBuenosAires.CheckedChanged += new System.EventHandler(this.Capital_checkedChanged);
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Location = new System.Drawing.Point(28, 438);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(0, 20);
			this.lblKetQua.TabIndex = 9;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(351, 506);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(124, 31);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(495, 562);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.grbCapital);
			this.Controls.Add(this.grbCountry);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Red;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Capital of country";
			this.grbCountry.ResumeLayout(false);
			this.grbCountry.PerformLayout();
			this.grbCapital.ResumeLayout(false);
			this.grbCapital.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCountry;
        private System.Windows.Forms.RadioButton rdoFrance;
        private System.Windows.Forms.RadioButton rdoTheUSA;
        private System.Windows.Forms.RadioButton rdoItaly;
        private System.Windows.Forms.RadioButton rdoTheUK;
        private System.Windows.Forms.RadioButton rdoTurkey;
        private System.Windows.Forms.RadioButton rdoSpain;
        private System.Windows.Forms.RadioButton rdoHungary;
        private System.Windows.Forms.RadioButton rdoJapan;
        private System.Windows.Forms.GroupBox grbCapital;
        private System.Windows.Forms.RadioButton rdoParis;
        private System.Windows.Forms.RadioButton rdoBudapest;
        private System.Windows.Forms.RadioButton rdoAnkara;
        private System.Windows.Forms.RadioButton rdoLondon;
        private System.Windows.Forms.RadioButton rdoMadrid;
        private System.Windows.Forms.RadioButton rdoRome;
        private System.Windows.Forms.RadioButton rdoTokyo;
        private System.Windows.Forms.RadioButton rdoBuenosAires;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnExit;
    }
}

