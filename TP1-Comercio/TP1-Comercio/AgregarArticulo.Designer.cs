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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulo));
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
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.PBNuevoProducto = new System.Windows.Forms.PictureBox();
            this.LBLFoto = new System.Windows.Forms.Label();
            this.TXBFoto = new System.Windows.Forms.TextBox();
            this.ImagenArchivo = new System.Windows.Forms.Button();
            this.NUDPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PBNuevoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBCodigo.Location = new System.Drawing.Point(2, 30);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(52, 17);
            this.LBCodigo.TabIndex = 0;
            this.LBCodigo.Text = "Codigo";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.TBCodigo.Location = new System.Drawing.Point(84, 25);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(121, 22);
            this.TBCodigo.TabIndex = 0;
            this.TBCodigo.TextChanged += new System.EventHandler(this.TBCodigo_TextChanged);
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.TBNombre.Location = new System.Drawing.Point(84, 53);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(121, 22);
            this.TBNombre.TabIndex = 1;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBCodigo_TextChanged);
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBNombre.Location = new System.Drawing.Point(2, 56);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(56, 17);
            this.LBNombre.TabIndex = 2;
            this.LBNombre.Text = "Nombre";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.TBDescripcion.Location = new System.Drawing.Point(84, 79);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(121, 22);
            this.TBDescripcion.TabIndex = 2;
            // 
            // LBDescripcion
            // 
            this.LBDescripcion.AutoSize = true;
            this.LBDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBDescripcion.Location = new System.Drawing.Point(2, 82);
            this.LBDescripcion.Name = "LBDescripcion";
            this.LBDescripcion.Size = new System.Drawing.Size(79, 17);
            this.LBDescripcion.TabIndex = 4;
            this.LBDescripcion.Text = "Descripcion";
            // 
            // LBMarca
            // 
            this.LBMarca.AutoSize = true;
            this.LBMarca.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBMarca.Location = new System.Drawing.Point(2, 108);
            this.LBMarca.Name = "LBMarca";
            this.LBMarca.Size = new System.Drawing.Size(47, 17);
            this.LBMarca.TabIndex = 6;
            this.LBMarca.Text = "Marca";
            // 
            // LBCategoria
            // 
            this.LBCategoria.AutoSize = true;
            this.LBCategoria.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBCategoria.Location = new System.Drawing.Point(2, 134);
            this.LBCategoria.Name = "LBCategoria";
            this.LBCategoria.Size = new System.Drawing.Size(69, 17);
            this.LBCategoria.TabIndex = 8;
            this.LBCategoria.Text = "Categoria";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBPrecio.Location = new System.Drawing.Point(2, 163);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(46, 17);
            this.LBPrecio.TabIndex = 10;
            this.LBPrecio.Text = "Precio";
            // 
            // BTAceptar
            // 
            this.BTAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTAceptar.Enabled = false;
            this.BTAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BTAceptar.FlatAppearance.BorderSize = 0;
            this.BTAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAceptar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTAceptar.ForeColor = System.Drawing.Color.White;
            this.BTAceptar.Location = new System.Drawing.Point(15, 214);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 8;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = false;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BTCancelar.FlatAppearance.BorderSize = 0;
            this.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCancelar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTCancelar.ForeColor = System.Drawing.Color.White;
            this.BTCancelar.Location = new System.Drawing.Point(130, 214);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 9;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = false;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // CBMarca
            // 
            this.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMarca.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Location = new System.Drawing.Point(84, 103);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(121, 25);
            this.CBMarca.TabIndex = 3;
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(84, 130);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(121, 25);
            this.CBCategoria.TabIndex = 4;
            // 
            // PBNuevoProducto
            // 
            this.PBNuevoProducto.Location = new System.Drawing.Point(221, 27);
            this.PBNuevoProducto.Name = "PBNuevoProducto";
            this.PBNuevoProducto.Size = new System.Drawing.Size(235, 210);
            this.PBNuevoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBNuevoProducto.TabIndex = 18;
            this.PBNuevoProducto.TabStop = false;
            // 
            // LBLFoto
            // 
            this.LBLFoto.AutoSize = true;
            this.LBLFoto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LBLFoto.Location = new System.Drawing.Point(2, 188);
            this.LBLFoto.Name = "LBLFoto";
            this.LBLFoto.Size = new System.Drawing.Size(35, 17);
            this.LBLFoto.TabIndex = 19;
            this.LBLFoto.Text = "Foto";
            // 
            // TXBFoto
            // 
            this.TXBFoto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.TXBFoto.Location = new System.Drawing.Point(84, 185);
            this.TXBFoto.Name = "TXBFoto";
            this.TXBFoto.Size = new System.Drawing.Size(89, 22);
            this.TXBFoto.TabIndex = 6;
            this.TXBFoto.Leave += new System.EventHandler(this.TXBFoto_Leave);
            // 
            // ImagenArchivo
            // 
            this.ImagenArchivo.BackColor = System.Drawing.Color.RoyalBlue;
            this.ImagenArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ImagenArchivo.FlatAppearance.BorderSize = 0;
            this.ImagenArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImagenArchivo.ForeColor = System.Drawing.Color.Transparent;
            this.ImagenArchivo.Location = new System.Drawing.Point(182, 182);
            this.ImagenArchivo.Name = "ImagenArchivo";
            this.ImagenArchivo.Size = new System.Drawing.Size(23, 23);
            this.ImagenArchivo.TabIndex = 7;
            this.ImagenArchivo.Text = "+";
            this.ImagenArchivo.UseVisualStyleBackColor = false;
            this.ImagenArchivo.Click += new System.EventHandler(this.ImagenArchivo_Click);
            // 
            // NUDPrecio
            // 
            this.NUDPrecio.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NUDPrecio.Location = new System.Drawing.Point(84, 158);
            this.NUDPrecio.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.NUDPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPrecio.Name = "NUDPrecio";
            this.NUDPrecio.Size = new System.Drawing.Size(121, 22);
            this.NUDPrecio.TabIndex = 5;
            this.NUDPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPrecio.ValueChanged += new System.EventHandler(this.TBCodigo_TextChanged);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(473, 263);
            this.Controls.Add(this.NUDPrecio);
            this.Controls.Add(this.ImagenArchivo);
            this.Controls.Add(this.TXBFoto);
            this.Controls.Add(this.LBLFoto);
            this.Controls.Add(this.PBNuevoProducto);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBMarca);
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
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 302);
            this.MinimumSize = new System.Drawing.Size(489, 302);
            this.Name = "AgregarArticulo";
            this.Text = "Agregar Articulos";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBNuevoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).EndInit();
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
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.PictureBox PBNuevoProducto;
        private System.Windows.Forms.Label LBLFoto;
        private System.Windows.Forms.TextBox TXBFoto;
        private System.Windows.Forms.Button ImagenArchivo;
        private System.Windows.Forms.NumericUpDown NUDPrecio;
    }
}