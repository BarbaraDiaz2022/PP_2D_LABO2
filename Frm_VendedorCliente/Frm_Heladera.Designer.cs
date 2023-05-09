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
            label2 = new Label();
            label3 = new Label();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtCorte = new TextBox();
            btnModificar = new Button();
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
            dgv.Location = new Point(12, 167);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(624, 362);
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
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 3;
            label2.Text = "Reponer stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 5;
            label3.Text = "Fijar precio:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(125, 57);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(125, 86);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 11;
            label5.Text = "Fijar corte:";
            // 
            // txtCorte
            // 
            txtCorte.Location = new Point(125, 115);
            txtCorte.Name = "txtCorte";
            txtCorte.Size = new Size(100, 23);
            txtCorte.TabIndex = 12;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.MenuHighlight;
            btnModificar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(242, 57);
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
            btnVolver.Location = new Point(242, 115);
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
            BackColor = Color.Thistle;
            ClientSize = new Size(641, 532);
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
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
    }
}