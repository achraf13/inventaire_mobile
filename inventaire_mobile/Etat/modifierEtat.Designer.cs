namespace inventaire_mobile.Etat
{
    partial class modifierEtat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifierEtat));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_desigetat = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_etat = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.Text = "Designation etat";
            // 
            // tb_desigetat
            // 
            this.tb_desigetat.Location = new System.Drawing.Point(33, 139);
            this.tb_desigetat.Name = "tb_desigetat";
            this.tb_desigetat.Size = new System.Drawing.Size(158, 21);
            this.tb_desigetat.TabIndex = 3;
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Transparent;
            this.modifier.Image = ((System.Drawing.Image)(resources.GetObject("modifier.Image")));
            this.modifier.Location = new System.Drawing.Point(131, 181);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(60, 50);
            this.modifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifier.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(133, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.Text = "Modifier";
            // 
            // cb_etat
            // 
            this.cb_etat.DisplayMember = "dsgEtat";
            this.cb_etat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_etat.Location = new System.Drawing.Point(33, 79);
            this.cb_etat.Name = "cb_etat";
            this.cb_etat.Size = new System.Drawing.Size(158, 22);
            this.cb_etat.TabIndex = 7;
            this.cb_etat.SelectedIndexChanged += new System.EventHandler(this.cb_etat_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // modifierEtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cb_etat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.tb_desigetat);
            this.Controls.Add(this.label2);
            this.Menu = this.mainMenu1;
            this.Name = "modifierEtat";
            this.Text = "modifierEtat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_desigetat;
        private System.Windows.Forms.PictureBox modifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_etat;
        private System.Windows.Forms.ImageList imageList1;
    }
}