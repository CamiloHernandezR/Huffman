namespace Huffman
{
    partial class Form1
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtComenzar = new System.Windows.Forms.Button();
            this.dtgProbabilidades = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProbabilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(34, 41);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 0;
            // 
            // txtComenzar
            // 
            this.txtComenzar.Location = new System.Drawing.Point(658, 338);
            this.txtComenzar.Name = "txtComenzar";
            this.txtComenzar.Size = new System.Drawing.Size(75, 23);
            this.txtComenzar.TabIndex = 1;
            this.txtComenzar.Text = "Commenzar";
            this.txtComenzar.UseVisualStyleBackColor = true;
            this.txtComenzar.Click += new System.EventHandler(this.txtComenzar_Click);
            // 
            // dtgProbabilidades
            // 
            this.dtgProbabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProbabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Rep,
            this.Column2});
            this.dtgProbabilidades.Location = new System.Drawing.Point(24, 118);
            this.dtgProbabilidades.Name = "dtgProbabilidades";
            this.dtgProbabilidades.Size = new System.Drawing.Size(466, 264);
            this.dtgProbabilidades.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Caracter";
            this.Column1.Name = "Column1";
            // 
            // Rep
            // 
            this.Rep.HeaderText = "Apariciones";
            this.Rep.Name = "Rep";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "probabilidad";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgProbabilidades);
            this.Controls.Add(this.txtComenzar);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProbabilidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button txtComenzar;
        private System.Windows.Forms.DataGridView dtgProbabilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

