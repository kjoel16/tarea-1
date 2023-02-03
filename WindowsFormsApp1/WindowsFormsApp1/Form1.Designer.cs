namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.IngreseValorlabel = new System.Windows.Forms.Label();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.Verbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tipovalorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PositivoNegativolabel3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // IngreseValorlabel
            // 
            this.IngreseValorlabel.AutoSize = true;
            this.IngreseValorlabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseValorlabel.Location = new System.Drawing.Point(39, 83);
            this.IngreseValorlabel.Name = "IngreseValorlabel";
            this.IngreseValorlabel.Size = new System.Drawing.Size(133, 23);
            this.IngreseValorlabel.TabIndex = 0;
            this.IngreseValorlabel.Text = "Ingrese un valor ";
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(234, 87);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(100, 20);
            this.ValortextBox.TabIndex = 1;
            this.ValortextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValortextBox_KeyPress);
            // 
            // Verbutton
            // 
            this.Verbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Verbutton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Verbutton.Location = new System.Drawing.Point(234, 150);
            this.Verbutton.Name = "Verbutton";
            this.Verbutton.Size = new System.Drawing.Size(100, 33);
            this.Verbutton.TabIndex = 2;
            this.Verbutton.Text = "Ver";
            this.Verbutton.UseVisualStyleBackColor = false;
            this.Verbutton.Click += new System.EventHandler(this.Verbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Su valor es de tipo: ";
            // 
            // Tipovalorlabel
            // 
            this.Tipovalorlabel.AutoSize = true;
            this.Tipovalorlabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipovalorlabel.Location = new System.Drawing.Point(219, 235);
            this.Tipovalorlabel.Name = "Tipovalorlabel";
            this.Tipovalorlabel.Size = new System.Drawing.Size(30, 23);
            this.Tipovalorlabel.TabIndex = 4;
            this.Tipovalorlabel.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "y es: ";
            // 
            // PositivoNegativolabel3
            // 
            this.PositivoNegativolabel3.AutoSize = true;
            this.PositivoNegativolabel3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositivoNegativolabel3.Location = new System.Drawing.Point(382, 235);
            this.PositivoNegativolabel3.Name = "PositivoNegativolabel3";
            this.PositivoNegativolabel3.Size = new System.Drawing.Size(30, 23);
            this.PositivoNegativolabel3.TabIndex = 6;
            this.PositivoNegativolabel3.Text = "----";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(473, 323);
            this.Controls.Add(this.PositivoNegativolabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tipovalorlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verbutton);
            this.Controls.Add(this.ValortextBox);
            this.Controls.Add(this.IngreseValorlabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngreseValorlabel;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.Button Verbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tipovalorlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PositivoNegativolabel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

