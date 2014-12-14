namespace inventaire_mobile.Localisation.Bien
{
    partial class bien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bien));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codeBienManuel = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_scanBien = new System.Windows.Forms.TextBox();
            this.cb_etat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Code du bien";
            // 
            // tb_codeBienManuel
            // 
            this.tb_codeBienManuel.Location = new System.Drawing.Point(37, 79);
            this.tb_codeBienManuel.Name = "tb_codeBienManuel";
            this.tb_codeBienManuel.Size = new System.Drawing.Size(173, 21);
            this.tb_codeBienManuel.TabIndex = 1;
            this.tb_codeBienManuel.TextChanged += new System.EventHandler(this.tb_codeBienManuel_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.Text = "Scan automatique";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // tb_scanBien
            // 
            this.tb_scanBien.Location = new System.Drawing.Point(37, 31);
            this.tb_scanBien.Name = "tb_scanBien";
            this.tb_scanBien.Size = new System.Drawing.Size(173, 21);
            this.tb_scanBien.TabIndex = 8;
            this.tb_scanBien.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cb_etat
            // 
            this.cb_etat.DisplayMember = "dsgEtat";
            this.cb_etat.Location = new System.Drawing.Point(37, 127);
            this.cb_etat.Name = "cb_etat";
            this.cb_etat.Size = new System.Drawing.Size(173, 22);
            this.cb_etat.TabIndex = 13;
            this.cb_etat.ValueMember = "id_Etat";
            this.cb_etat.SelectedIndexChanged += new System.EventHandler(this.cb_etat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Etat du bien";
            // 
            // bien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_etat);
            this.Controls.Add(this.tb_scanBien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_codeBienManuel);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "bien";
            this.Text = "bien";
            this.Load += new System.EventHandler(this.bien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codeBienManuel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_scanBien;
        private System.Windows.Forms.ComboBox cb_etat;
        private System.Windows.Forms.Label label3;
    }
}