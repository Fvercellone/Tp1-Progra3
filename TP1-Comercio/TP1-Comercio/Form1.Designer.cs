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
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.BTAgregarA = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.BTVerDetalle = new System.Windows.Forms.Button();
            this.TXBBusqueda = new System.Windows.Forms.TextBox();
            this.CBOFiltros = new System.Windows.Forms.ComboBox();
            this.BTNAccesoProcductos = new System.Windows.Forms.Button();
            this.BNTAccesoMarcas = new System.Windows.Forms.Button();
            this.BTNAccesoCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVProductos.Location = new System.Drawing.Point(12, 82);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(446, 352);
            this.DGVProductos.TabIndex = 0;
            this.DGVProductos.SelectionChanged += new System.EventHandler(this.DGVProductos_SelectionChanged);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(464, 82);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(278, 378);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 1;
            this.pbxProducto.TabStop = false;
            // 
            // BTAgregarA
            // 
            this.BTAgregarA.Location = new System.Drawing.Point(12, 469);
            this.BTAgregarA.Name = "BTAgregarA";
            this.BTAgregarA.Size = new System.Drawing.Size(105, 39);
            this.BTAgregarA.TabIndex = 2;
            this.BTAgregarA.Text = "Agregar";
            this.BTAgregarA.UseVisualStyleBackColor = true;
            this.BTAgregarA.Click += new System.EventHandler(this.BTAgregarA_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(234, 469);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(105, 39);
            this.BTNModificar.TabIndex = 3;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTEliminar
            // 
            this.BTEliminar.Location = new System.Drawing.Point(123, 469);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(105, 39);
            this.BTEliminar.TabIndex = 4;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = true;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // BTVerDetalle
            // 
            this.BTVerDetalle.Location = new System.Drawing.Point(345, 469);
            this.BTVerDetalle.Name = "BTVerDetalle";
            this.BTVerDetalle.Size = new System.Drawing.Size(105, 39);
            this.BTVerDetalle.TabIndex = 5;
            this.BTVerDetalle.Text = "Ver Detalle";
            this.BTVerDetalle.UseVisualStyleBackColor = true;
            this.BTVerDetalle.Click += new System.EventHandler(this.BTVerDetalle_Click);
            // 
            // TXBBusqueda
            // 
            this.TXBBusqueda.Location = new System.Drawing.Point(140, 440);
            this.TXBBusqueda.Name = "TXBBusqueda";
            this.TXBBusqueda.Size = new System.Drawing.Size(310, 20);
            this.TXBBusqueda.TabIndex = 6;
            this.TXBBusqueda.TextChanged += new System.EventHandler(this.TXBBusqueda_TextChanged);
            // 
            // CBOFiltros
            // 
            this.CBOFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOFiltros.FormattingEnabled = true;
            this.CBOFiltros.Location = new System.Drawing.Point(13, 440);
            this.CBOFiltros.Name = "CBOFiltros";
            this.CBOFiltros.Size = new System.Drawing.Size(121, 21);
            this.CBOFiltros.TabIndex = 7;
            this.CBOFiltros.SelectedIndexChanged += new System.EventHandler(this.CBOFiltros_SelectedIndexChanged);
            // 
            // BTNAccesoProcductos
            // 
            this.BTNAccesoProcductos.Location = new System.Drawing.Point(13, 12);
            this.BTNAccesoProcductos.Name = "BTNAccesoProcductos";
            this.BTNAccesoProcductos.Size = new System.Drawing.Size(215, 64);
            this.BTNAccesoProcductos.TabIndex = 8;
            this.BTNAccesoProcductos.Text = "Acceso Procductos";
            this.BTNAccesoProcductos.UseVisualStyleBackColor = true;
            this.BTNAccesoProcductos.Click += new System.EventHandler(this.BTNAccesoProcductos_Click);
            // 
            // BNTAccesoMarcas
            // 
            this.BNTAccesoMarcas.Location = new System.Drawing.Point(273, 12);
            this.BNTAccesoMarcas.Name = "BNTAccesoMarcas";
            this.BNTAccesoMarcas.Size = new System.Drawing.Size(222, 64);
            this.BNTAccesoMarcas.TabIndex = 9;
            this.BNTAccesoMarcas.Text = "Acceso Marcas";
            this.BNTAccesoMarcas.UseVisualStyleBackColor = true;
            this.BNTAccesoMarcas.Click += new System.EventHandler(this.BNTAccesoMarcas_Click);
            // 
            // BTNAccesoCategoria
            // 
            this.BTNAccesoCategoria.Location = new System.Drawing.Point(519, 12);
            this.BTNAccesoCategoria.Name = "BTNAccesoCategoria";
            this.BTNAccesoCategoria.Size = new System.Drawing.Size(226, 64);
            this.BTNAccesoCategoria.TabIndex = 10;
            this.BTNAccesoCategoria.Text = "Acceso Categoria";
            this.BTNAccesoCategoria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 517);
            this.Controls.Add(this.BTNAccesoCategoria);
            this.Controls.Add(this.BNTAccesoMarcas);
            this.Controls.Add(this.BTNAccesoProcductos);
            this.Controls.Add(this.CBOFiltros);
            this.Controls.Add(this.TXBBusqueda);
            this.Controls.Add(this.BTVerDetalle);
            this.Controls.Add(this.BTEliminar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTAgregarA);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.DGVProductos);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button BTNAccesoProcductos;
        private System.Windows.Forms.Button BNTAccesoMarcas;
        private System.Windows.Forms.Button BTNAccesoCategoria;
    }
}

