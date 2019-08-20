namespace Gerador_de_Tombamentos
{
    partial class formNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNot));
            this.title1 = new System.Windows.Forms.Label();
            this.ITEM = new System.Windows.Forms.PictureBox();
            this.imagens = new System.Windows.Forms.ImageList(this.components);
            this.cod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(87, 20);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(214, 32);
            this.title1.TabIndex = 0;
            this.title1.Text = "CÓDIGO GERADO";
            this.title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ITEM
            // 
            this.ITEM.Location = new System.Drawing.Point(137, 96);
            this.ITEM.Name = "ITEM";
            this.ITEM.Size = new System.Drawing.Size(100, 100);
            this.ITEM.TabIndex = 1;
            this.ITEM.TabStop = false;
            // 
            // imagens
            // 
            this.imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagens.ImageStream")));
            this.imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.imagens.Images.SetKeyName(0, "desktop.png");
            this.imagens.Images.SetKeyName(1, "monitor.png");
            this.imagens.Images.SetKeyName(2, "notebook.png");
            this.imagens.Images.SetKeyName(3, "nobreak.png");
            this.imagens.Images.SetKeyName(4, "estabilizador.png");
            this.imagens.Images.SetKeyName(5, "print.png");
            this.imagens.Images.SetKeyName(6, "fax.png");
            this.imagens.Images.SetKeyName(7, "projetor.png");
            this.imagens.Images.SetKeyName(8, "scanner.png");
            this.imagens.Images.SetKeyName(9, "HDTV.png");
            this.imagens.Images.SetKeyName(10, "outros.png");
            // 
            // cod
            // 
            this.cod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod.Location = new System.Drawing.Point(12, 236);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(370, 32);
            this.cod.TabIndex = 2;
            this.cod.Text = "<COD>";
            this.cod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cod.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copiar Código";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(136, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "#TODO";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(260, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "#TODO";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // formNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 343);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.ITEM);
            this.Controls.Add(this.title1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formNot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código Gerado";
            ((System.ComponentModel.ISupportInitialize)(this.ITEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.PictureBox ITEM;
        private System.Windows.Forms.ImageList imagens;
        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}