namespace Frm_VendedorCliente
{
    partial class Frm_Heladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Heladera));
            dgv = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoCorte = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtCorte = new TextBox();
            btnModificar = new Button();
            btnVolver = new Button();
            label7 = new Label();
            btnAgregar = new Button();
            lbl = new Label();
            lbltipo = new Label();
            txtNombre = new TextBox();
            txtDetalle = new TextBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { idProducto, nombre, stock, precio, detalle, tipoCorte });
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(12, 320);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(676, 200);
            dgv.TabIndex = 0;
            dgv.CellBeginEdit += dgv_CellBeginEdit;
            dgv.CellClick += dgv_CellClick;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "Codigo";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Width = 50;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 50;
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 70;
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            detalle.ReadOnly = true;
            detalle.Width = 242;
            // 
            // tipoCorte
            // 
            tipoCorte.HeaderText = "Tipo de corte";
            tipoCorte.Name = "tipoCorte";
            tipoCorte.ReadOnly = true;
            tipoCorte.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 3;
            label2.Text = "Fijar stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 5;
            label3.Text = "Fijar precio:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(125, 85);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(161, 23);
            txtStock.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(125, 127);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(161, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 172);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 11;
            label5.Text = "Fijar corte:";
            // 
            // txtCorte
            // 
            txtCorte.Location = new Point(125, 166);
            txtCorte.Name = "txtCorte";
            txtCorte.Size = new Size(161, 23);
            txtCorte.TabIndex = 12;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.MenuHighlight;
            btnModificar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(350, 73);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(159, 46);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Guardar cambios";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(350, 232);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(159, 36);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(274, 63);
            label7.TabIndex = 20;
            label7.Text = "Heladera";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuHighlight;
            btnAgregar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(350, 125);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 46);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.GhostWhite;
            lbl.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(12, 211);
            lbl.Name = "lbl";
            lbl.Size = new Size(72, 17);
            lbl.TabIndex = 22;
            lbl.Text = "Nombre : ";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.BackColor = Color.GhostWhite;
            lbltipo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbltipo.Location = new Point(12, 251);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(65, 17);
            lbltipo.TabIndex = 23;
            lbltipo.Text = "Detalle : ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 205);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 23);
            txtNombre.TabIndex = 24;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(125, 245);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(161, 23);
            txtDetalle.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.MenuHighlight;
            btnEliminar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(350, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 46);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Frm_Heladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(722, 532);
            Controls.Add(btnEliminar);
            Controls.Add(txtDetalle);
            Controls.Add(txtNombre);
            Controls.Add(lbltipo);
            Controls.Add(lbl);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(txtCorte);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Heladera";
            Text = "Heladera";
            Load += Frm_Heladera_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label2;
        private Label label3;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtCorte;
        private Button btnModificar;
        private Button btnVolver;
        private Label label7;
        private Button btnAgregar;
        private Label lbl;
        private Label lbltipo;
        private TextBox txtNombre;
        private TextBox txtDetalle;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
    }
}