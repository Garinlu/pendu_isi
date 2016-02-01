namespace Pendu
{
    partial class Form1
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
            this.tsplb_information = new System.Windows.Forms.Label();
            this.bt_verifier = new System.Windows.Forms.Button();
            this.bt_generer = new System.Windows.Forms.Button();
            this.bt_abandonner = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lb_Echec = new System.Windows.Forms.Label();
            this.essai = new System.Windows.Forms.TextBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Affiche = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsplb_information
            // 
            this.tsplb_information.AutoSize = true;
            this.tsplb_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.tsplb_information.Location = new System.Drawing.Point(9, 7);
            this.tsplb_information.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsplb_information.Name = "tsplb_information";
            this.tsplb_information.Size = new System.Drawing.Size(0, 12);
            this.tsplb_information.TabIndex = 1;
            // 
            // bt_verifier
            // 
            this.bt_verifier.Location = new System.Drawing.Point(417, 247);
            this.bt_verifier.Margin = new System.Windows.Forms.Padding(2);
            this.bt_verifier.Name = "bt_verifier";
            this.bt_verifier.Size = new System.Drawing.Size(160, 19);
            this.bt_verifier.TabIndex = 2;
            this.bt_verifier.Text = "Verifier";
            this.bt_verifier.UseVisualStyleBackColor = true;
            this.bt_verifier.Click += new System.EventHandler(this.bt_verifier_Click);
            // 
            // bt_generer
            // 
            this.bt_generer.Location = new System.Drawing.Point(284, 290);
            this.bt_generer.Margin = new System.Windows.Forms.Padding(2);
            this.bt_generer.Name = "bt_generer";
            this.bt_generer.Size = new System.Drawing.Size(121, 19);
            this.bt_generer.TabIndex = 3;
            this.bt_generer.Text = "Générer un mot";
            this.bt_generer.UseVisualStyleBackColor = true;
            this.bt_generer.Click += new System.EventHandler(this.bt_generer_Click);
            // 
            // bt_abandonner
            // 
            this.bt_abandonner.Location = new System.Drawing.Point(417, 290);
            this.bt_abandonner.Margin = new System.Windows.Forms.Padding(2);
            this.bt_abandonner.Name = "bt_abandonner";
            this.bt_abandonner.Size = new System.Drawing.Size(160, 19);
            this.bt_abandonner.TabIndex = 4;
            this.bt_abandonner.Text = "Recommencer";
            this.bt_abandonner.UseVisualStyleBackColor = true;
            this.bt_abandonner.Click += new System.EventHandler(this.bt_abandonner_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 329);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 21);
            this.button4.TabIndex = 5;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_Echec
            // 
            this.lb_Echec.AutoSize = true;
            this.lb_Echec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_Echec.Location = new System.Drawing.Point(165, 202);
            this.lb_Echec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Echec.Name = "lb_Echec";
            this.lb_Echec.Size = new System.Drawing.Size(0, 22);
            this.lb_Echec.TabIndex = 7;
            // 
            // essai
            // 
            this.essai.Location = new System.Drawing.Point(284, 246);
            this.essai.Margin = new System.Windows.Forms.Padding(2);
            this.essai.Name = "essai";
            this.essai.Size = new System.Drawing.Size(121, 20);
            this.essai.TabIndex = 8;
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.SystemColors.Control;
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img1.Location = new System.Drawing.Point(21, 36);
            this.img1.Margin = new System.Windows.Forms.Padding(2);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(182, 314);
            this.img1.TabIndex = 9;
            this.img1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(286, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Echecs:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(284, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(293, 50);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            // 
            // Affiche
            // 
            this.Affiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Affiche.Location = new System.Drawing.Point(283, 143);
            this.Affiche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Affiche.Name = "Affiche";
            this.Affiche.Size = new System.Drawing.Size(294, 50);
            this.Affiche.TabIndex = 12;
            this.Affiche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "PENDU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Affiche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.essai);
            this.Controls.Add(this.lb_Echec);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_abandonner);
            this.Controls.Add(this.bt_generer);
            this.Controls.Add(this.bt_verifier);
            this.Controls.Add(this.tsplb_information);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tsplb_information;
        private System.Windows.Forms.Button bt_verifier;
        private System.Windows.Forms.Button bt_generer;
        private System.Windows.Forms.Button bt_abandonner;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_Echec;
        private System.Windows.Forms.TextBox essai;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Affiche;
        private System.Windows.Forms.Label label2;
    }
}

