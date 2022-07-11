namespace ProyectoLibros
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvComics = new System.Windows.Forms.DataGridView();
            this.lblListado = new System.Windows.Forms.Label();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAutorModificado = new System.Windows.Forms.TextBox();
            this.lblTipoModificado = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtNombreModificado = new System.Windows.Forms.TextBox();
            this.lblNombreModificado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.lblIngresar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(507, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 154);
            this.panel1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(255, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(15, 112);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(133, 20);
            this.txtAutor.TabIndex = 4;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Autor:";
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(12, 11);
            this.lblIngresar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(71, 13);
            this.lblIngresar.TabIndex = 2;
            this.lblIngresar.Text = "Ingresar Libro";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // dgvComics
            // 
            this.dgvComics.AccessibleName = "";
            this.dgvComics.AllowUserToAddRows = false;
            this.dgvComics.AllowUserToDeleteRows = false;
            this.dgvComics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComics.Location = new System.Drawing.Point(12, 53);
            this.dgvComics.MultiSelect = false;
            this.dgvComics.Name = "dgvComics";
            this.dgvComics.ReadOnly = true;
            this.dgvComics.Size = new System.Drawing.Size(478, 426);
            this.dgvComics.TabIndex = 3;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(186, 9);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(115, 13);
            this.lblListado.TabIndex = 4;
            this.lblListado.Text = "LISTADO DE COMICS";
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(136, 37);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(216, 13);
            this.lblSeleccionar.TabIndex = 5;
            this.lblSeleccionar.Text = "Seleccionar un libro para modificar o eliminar\r\n";
            this.lblSeleccionar.Click += new System.EventHandler(this.lblSeleccionar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.txtAutorModificado);
            this.panel2.Controls.Add(this.lblTipoModificado);
            this.panel2.Controls.Add(this.lblModificar);
            this.panel2.Controls.Add(this.txtNombreModificado);
            this.panel2.Controls.Add(this.lblNombreModificado);
            this.panel2.Location = new System.Drawing.Point(507, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 158);
            this.panel2.TabIndex = 6;
            // 
            // txtAutorModificado
            // 
            this.txtAutorModificado.Location = new System.Drawing.Point(15, 112);
            this.txtAutorModificado.Name = "txtAutorModificado";
            this.txtAutorModificado.Size = new System.Drawing.Size(133, 20);
            this.txtAutorModificado.TabIndex = 4;
            // 
            // lblTipoModificado
            // 
            this.lblTipoModificado.AutoSize = true;
            this.lblTipoModificado.Location = new System.Drawing.Point(15, 96);
            this.lblTipoModificado.Name = "lblTipoModificado";
            this.lblTipoModificado.Size = new System.Drawing.Size(35, 13);
            this.lblTipoModificado.TabIndex = 3;
            this.lblTipoModificado.Text = "Autor:";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(12, 11);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(76, 13);
            this.lblModificar.TabIndex = 2;
            this.lblModificar.Text = "Modificar Libro";
            this.lblModificar.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombreModificado
            // 
            this.txtNombreModificado.Location = new System.Drawing.Point(15, 57);
            this.txtNombreModificado.Name = "txtNombreModificado";
            this.txtNombreModificado.Size = new System.Drawing.Size(133, 20);
            this.txtNombreModificado.TabIndex = 1;
            // 
            // lblNombreModificado
            // 
            this.lblNombreModificado.AutoSize = true;
            this.lblNombreModificado.Location = new System.Drawing.Point(12, 41);
            this.lblNombreModificado.Name = "lblNombreModificado";
            this.lblNombreModificado.Size = new System.Drawing.Size(47, 13);
            this.lblNombreModificado.TabIndex = 0;
            this.lblNombreModificado.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(793, 53);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 27);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(255, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 20);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 534);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvComics);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvComics;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAutorModificado;
        private System.Windows.Forms.Label lblTipoModificado;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.TextBox txtNombreModificado;
        private System.Windows.Forms.Label lblNombreModificado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}

