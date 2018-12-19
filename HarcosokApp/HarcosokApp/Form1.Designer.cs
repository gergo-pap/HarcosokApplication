namespace HarcosokApplication
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
            this.labelHarcosLetrehozas = new System.Windows.Forms.Label();
            this.labelNevHarcos = new System.Windows.Forms.Label();
            this.LetrehozasButton = new System.Windows.Forms.Button();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.labelKepessegHozzaad = new System.Windows.Forms.Label();
            this.labelNevKepesseg = new System.Windows.Forms.Label();
            this.labelHasznalo = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.labelLeiras = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.labelHarcosok = new System.Windows.Forms.Label();
            this.labelKepessegei = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.kepessegekLeirasatextBox = new System.Windows.Forms.TextBox();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHarcosLetrehozas
            // 
            this.labelHarcosLetrehozas.AutoSize = true;
            this.labelHarcosLetrehozas.Location = new System.Drawing.Point(13, 13);
            this.labelHarcosLetrehozas.Name = "labelHarcosLetrehozas";
            this.labelHarcosLetrehozas.Size = new System.Drawing.Size(102, 13);
            this.labelHarcosLetrehozas.TabIndex = 0;
            this.labelHarcosLetrehozas.Text = "Harcos Létrehozása";
            // 
            // labelNevHarcos
            // 
            this.labelNevHarcos.AutoSize = true;
            this.labelNevHarcos.Location = new System.Drawing.Point(13, 32);
            this.labelNevHarcos.Name = "labelNevHarcos";
            this.labelNevHarcos.Size = new System.Drawing.Size(30, 13);
            this.labelNevHarcos.TabIndex = 1;
            this.labelNevHarcos.Text = "Név:";
            // 
            // LetrehozasButton
            // 
            this.LetrehozasButton.Location = new System.Drawing.Point(161, 28);
            this.LetrehozasButton.Name = "LetrehozasButton";
            this.LetrehozasButton.Size = new System.Drawing.Size(75, 23);
            this.LetrehozasButton.TabIndex = 2;
            this.LetrehozasButton.Text = "Létrehozás";
            this.LetrehozasButton.UseVisualStyleBackColor = true;
            this.LetrehozasButton.Click += new System.EventHandler(this.LetrehozasButton_Click);
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(48, 29);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(100, 20);
            this.harcosNeveTextBox.TabIndex = 3;
            // 
            // labelKepessegHozzaad
            // 
            this.labelKepessegHozzaad.AutoSize = true;
            this.labelKepessegHozzaad.Location = new System.Drawing.Point(13, 74);
            this.labelKepessegHozzaad.Name = "labelKepessegHozzaad";
            this.labelKepessegHozzaad.Size = new System.Drawing.Size(114, 13);
            this.labelKepessegHozzaad.TabIndex = 4;
            this.labelKepessegHozzaad.Text = "Képesség hozzáadása";
            // 
            // labelNevKepesseg
            // 
            this.labelNevKepesseg.AutoSize = true;
            this.labelNevKepesseg.Location = new System.Drawing.Point(13, 134);
            this.labelNevKepesseg.Name = "labelNevKepesseg";
            this.labelNevKepesseg.Size = new System.Drawing.Size(30, 13);
            this.labelNevKepesseg.TabIndex = 5;
            this.labelNevKepesseg.Text = "Név:";
            // 
            // labelHasznalo
            // 
            this.labelHasznalo.AutoSize = true;
            this.labelHasznalo.Location = new System.Drawing.Point(13, 94);
            this.labelHasznalo.Name = "labelHasznalo";
            this.labelHasznalo.Size = new System.Drawing.Size(54, 13);
            this.labelHasznalo.TabIndex = 6;
            this.labelHasznalo.Text = "Használó:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(74, 91);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(121, 21);
            this.hasznaloComboBox.TabIndex = 7;
            // 
            // labelLeiras
            // 
            this.labelLeiras.AutoSize = true;
            this.labelLeiras.Location = new System.Drawing.Point(206, 74);
            this.labelLeiras.Name = "labelLeiras";
            this.labelLeiras.Size = new System.Drawing.Size(40, 13);
            this.labelLeiras.TabIndex = 9;
            this.labelLeiras.Text = "Leírás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(209, 94);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(159, 72);
            this.leirasTextBox.TabIndex = 10;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(16, 177);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 11;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // labelHarcosok
            // 
            this.labelHarcosok.AutoSize = true;
            this.labelHarcosok.Location = new System.Drawing.Point(13, 214);
            this.labelHarcosok.Name = "labelHarcosok";
            this.labelHarcosok.Size = new System.Drawing.Size(56, 13);
            this.labelHarcosok.TabIndex = 12;
            this.labelHarcosok.Text = "Harcosok:";
            // 
            // labelKepessegei
            // 
            this.labelKepessegei.AutoSize = true;
            this.labelKepessegei.Location = new System.Drawing.Point(146, 214);
            this.labelKepessegei.Name = "labelKepessegei";
            this.labelKepessegei.Size = new System.Drawing.Size(66, 13);
            this.labelKepessegei.TabIndex = 13;
            this.labelKepessegei.Text = "Képeeségei:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Képesség leírása";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(16, 230);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 199);
            this.harcosokListBox.TabIndex = 15;
            this.harcosokListBox.SelectedIndexChanged += new System.EventHandler(this.harcosokListBox_SelectedIndexChanged);
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(149, 230);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(120, 199);
            this.kepessegekListBox.TabIndex = 16;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegekListBox_SelectedIndexChanged);
            // 
            // kepessegekLeirasatextBox
            // 
            this.kepessegekLeirasatextBox.Location = new System.Drawing.Point(278, 230);
            this.kepessegekLeirasatextBox.Multiline = true;
            this.kepessegekLeirasatextBox.Name = "kepessegekLeirasatextBox";
            this.kepessegekLeirasatextBox.Size = new System.Drawing.Size(191, 199);
            this.kepessegekLeirasatextBox.TabIndex = 17;
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(278, 435);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 18;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            this.buttonModosit.Click += new System.EventHandler(this.buttonModosit_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(149, 435);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 19;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(74, 134);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(121, 20);
            this.kepessegNeveTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 476);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonModosit);
            this.Controls.Add(this.kepessegekLeirasatextBox);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKepessegei);
            this.Controls.Add(this.labelHarcosok);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.labelLeiras);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.labelHasznalo);
            this.Controls.Add(this.labelNevKepesseg);
            this.Controls.Add(this.labelKepessegHozzaad);
            this.Controls.Add(this.harcosNeveTextBox);
            this.Controls.Add(this.LetrehozasButton);
            this.Controls.Add(this.labelNevHarcos);
            this.Controls.Add(this.labelHarcosLetrehozas);
            this.Name = "Form1";
            this.Text = "Harcosok Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHarcosLetrehozas;
        private System.Windows.Forms.Label labelNevHarcos;
        private System.Windows.Forms.Button LetrehozasButton;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Label labelKepessegHozzaad;
        private System.Windows.Forms.Label labelNevKepesseg;
        private System.Windows.Forms.Label labelHasznalo;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label labelLeiras;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Label labelHarcosok;
        private System.Windows.Forms.Label labelKepessegei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.TextBox kepessegekLeirasatextBox;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
    }
}

