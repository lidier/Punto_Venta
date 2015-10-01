namespace Punto_Venta.Proveedor
{
    partial class AgregarProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombreComercial = new System.Windows.Forms.Label();
            this.nombrelabel = new System.Windows.Forms.Label();
            this.labelPriApellido = new System.Windows.Forms.Label();
            this.labelSeApellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            // 
            // nombreComercial
            // 
            this.nombreComercial.AutoSize = true;
            this.nombreComercial.Location = new System.Drawing.Point(52, 145);
            this.nombreComercial.Name = "nombreComercial";
            this.nombreComercial.Size = new System.Drawing.Size(93, 13);
            this.nombreComercial.TabIndex = 2;
            this.nombreComercial.Text = "Nombre Comercial";
            // 
            // nombrelabel
            // 
            this.nombrelabel.AutoSize = true;
            this.nombrelabel.Location = new System.Drawing.Point(52, 218);
            this.nombrelabel.Name = "nombrelabel";
            this.nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.nombrelabel.TabIndex = 3;
            this.nombrelabel.Text = "Nombre";
            // 
            // labelPriApellido
            // 
            this.labelPriApellido.AutoSize = true;
            this.labelPriApellido.Location = new System.Drawing.Point(176, 218);
            this.labelPriApellido.Name = "labelPriApellido";
            this.labelPriApellido.Size = new System.Drawing.Size(76, 13);
            this.labelPriApellido.TabIndex = 4;
            this.labelPriApellido.Text = "Primer Apellido";
            // 
            // labelSeApellido
            // 
            this.labelSeApellido.AutoSize = true;
            this.labelSeApellido.Location = new System.Drawing.Point(338, 218);
            this.labelSeApellido.Name = "labelSeApellido";
            this.labelSeApellido.Size = new System.Drawing.Size(90, 13);
            this.labelSeApellido.TabIndex = 5;
            this.labelSeApellido.Text = "Segundo Apellido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(312, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 9;
            // 
            // buttonguardar
            // 
            this.buttonguardar.ImageKey = "(ninguno)";
            this.buttonguardar.Location = new System.Drawing.Point(46, 277);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(98, 29);
            this.buttonguardar.TabIndex = 10;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(204, 278);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(105, 28);
            this.buttoncancel.TabIndex = 11;
            this.buttoncancel.Text = "Cancelar";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 348);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelSeApellido);
            this.Controls.Add(this.labelPriApellido);
            this.Controls.Add(this.nombrelabel);
            this.Controls.Add(this.nombreComercial);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nombreComercial;
        private System.Windows.Forms.Label nombrelabel;
        private System.Windows.Forms.Label labelPriApellido;
        private System.Windows.Forms.Label labelSeApellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttoncancel;

    }
}