namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aceptar = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(563, 80);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(681, 80);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 23);
            this.igual.TabIndex = 1;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(87, 158);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(619, 242);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "Resultado:";
            this.resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Aquamarine;
            this.text.Location = new System.Drawing.Point(87, 81);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(356, 23);
            this.text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button aceptar;
        private Button igual;
        private TextBox resultado;
        private TextBox text;
    }
}