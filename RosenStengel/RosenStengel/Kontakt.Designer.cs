namespace RosenStengel
{
    partial class Kontakt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.cbNeu = new System.Windows.Forms.CheckBox();
            this.cbBearbeiten = new System.Windows.Forms.CheckBox();
            this.cbLoeschen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nachname,
            this.Vorname,
            this.Adresse,
            this.Telefon,
            this.EMail});
            this.dataGridView1.Location = new System.Drawing.Point(39, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(532, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "E-Mail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontaktliste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bild";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 211);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(130, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(143, 262);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(130, 20);
            this.tbVorname.TabIndex = 9;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(143, 321);
            this.tbAdresse.Multiline = true;
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(130, 159);
            this.tbAdresse.TabIndex = 10;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(410, 213);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(130, 20);
            this.tbTelefon.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(410, 264);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(130, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(472, 491);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 70);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbNeu
            // 
            this.cbNeu.AutoSize = true;
            this.cbNeu.Location = new System.Drawing.Point(322, 491);
            this.cbNeu.Name = "cbNeu";
            this.cbNeu.Size = new System.Drawing.Size(121, 17);
            this.cbNeu.TabIndex = 14;
            this.cbNeu.Text = "neuen Satz anlegen";
            this.cbNeu.UseVisualStyleBackColor = true;
            this.cbNeu.CheckedChanged += new System.EventHandler(this.cbNeu_CheckedChanged);
            // 
            // cbBearbeiten
            // 
            this.cbBearbeiten.AutoSize = true;
            this.cbBearbeiten.Location = new System.Drawing.Point(322, 519);
            this.cbBearbeiten.Name = "cbBearbeiten";
            this.cbBearbeiten.Size = new System.Drawing.Size(100, 17);
            this.cbBearbeiten.TabIndex = 15;
            this.cbBearbeiten.Text = "Satz bearbeiten";
            this.cbBearbeiten.UseVisualStyleBackColor = true;
            this.cbBearbeiten.CheckedChanged += new System.EventHandler(this.cbBearbeiten_CheckedChanged);
            // 
            // cbLoeschen
            // 
            this.cbLoeschen.AutoSize = true;
            this.cbLoeschen.Location = new System.Drawing.Point(322, 544);
            this.cbLoeschen.Name = "cbLoeschen";
            this.cbLoeschen.Size = new System.Drawing.Size(87, 17);
            this.cbLoeschen.TabIndex = 16;
            this.cbLoeschen.Text = "Satz löschen";
            this.cbLoeschen.UseVisualStyleBackColor = true;
            this.cbLoeschen.CheckedChanged += new System.EventHandler(this.cbLoeschen_CheckedChanged);
            // 
            // Kontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 585);
            this.Controls.Add(this.cbLoeschen);
            this.Controls.Add(this.cbBearbeiten);
            this.Controls.Add(this.cbNeu);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kontakt";
            this.Text = "Kontakt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kontakt_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbNeu;
        private System.Windows.Forms.CheckBox cbBearbeiten;
        private System.Windows.Forms.CheckBox cbLoeschen;
    }
}