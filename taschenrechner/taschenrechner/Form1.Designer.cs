namespace taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndivi = new System.Windows.Forms.Button();
            this.tbxzahl1 = new System.Windows.Forms.TextBox();
            this.tbxop = new System.Windows.Forms.TextBox();
            this.tbxzahl2 = new System.Windows.Forms.TextBox();
            this.tbxergebnis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btngleich = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(205, 176);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(47, 37);
            this.btnmulti.TabIndex = 10;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnmin
            // 
            this.btnmin.Location = new System.Drawing.Point(258, 133);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(47, 37);
            this.btnmin.TabIndex = 11;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(205, 133);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(47, 37);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndivi
            // 
            this.btndivi.Location = new System.Drawing.Point(258, 176);
            this.btndivi.Name = "btndivi";
            this.btndivi.Size = new System.Drawing.Size(47, 37);
            this.btndivi.TabIndex = 13;
            this.btndivi.Text = "/";
            this.btndivi.UseVisualStyleBackColor = true;
            this.btndivi.Click += new System.EventHandler(this.btndivi_Click);
            // 
            // tbxzahl1
            // 
            this.tbxzahl1.Location = new System.Drawing.Point(61, 64);
            this.tbxzahl1.Name = "tbxzahl1";
            this.tbxzahl1.Size = new System.Drawing.Size(50, 20);
            this.tbxzahl1.TabIndex = 16;
            this.tbxzahl1.TextChanged += new System.EventHandler(this.tbxzahl1_TextChanged);
            // 
            // tbxop
            // 
            this.tbxop.Location = new System.Drawing.Point(117, 64);
            this.tbxop.Name = "tbxop";
            this.tbxop.Size = new System.Drawing.Size(22, 20);
            this.tbxop.TabIndex = 18;
            // 
            // tbxzahl2
            // 
            this.tbxzahl2.Location = new System.Drawing.Point(145, 64);
            this.tbxzahl2.Name = "tbxzahl2";
            this.tbxzahl2.Size = new System.Drawing.Size(50, 20);
            this.tbxzahl2.TabIndex = 19;
            this.tbxzahl2.TextChanged += new System.EventHandler(this.tbxzahl2_TextChanged);
            // 
            // tbxergebnis
            // 
            this.tbxergebnis.Location = new System.Drawing.Point(85, 123);
            this.tbxergebnis.Name = "tbxergebnis";
            this.tbxergebnis.Size = new System.Drawing.Size(87, 20);
            this.tbxergebnis.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "op";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "zahl \'2\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "zahl \'1\'";
            // 
            // btngleich
            // 
            this.btngleich.Location = new System.Drawing.Point(258, 90);
            this.btngleich.Name = "btngleich";
            this.btngleich.Size = new System.Drawing.Size(47, 37);
            this.btngleich.TabIndex = 27;
            this.btngleich.Text = "=";
            this.btngleich.UseVisualStyleBackColor = true;
            this.btngleich.Click += new System.EventHandler(this.btngleich_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(205, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(47, 37);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ergebnis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btngleich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxergebnis);
            this.Controls.Add(this.tbxzahl2);
            this.Controls.Add(this.tbxop);
            this.Controls.Add(this.tbxzahl1);
            this.Controls.Add(this.btndivi);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnmulti);
            this.Name = "Form1";
            this.Text = ",0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndivi;
        private System.Windows.Forms.TextBox tbxzahl1;
        private System.Windows.Forms.TextBox tbxop;
        private System.Windows.Forms.TextBox tbxzahl2;
        private System.Windows.Forms.TextBox tbxergebnis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngleich;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
    }
}

