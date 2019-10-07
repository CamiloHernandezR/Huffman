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
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComprimido = new System.Windows.Forms.TextBox();
            this.txtCompresion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTam0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTamN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radArchivo = new System.Windows.Forms.RadioButton();
            this.radEscribri = new System.Windows.Forms.RadioButton();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProbabilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(12, 37);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(272, 89);
            this.txtCadena.TabIndex = 0;
            // 
            // txtComenzar
            // 
            this.txtComenzar.Location = new System.Drawing.Point(560, 355);
            this.txtComenzar.Name = "txtComenzar";
            this.txtComenzar.Size = new System.Drawing.Size(152, 65);
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
            this.Column2,
            this.cod});
            this.dtgProbabilidades.Location = new System.Drawing.Point(12, 174);
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
            // cod
            // 
            this.cod.HeaderText = "codiga";
            this.cod.Name = "cod";
            // 
            // txtComprimido
            // 
            this.txtComprimido.Location = new System.Drawing.Point(479, 49);
            this.txtComprimido.Multiline = true;
            this.txtComprimido.Name = "txtComprimido";
            this.txtComprimido.Size = new System.Drawing.Size(309, 90);
            this.txtComprimido.TabIndex = 3;
            // 
            // txtCompresion
            // 
            this.txtCompresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompresion.Location = new System.Drawing.Point(498, 320);
            this.txtCompresion.Name = "txtCompresion";
            this.txtCompresion.Size = new System.Drawing.Size(163, 24);
            this.txtCompresion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mensaje a comprimir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mensaje comprimido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Indice de compresiòn";
            // 
            // TxtTam0
            // 
            this.TxtTam0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTam0.Location = new System.Drawing.Point(495, 179);
            this.TxtTam0.Name = "TxtTam0";
            this.TxtTam0.Size = new System.Drawing.Size(163, 24);
            this.TxtTam0.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamaño original";
            // 
            // txtTamN
            // 
            this.txtTamN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamN.Location = new System.Drawing.Point(495, 260);
            this.txtTamN.Name = "txtTamN";
            this.txtTamN.Size = new System.Drawing.Size(163, 24);
            this.txtTamN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nuevo tamaño";
            // 
            // radArchivo
            // 
            this.radArchivo.AutoSize = true;
            this.radArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArchivo.Location = new System.Drawing.Point(310, 49);
            this.radArchivo.Name = "radArchivo";
            this.radArchivo.Size = new System.Drawing.Size(97, 22);
            this.radArchivo.TabIndex = 12;
            this.radArchivo.TabStop = true;
            this.radArchivo.Text = "Usar un txt";
            this.radArchivo.UseVisualStyleBackColor = true;
            this.radArchivo.CheckedChanged += new System.EventHandler(this.radArchivo_CheckedChanged);
            // 
            // radEscribri
            // 
            this.radEscribri.AutoSize = true;
            this.radEscribri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEscribri.Location = new System.Drawing.Point(310, 87);
            this.radEscribri.Name = "radEscribri";
            this.radEscribri.Size = new System.Drawing.Size(132, 22);
            this.radEscribri.TabIndex = 13;
            this.radEscribri.TabStop = true;
            this.radEscribri.Text = "EscribirMensaje";
            this.radEscribri.UseVisualStyleBackColor = true;
            this.radEscribri.CheckedChanged += new System.EventHandler(this.radEscribri_CheckedChanged);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(52, 145);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(214, 23);
            this.btnArchivo.TabIndex = 14;
            this.btnArchivo.Text = "Seleccionar Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.radEscribri);
            this.Controls.Add(this.radArchivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTamN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTam0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompresion);
            this.Controls.Add(this.txtComprimido);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.TextBox txtComprimido;
        private System.Windows.Forms.TextBox txtCompresion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTam0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTamN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radArchivo;
        private System.Windows.Forms.RadioButton radEscribri;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

