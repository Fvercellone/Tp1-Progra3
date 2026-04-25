namespace TP1_Comercio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.BTAgregarA = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.BTVerDetalle = new System.Windows.Forms.Button();
            this.TXBBusqueda = new System.Windows.Forms.TextBox();
            this.CBOFiltros = new System.Windows.Forms.ComboBox();
            this.BNTAccesoMarcas = new System.Windows.Forms.Button();
            this.BTNAccesoCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToResizeColumns = false;
            this.DGVProductos.AllowUserToResizeRows = false;
            this.DGVProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.DGVProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVProductos.GridColor = System.Drawing.Color.SteelBlue;
            this.DGVProductos.Location = new System.Drawing.Point(13, 38);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVProductos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGVProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(446, 352);
            this.DGVProductos.TabIndex = 8;
            this.DGVProductos.SelectionChanged += new System.EventHandler(this.DGVProductos_SelectionChanged);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(465, 12);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(278, 378);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 1;
            this.pbxProducto.TabStop = false;
            // 
            // BTAgregarA
            // 
            this.BTAgregarA.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTAgregarA.FlatAppearance.BorderSize = 0;
            this.BTAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregarA.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTAgregarA.ForeColor = System.Drawing.Color.White;
            this.BTAgregarA.Location = new System.Drawing.Point(13, 397);
            this.BTAgregarA.Name = "BTAgregarA";
            this.BTAgregarA.Size = new System.Drawing.Size(78, 25);
            this.BTAgregarA.TabIndex = 2;
            this.BTAgregarA.Text = "Agregar";
            this.BTAgregarA.UseVisualStyleBackColor = false;
            this.BTAgregarA.Click += new System.EventHandler(this.BTAgregarA_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNModificar.FlatAppearance.BorderSize = 0;
            this.BTNModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNModificar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTNModificar.ForeColor = System.Drawing.Color.White;
            this.BTNModificar.Location = new System.Drawing.Point(181, 397);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(78, 25);
            this.BTNModificar.TabIndex = 4;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = false;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTEliminar
            // 
            this.BTEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTEliminar.FlatAppearance.BorderSize = 0;
            this.BTEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTEliminar.ForeColor = System.Drawing.Color.White;
            this.BTEliminar.Location = new System.Drawing.Point(97, 397);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(78, 25);
            this.BTEliminar.TabIndex = 3;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = false;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // BTVerDetalle
            // 
            this.BTVerDetalle.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTVerDetalle.FlatAppearance.BorderSize = 0;
            this.BTVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTVerDetalle.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTVerDetalle.ForeColor = System.Drawing.Color.White;
            this.BTVerDetalle.Location = new System.Drawing.Point(265, 397);
            this.BTVerDetalle.Name = "BTVerDetalle";
            this.BTVerDetalle.Size = new System.Drawing.Size(78, 25);
            this.BTVerDetalle.TabIndex = 5;
            this.BTVerDetalle.Text = "Ver Detalle";
            this.BTVerDetalle.UseVisualStyleBackColor = false;
            this.BTVerDetalle.Click += new System.EventHandler(this.BTVerDetalle_Click);
            // 
            // TXBBusqueda
            // 
            this.TXBBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.TXBBusqueda.Location = new System.Drawing.Point(149, 12);
            this.TXBBusqueda.Name = "TXBBusqueda";
            this.TXBBusqueda.Size = new System.Drawing.Size(310, 22);
            this.TXBBusqueda.TabIndex = 1;
            this.TXBBusqueda.TextChanged += new System.EventHandler(this.TXBBusqueda_TextChanged);
            // 
            // CBOFiltros
            // 
            this.CBOFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOFiltros.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBOFiltros.FormattingEnabled = true;
            this.CBOFiltros.Location = new System.Drawing.Point(13, 12);
            this.CBOFiltros.Name = "CBOFiltros";
            this.CBOFiltros.Size = new System.Drawing.Size(121, 25);
            this.CBOFiltros.TabIndex = 0;
            this.CBOFiltros.SelectedIndexChanged += new System.EventHandler(this.CBOFiltros_SelectedIndexChanged);
            // 
            // BNTAccesoMarcas
            // 
            this.BNTAccesoMarcas.BackColor = System.Drawing.Color.RoyalBlue;
            this.BNTAccesoMarcas.FlatAppearance.BorderSize = 0;
            this.BNTAccesoMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTAccesoMarcas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BNTAccesoMarcas.ForeColor = System.Drawing.Color.White;
            this.BNTAccesoMarcas.Location = new System.Drawing.Point(465, 408);
            this.BNTAccesoMarcas.Name = "BNTAccesoMarcas";
            this.BNTAccesoMarcas.Size = new System.Drawing.Size(129, 25);
            this.BNTAccesoMarcas.TabIndex = 6;
            this.BNTAccesoMarcas.Text = "Acceso Marcas";
            this.BNTAccesoMarcas.UseVisualStyleBackColor = false;
            this.BNTAccesoMarcas.Click += new System.EventHandler(this.BNTAccesoMarcas_Click);
            // 
            // BTNAccesoCategoria
            // 
            this.BTNAccesoCategoria.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNAccesoCategoria.FlatAppearance.BorderSize = 0;
            this.BTNAccesoCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAccesoCategoria.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTNAccesoCategoria.ForeColor = System.Drawing.Color.White;
            this.BTNAccesoCategoria.Location = new System.Drawing.Point(614, 407);
            this.BTNAccesoCategoria.Name = "BTNAccesoCategoria";
            this.BTNAccesoCategoria.Size = new System.Drawing.Size(129, 26);
            this.BTNAccesoCategoria.TabIndex = 7;
            this.BTNAccesoCategoria.Text = "Acceso Categoria";
            this.BTNAccesoCategoria.UseVisualStyleBackColor = false;
            this.BTNAccesoCategoria.Click += new System.EventHandler(this.BTNAccesoCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(757, 445);
            this.Controls.Add(this.BTNAccesoCategoria);
            this.Controls.Add(this.BNTAccesoMarcas);
            this.Controls.Add(this.CBOFiltros);
            this.Controls.Add(this.TXBBusqueda);
            this.Controls.Add(this.BTVerDetalle);
            this.Controls.Add(this.BTEliminar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTAgregarA);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.DGVProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 484);
            this.MinimumSize = new System.Drawing.Size(773, 484);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button BTAgregarA;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.Button BTVerDetalle;
        private System.Windows.Forms.TextBox TXBBusqueda;
        private System.Windows.Forms.ComboBox CBOFiltros;
        private System.Windows.Forms.Button BNTAccesoMarcas;
        private System.Windows.Forms.Button BTNAccesoCategoria;
    }
}

