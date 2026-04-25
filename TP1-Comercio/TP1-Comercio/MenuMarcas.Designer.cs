namespace TP1_Comercio
{
    partial class MenuMarcas
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
            this.BTNAccesoCategoria = new System.Windows.Forms.Button();
            this.BNTAccesoMarcas = new System.Windows.Forms.Button();
            this.BTNAccesoProcductos = new System.Windows.Forms.Button();
            this.CBOFiltros = new System.Windows.Forms.ComboBox();
            this.TXBBusqueda = new System.Windows.Forms.TextBox();
            this.BTVerDetalle = new System.Windows.Forms.Button();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTAgregarA = new System.Windows.Forms.Button();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAccesoCategoria
            // 
            this.BTNAccesoCategoria.Location = new System.Drawing.Point(519, 5);
            this.BTNAccesoCategoria.Name = "BTNAccesoCategoria";
            this.BTNAccesoCategoria.Size = new System.Drawing.Size(226, 64);
            this.BTNAccesoCategoria.TabIndex = 21;
            this.BTNAccesoCategoria.Text = "Acceso Categoria";
            this.BTNAccesoCategoria.UseVisualStyleBackColor = true;
            // 
            // BNTAccesoMarcas
            // 
            this.BNTAccesoMarcas.Location = new System.Drawing.Point(273, 5);
            this.BNTAccesoMarcas.Name = "BNTAccesoMarcas";
            this.BNTAccesoMarcas.Size = new System.Drawing.Size(222, 64);
            this.BNTAccesoMarcas.TabIndex = 20;
            this.BNTAccesoMarcas.Text = "Acceso Marcas";
            this.BNTAccesoMarcas.UseVisualStyleBackColor = true;
            this.BNTAccesoMarcas.Click += new System.EventHandler(this.BNTAccesoMarcas_Click);
            // 
            // BTNAccesoProcductos
            // 
            this.BTNAccesoProcductos.Location = new System.Drawing.Point(13, 5);
            this.BTNAccesoProcductos.Name = "BTNAccesoProcductos";
            this.BTNAccesoProcductos.Size = new System.Drawing.Size(215, 64);
            this.BTNAccesoProcductos.TabIndex = 19;
            this.BTNAccesoProcductos.Text = "Acceso Procductos";
            this.BTNAccesoProcductos.UseVisualStyleBackColor = true;
            this.BTNAccesoProcductos.Click += new System.EventHandler(this.BTNAccesoProcductos_Click);
            // 
            // CBOFiltros
            // 
            this.CBOFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOFiltros.FormattingEnabled = true;
            this.CBOFiltros.Location = new System.Drawing.Point(13, 433);
            this.CBOFiltros.Name = "CBOFiltros";
            this.CBOFiltros.Size = new System.Drawing.Size(121, 21);
            this.CBOFiltros.TabIndex = 18;
            // 
            // TXBBusqueda
            // 
            this.TXBBusqueda.Location = new System.Drawing.Point(140, 433);
            this.TXBBusqueda.Name = "TXBBusqueda";
            this.TXBBusqueda.Size = new System.Drawing.Size(310, 20);
            this.TXBBusqueda.TabIndex = 17;
            this.TXBBusqueda.TextChanged += new System.EventHandler(this.TXBBusqueda_TextChanged);
            // 
            // BTVerDetalle
            // 
            this.BTVerDetalle.Location = new System.Drawing.Point(345, 462);
            this.BTVerDetalle.Name = "BTVerDetalle";
            this.BTVerDetalle.Size = new System.Drawing.Size(105, 39);
            this.BTVerDetalle.TabIndex = 16;
            this.BTVerDetalle.Text = "Ver Detalle";
            this.BTVerDetalle.UseVisualStyleBackColor = true;
            // 
            // BTEliminar
            // 
            this.BTEliminar.Location = new System.Drawing.Point(123, 462);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(105, 39);
            this.BTEliminar.TabIndex = 15;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = true;
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(234, 462);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(105, 39);
            this.BTNModificar.TabIndex = 14;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            // 
            // BTAgregarA
            // 
            this.BTAgregarA.Location = new System.Drawing.Point(12, 462);
            this.BTAgregarA.Name = "BTAgregarA";
            this.BTAgregarA.Size = new System.Drawing.Size(105, 39);
            this.BTAgregarA.TabIndex = 13;
            this.BTAgregarA.Text = "Agregar";
            this.BTAgregarA.UseVisualStyleBackColor = true;
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(464, 75);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(278, 378);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 12;
            this.pbxProducto.TabStop = false;
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVProductos.Location = new System.Drawing.Point(12, 75);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(446, 352);
            this.DGVProductos.TabIndex = 11;
            // 
            // MenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
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
            this.Name = "MenuMarcas";
            this.Text = "MenuMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAccesoCategoria;
        private System.Windows.Forms.Button BNTAccesoMarcas;
        private System.Windows.Forms.Button BTNAccesoProcductos;
        private System.Windows.Forms.ComboBox CBOFiltros;
        private System.Windows.Forms.TextBox TXBBusqueda;
        private System.Windows.Forms.Button BTVerDetalle;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTAgregarA;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.DataGridView DGVProductos;
    }
}