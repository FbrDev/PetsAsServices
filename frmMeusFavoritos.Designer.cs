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
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnExcluirFavorito
            // 
            resources.ApplyResources(this.btnExcluirFavorito, "btnExcluirFavorito");
            this.btnExcluirFavorito.Name = "btnExcluirFavorito";
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFavoritos);
            this.Controls.Add(this.btnExcluirFavorito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMeusFavoritos";
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