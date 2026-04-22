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
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVProductos.Location = new System.Drawing.Point(12, 12);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(446, 378);
            this.DGVProductos.TabIndex = 0;
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(464, 12);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(278, 378);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 1;
            this.pbxProducto.TabStop = false;
            // 
            // BTAgregarA
            // 
            this.BTAgregarA.Location = new System.Drawing.Point(12, 399);
            this.BTAgregarA.Name = "BTAgregarA";
            this.BTAgregarA.Size = new System.Drawing.Size(105, 39);
            this.BTAgregarA.TabIndex = 2;
            this.BTAgregarA.Text = "Agregar";
            this.BTAgregarA.UseVisualStyleBackColor = true;
            this.BTAgregarA.Click += new System.EventHandler(this.BTAgregarA_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(353, 399);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(105, 39);
            this.BTNModificar.TabIndex = 3;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button BTAgregarA;
        private System.Windows.Forms.Button BTNModificar;
    }
}

