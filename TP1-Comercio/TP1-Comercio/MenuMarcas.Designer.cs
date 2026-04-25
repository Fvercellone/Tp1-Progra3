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
            this.BTEliminar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LBNombre = new System.Windows.Forms.Label();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBID = new System.Windows.Forms.TextBox();
            this.LBID = new System.Windows.Forms.Label();
            this.TBNombre2 = new System.Windows.Forms.TextBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAcepModificacion = new System.Windows.Forms.Button();
            this.LBNombre2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // BTEliminar
            // 
            this.BTEliminar.Location = new System.Drawing.Point(111, 462);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(105, 39);
            this.BTEliminar.TabIndex = 15;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = true;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(264, 462);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(105, 39);
            this.BTNModificar.TabIndex = 14;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
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
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(98, 111);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 33;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // BTAceptar
            // 
            this.BTAceptar.Enabled = false;
            this.BTAceptar.Location = new System.Drawing.Point(17, 111);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 32;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = true;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(74, 60);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 26;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Location = new System.Drawing.Point(24, 63);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(44, 13);
            this.LBNombre.TabIndex = 25;
            this.LBNombre.Text = "Nombre";
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Location = new System.Drawing.Point(45, 16);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(101, 13);
            this.LBTitulo.TabIndex = 40;
            this.LBTitulo.Text = "AGREGAR MARCA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBNombre);
            this.groupBox1.Controls.Add(this.BTCancelar);
            this.groupBox1.Controls.Add(this.LBTitulo);
            this.groupBox1.Controls.Add(this.BTAceptar);
            this.groupBox1.Controls.Add(this.LBNombre);
            this.groupBox1.Location = new System.Drawing.Point(519, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 154);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBID);
            this.groupBox2.Controls.Add(this.LBID);
            this.groupBox2.Controls.Add(this.TBNombre2);
            this.groupBox2.Controls.Add(this.BTNCancelar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BTNAcepModificacion);
            this.groupBox2.Controls.Add(this.LBNombre2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(519, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 154);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(73, 43);
            this.TBID.Name = "TBID";
            this.TBID.ReadOnly = true;
            this.TBID.Size = new System.Drawing.Size(100, 20);
            this.TBID.TabIndex = 42;
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Location = new System.Drawing.Point(23, 46);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(18, 13);
            this.LBID.TabIndex = 41;
            this.LBID.Text = "ID";
            // 
            // TBNombre2
            // 
            this.TBNombre2.Location = new System.Drawing.Point(74, 71);
            this.TBNombre2.Name = "TBNombre2";
            this.TBNombre2.Size = new System.Drawing.Size(100, 20);
            this.TBNombre2.TabIndex = 26;
            this.TBNombre2.TextChanged += new System.EventHandler(this.TBNombre2_TextChanged);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(98, 111);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 33;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "MODIFICAR MARCA";
            // 
            // BTNAcepModificacion
            // 
            this.BTNAcepModificacion.Enabled = false;
            this.BTNAcepModificacion.Location = new System.Drawing.Point(17, 111);
            this.BTNAcepModificacion.Name = "BTNAcepModificacion";
            this.BTNAcepModificacion.Size = new System.Drawing.Size(75, 23);
            this.BTNAcepModificacion.TabIndex = 32;
            this.BTNAcepModificacion.Text = "Aceptar";
            this.BTNAcepModificacion.UseVisualStyleBackColor = true;
            this.BTNAcepModificacion.Click += new System.EventHandler(this.BTNAcepModificacion_Click);
            // 
            // LBNombre2
            // 
            this.LBNombre2.AutoSize = true;
            this.LBNombre2.Location = new System.Drawing.Point(24, 74);
            this.LBNombre2.Name = "LBNombre2";
            this.LBNombre2.Size = new System.Drawing.Size(44, 13);
            this.LBNombre2.TabIndex = 25;
            this.LBNombre2.Text = "Nombre";
            // 
            // MenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNAccesoCategoria);
            this.Controls.Add(this.BNTAccesoMarcas);
            this.Controls.Add(this.BTNAccesoProcductos);
            this.Controls.Add(this.CBOFiltros);
            this.Controls.Add(this.TXBBusqueda);
            this.Controls.Add(this.BTEliminar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.DGVProductos);
            this.Name = "MenuMarcas";
            this.Text = "MenuMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAccesoCategoria;
        private System.Windows.Forms.Button BNTAccesoMarcas;
        private System.Windows.Forms.Button BTNAccesoProcductos;
        private System.Windows.Forms.ComboBox CBOFiltros;
        private System.Windows.Forms.TextBox TXBBusqueda;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBNombre2;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNAcepModificacion;
        private System.Windows.Forms.Label LBNombre2;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Label LBID;
    }
}