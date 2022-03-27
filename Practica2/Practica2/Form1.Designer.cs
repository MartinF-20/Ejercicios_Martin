
namespace Practica2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.element1 = new System.Windows.Forms.Label();
            this.element2 = new System.Windows.Forms.Label();
            this.element3 = new System.Windows.Forms.Label();
            this.element4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.MediumBlue;
            this.p1.Location = new System.Drawing.Point(50, 50);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(413, 368);
            this.p1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Practica2.Properties.Resources.rombo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // element1
            // 
            this.element1.AllowDrop = true;
            this.element1.AutoEllipsis = true;
            this.element1.BackColor = System.Drawing.Color.Firebrick;
            this.element1.Location = new System.Drawing.Point(711, 168);
            this.element1.Name = "element1";
            this.element1.Size = new System.Drawing.Size(30, 30);
            this.element1.TabIndex = 2;
            this.element1.Text = "1";
            this.element1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // element2
            // 
            this.element2.AllowDrop = true;
            this.element2.AutoEllipsis = true;
            this.element2.BackColor = System.Drawing.Color.Yellow;
            this.element2.Location = new System.Drawing.Point(761, 168);
            this.element2.Name = "element2";
            this.element2.Size = new System.Drawing.Size(30, 30);
            this.element2.TabIndex = 3;
            this.element2.Text = "2";
            this.element2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // element3
            // 
            this.element3.AllowDrop = true;
            this.element3.AutoEllipsis = true;
            this.element3.BackColor = System.Drawing.Color.LightCoral;
            this.element3.Location = new System.Drawing.Point(711, 215);
            this.element3.Name = "element3";
            this.element3.Size = new System.Drawing.Size(30, 30);
            this.element3.TabIndex = 4;
            this.element3.Text = "3";
            this.element3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // element4
            // 
            this.element4.AllowDrop = true;
            this.element4.AutoEllipsis = true;
            this.element4.BackColor = System.Drawing.Color.Chartreuse;
            this.element4.Location = new System.Drawing.Point(761, 215);
            this.element4.Name = "element4";
            this.element4.Size = new System.Drawing.Size(30, 30);
            this.element4.TabIndex = 5;
            this.element4.Text = "4";
            this.element4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 90;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(629, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.element4);
            this.Controls.Add(this.element3);
            this.Controls.Add(this.element2);
            this.Controls.Add(this.element1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label element1;
        private System.Windows.Forms.Label element2;
        private System.Windows.Forms.Label element3;
        private System.Windows.Forms.Label element4;
        private System.Windows.Forms.Button button1;
    }
}

