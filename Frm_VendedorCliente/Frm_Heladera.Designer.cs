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
            nombre = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoCorte = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtDetalle = new TextBox();
            label5 = new Label();
            txtCorte = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnVolver = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, stock, precio, detalle, tipoCorte });
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(12, 45);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(544, 360);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
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
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            detalle.ReadOnly = true;
            // 
            // tipoCorte
            // 
            tipoCorte.HeaderText = "Tipo de corte";
            tipoCorte.Name = "tipoCorte";
            tipoCorte.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(562, 45);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(562, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 3;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(562, 137);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(562, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(562, 111);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(562, 157);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(562, 183);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 9;
            label4.Text = "Detalle";
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(562, 203);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(100, 23);
            txtDetalle.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(562, 229);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 11;
            label5.Text = "Corte";
            // 
            // txtCorte
            // 
            txtCorte.Location = new Point(562, 249);
            txtCorte.Name = "txtCorte";
            txtCorte.Size = new Size(100, 23);
            txtCorte.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuHighlight;
            btnAgregar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(562, 377);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 28);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.MenuHighlight;
            btnModificar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(562, 290);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 43);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Guardar cambios";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.MenuHighlight;
            btnBorrar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(562, 339);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 29);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(562, 411);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 5);
            label7.Name = "label7";
            label7.Size = new Size(169, 37);
            label7.TabIndex = 20;
            label7.Text = "Heladera";
            // 
            // Frm_Heladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(688, 463);
            Controls.Add(label7);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorte);
            Controls.Add(label5);
            Controls.Add(txtDetalle);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDetalle;
        private Label label5;
        private TextBox txtCorte;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnVolver;
        private Label label7;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
    }
}