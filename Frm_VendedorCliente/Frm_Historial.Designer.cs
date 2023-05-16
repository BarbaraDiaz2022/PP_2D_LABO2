namespace Frm_VendedorCliente
{
    partial class Frm_Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Historial));
            lblHistorial = new Label();
            btnVolver = new Button();
            dgv = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            vendedor = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.BackColor = Color.Thistle;
            lblHistorial.BorderStyle = BorderStyle.FixedSingle;
            lblHistorial.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(165, 9);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(210, 37);
            lblHistorial.TabIndex = 11;
            lblHistorial.Text = "HISTORIAL";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(403, 411);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 39);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.BackgroundColor = SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, vendedor, cliente, precio });
            dgv.Location = new Point(12, 49);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(501, 356);
            dgv.TabIndex = 13;
            dgv.CellBeginEdit += dgv_CellBeginEdit;
            // 
            // nombre
            // 
            nombre.HeaderText = "Producto vendido";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // vendedor
            // 
            vendedor.HeaderText = "Vendido por";
            vendedor.Name = "vendedor";
            vendedor.ReadOnly = true;
            // 
            // cliente
            // 
            cliente.HeaderText = "Vendido al cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Monto";
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 125;
            // 
            // Frm_Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(525, 450);
            Controls.Add(dgv);
            Controls.Add(btnVolver);
            Controls.Add(lblHistorial);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Historial";
            Text = "Historial de ventas";
            Load += Frm_Historial_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHistorial;
        private Button btnVolver;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn vendedor;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn precio;
    }
}