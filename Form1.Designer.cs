namespace Conversion
{
    partial class frmConversion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBinaire = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(551, 336);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(136, 45);
            this.btnDecimal.TabIndex = 0;
            this.btnDecimal.Text = "Décimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(329, 336);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(136, 45);
            this.btnHexa.TabIndex = 1;
            this.btnHexa.Text = "Hexadécimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            this.btnHexa.Click += new System.EventHandler(this.btnHexa_Click);
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(110, 336);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(136, 45);
            this.btnBinaire.TabIndex = 2;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Binaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Décimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hexadécimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valeur à Convertir";
            // 
            // txtBinaire
            // 
            this.txtBinaire.Location = new System.Drawing.Point(130, 162);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.Size = new System.Drawing.Size(96, 20);
            this.txtBinaire.TabIndex = 7;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(347, 162);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(96, 20);
            this.txtHexa.TabIndex = 8;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(563, 162);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(96, 20);
            this.txtDecimal.TabIndex = 9;
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(292, 262);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(209, 20);
            this.txtValeur.TabIndex = 10;
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinaire);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.btnDecimal);
            this.Name = "frmConversion";
            this.Text = "Conevrsion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBinaire;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtValeur;
    }
}

