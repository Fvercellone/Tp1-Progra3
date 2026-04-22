namespace TP1_Comercio
{
    partial class AgregarArticulo
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
            this.LBCodigo = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LBNombre = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.LBDescripcion = new System.Windows.Forms.Label();
            this.LBMarca = new System.Windows.Forms.Label();
            this.LBCategoria = new System.Windows.Forms.Label();
            this.LBPrecio = new System.Windows.Forms.Label();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Location = new System.Drawing.Point(69, 33);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBCodigo.TabIndex = 0;
            this.LBCodigo.Text = "Codigo";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(141, 30);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(100, 20);
            this.TBCodigo.TabIndex = 1;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(141, 56);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 3;
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Location = new System.Drawing.Point(69, 59);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(44, 13);
            this.LBNombre.TabIndex = 2;
            this.LBNombre.Text = "Nombre";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(141, 82);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TBDescripcion.TabIndex = 5;
            // 
            // LBDescripcion
            // 
            this.LBDescripcion.AutoSize = true;
            this.LBDescripcion.Location = new System.Drawing.Point(69, 85);
            this.LBDescripcion.Name = "LBDescripcion";
            this.LBDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LBDescripcion.TabIndex = 4;
            this.LBDescripcion.Text = "Descripcion";
            // 
            // LBMarca
            // 
            this.LBMarca.AutoSize = true;
            this.LBMarca.Location = new System.Drawing.Point(69, 111);
            this.LBMarca.Name = "LBMarca";
            this.LBMarca.Size = new System.Drawing.Size(37, 13);
            this.LBMarca.TabIndex = 6;
            this.LBMarca.Text = "Marca";
            // 
            // LBCategoria
            // 
            this.LBCategoria.AutoSize = true;
            this.LBCategoria.Location = new System.Drawing.Point(69, 137);
            this.LBCategoria.Name = "LBCategoria";
            this.LBCategoria.Size = new System.Drawing.Size(52, 13);
            this.LBCategoria.TabIndex = 8;
            this.LBCategoria.Text = "Categoria";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(69, 167);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(37, 13);
            this.LBPrecio.TabIndex = 10;
            this.LBPrecio.Text = "Precio";
            // 
            // BTAceptar
            // 
            this.BTAceptar.Location = new System.Drawing.Point(72, 312);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 13;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = true;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(234, 312);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 14;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(141, 164);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(100, 20);
            this.TBPrecio.TabIndex = 15;
            // 
            // CBMarca
            // 
            this.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Location = new System.Drawing.Point(141, 111);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(121, 21);
            this.CBMarca.TabIndex = 16;
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(141, 137);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(121, 21);
            this.CBCategoria.TabIndex = 17;
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 383);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.LBPrecio);
            this.Controls.Add(this.LBCategoria);
            this.Controls.Add(this.LBMarca);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.LBDescripcion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBNombre);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.LBCodigo);
            this.Name = "AgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label LBDescripcion;
        private System.Windows.Forms.Label LBMarca;
        private System.Windows.Forms.Label LBCategoria;
        private System.Windows.Forms.Label LBPrecio;
        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.ComboBox CBCategoria;
    }
}