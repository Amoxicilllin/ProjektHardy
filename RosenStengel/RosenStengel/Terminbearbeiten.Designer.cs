namespace RosenStengel
{
    partial class Terminbearbeiten
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
            this.cbNeu = new System.Windows.Forms.CheckBox();
            this.cbBearbeiten = new System.Windows.Forms.CheckBox();
            this.cbLoeschen = new System.Windows.Forms.CheckBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTermin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbNeu
            // 
            this.cbNeu.AutoSize = true;
            this.cbNeu.Location = new System.Drawing.Point(311, 435);
            this.cbNeu.Name = "cbNeu";
            this.cbNeu.Size = new System.Drawing.Size(132, 17);
            this.cbNeu.TabIndex = 0;
            this.cbNeu.Text = "neuen Termin anlegen";
            this.cbNeu.UseVisualStyleBackColor = true;
            // 
            // cbBearbeiten
            // 
            this.cbBearbeiten.AutoSize = true;
            this.cbBearbeiten.Location = new System.Drawing.Point(311, 458);
            this.cbBearbeiten.Name = "cbBearbeiten";
            this.cbBearbeiten.Size = new System.Drawing.Size(112, 17);
            this.cbBearbeiten.TabIndex = 1;
            this.cbBearbeiten.Text = "Termin Bearbeiten";
            this.cbBearbeiten.UseVisualStyleBackColor = true;
            // 
            // cbLoeschen
            // 
            this.cbLoeschen.AutoSize = true;
            this.cbLoeschen.Location = new System.Drawing.Point(311, 481);
            this.cbLoeschen.Name = "cbLoeschen";
            this.cbLoeschen.Size = new System.Drawing.Size(98, 17);
            this.cbLoeschen.TabIndex = 2;
            this.cbLoeschen.Text = "Termin löschen";
            this.cbLoeschen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(472, 435);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 63);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Termin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uhrzeit von";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teilnehmer";
            // 
            // tbTermin
            // 
            this.tbTermin.Location = new System.Drawing.Point(33, 204);
            this.tbTermin.Multiline = true;
            this.tbTermin.Name = "tbTermin";
            this.tbTermin.Size = new System.Drawing.Size(255, 294);
            this.tbTermin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uhrzeit bis";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Terminbearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 527);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTermin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbLoeschen);
            this.Controls.Add(this.cbBearbeiten);
            this.Controls.Add(this.cbNeu);
            this.Name = "Terminbearbeiten";
            this.Text = "Terminbearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbNeu;
        private System.Windows.Forms.CheckBox cbBearbeiten;
        private System.Windows.Forms.CheckBox cbLoeschen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTermin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}