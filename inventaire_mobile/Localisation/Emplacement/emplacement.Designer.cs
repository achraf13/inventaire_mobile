namespace inventaire_mobile.Localisation.Emplacement
{
    partial class emplacement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emplacement));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codeEmpla = new System.Windows.Forms.TextBox();
            this.tb_codEmpla = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.Text = "Code d\'emplacement";
            // 
            // tb_codeEmpla
            // 
            this.tb_codeEmpla.Location = new System.Drawing.Point(28, 86);
            this.tb_codeEmpla.Name = "tb_codeEmpla";
            this.tb_codeEmpla.Size = new System.Drawing.Size(185, 21);
            this.tb_codeEmpla.TabIndex = 3;
            this.tb_codeEmpla.TextChanged += new System.EventHandler(this.tb_codeEmpla_TextChanged);
            // 
            // tb_codEmpla
            // 
            this.tb_codEmpla.Image = ((System.Drawing.Image)(resources.GetObject("tb_codEmpla.Image")));
            this.tb_codEmpla.Location = new System.Drawing.Point(140, 143);
            this.tb_codEmpla.Name = "tb_codEmpla";
            this.tb_codEmpla.Size = new System.Drawing.Size(73, 63);
            this.tb_codEmpla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tb_codEmpla.Click += new System.EventHandler(this.tb_codEmpla_Click);
            // 
            // emplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tb_codEmpla);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_codeEmpla);
            this.Menu = this.mainMenu1;
            this.Name = "emplacement";
            this.Text = "emplacement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codeEmpla;
        private System.Windows.Forms.PictureBox tb_codEmpla;

    }
}