namespace PetsAsServices
{
    partial class frmMeusFavoritos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeusFavoritos));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirFavorito = new System.Windows.Forms.Button();
            this.catFavoritesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbFavoritos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.catFavoritesModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(765, 3);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aqui você encontra a lista de gatinhos favoritos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meus Favoritos";
            // 
            // btnExcluirFavorito
            // 
            this.btnExcluirFavorito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirFavorito.Location = new System.Drawing.Point(636, 381);
            this.btnExcluirFavorito.Name = "btnExcluirFavorito";
            this.btnExcluirFavorito.Size = new System.Drawing.Size(146, 46);
            this.btnExcluirFavorito.TabIndex = 7;
            this.btnExcluirFavorito.Text = "Excluir Favorito";
            this.btnExcluirFavorito.UseVisualStyleBackColor = true;
            this.btnExcluirFavorito.Click += new System.EventHandler(this.btnExcluirFavorito_Click);
            // 
            // catFavoritesModelBindingSource
            // 
            this.catFavoritesModelBindingSource.DataSource = typeof(CatFavoritesModel);
            // 
            // lbFavoritos
            // 
            this.lbFavoritos.FormattingEnabled = true;
            resources.ApplyResources(this.lbFavoritos, "lbFavoritos");
            this.lbFavoritos.Name = "lbFavoritos";
            // 
            // frmMeusFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcluirFavorito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMeusFavoritos";
            this.Text = "Verificar Raças Favoritas";
            this.Load += new System.EventHandler(this.frmMeusFavoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catFavoritesModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirFavorito;
        private System.Windows.Forms.BindingSource catFavoritesModelBindingSource;
        private System.Windows.Forms.ListBox lbFavoritos;
    }
}