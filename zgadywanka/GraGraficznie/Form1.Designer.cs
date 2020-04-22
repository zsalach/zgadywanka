namespace GraGraficznie
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonLosowanie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.HistoriaGry = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.groupBox2Propozycja = new System.Windows.Forms.GroupBox();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2Propozycja.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(35, 33);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa GRA";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonLosowanie);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Losowanie";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zakres Od";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonLosowanie
            // 
            this.ButtonLosowanie.Location = new System.Drawing.Point(222, 125);
            this.ButtonLosowanie.Name = "ButtonLosowanie";
            this.ButtonLosowanie.Size = new System.Drawing.Size(58, 25);
            this.ButtonLosowanie.TabIndex = 2;
            this.ButtonLosowanie.Text = "Wylosuj";
            this.ButtonLosowanie.UseVisualStyleBackColor = true;
            this.ButtonLosowanie.Click += new System.EventHandler(this.ButtonLosowanie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zakres Do";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 4;
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(257, 33);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 2;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Visible = false;
            // 
            // HistoriaGry
            // 
            this.HistoriaGry.Location = new System.Drawing.Point(55, 492);
            this.HistoriaGry.Name = "HistoriaGry";
            this.HistoriaGry.Size = new System.Drawing.Size(75, 23);
            this.HistoriaGry.TabIndex = 3;
            this.HistoriaGry.Text = "Historia Gry";
            this.HistoriaGry.UseVisualStyleBackColor = true;
            this.HistoriaGry.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 492);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(42, 282);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(0, 13);
            this.labelKomunikat1.TabIndex = 5;
            // 
            // groupBox2Propozycja
            // 
            this.groupBox2Propozycja.Controls.Add(this.labelOdpowiedz);
            this.groupBox2Propozycja.Controls.Add(this.textBoxPropozycja);
            this.groupBox2Propozycja.Controls.Add(this.Zatwierdz);
            this.groupBox2Propozycja.Location = new System.Drawing.Point(35, 298);
            this.groupBox2Propozycja.Name = "groupBox2Propozycja";
            this.groupBox2Propozycja.Size = new System.Drawing.Size(297, 163);
            this.groupBox2Propozycja.TabIndex = 6;
            this.groupBox2Propozycja.TabStop = false;
            this.groupBox2Propozycja.Text = "Propozycja";
            this.groupBox2Propozycja.Visible = false;
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.Location = new System.Drawing.Point(136, 30);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(75, 23);
            this.Zatwierdz.TabIndex = 0;
            this.Zatwierdz.Text = "Zatwierdź";
            this.Zatwierdz.UseVisualStyleBackColor = true;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(20, 30);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 1;
            this.textBoxPropozycja.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(123, 82);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(46, 13);
            this.labelOdpowiedz.TabIndex = 2;
            this.labelOdpowiedz.Text = "Trafiono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 540);
            this.Controls.Add(this.groupBox2Propozycja);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.HistoriaGry);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2Propozycja.ResumeLayout(false);
            this.groupBox2Propozycja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonLosowanie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.Button HistoriaGry;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.GroupBox groupBox2Propozycja;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Button Zatwierdz;
        private System.Windows.Forms.Label labelOdpowiedz;
    }
}

