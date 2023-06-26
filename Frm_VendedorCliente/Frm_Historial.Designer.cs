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
            btnGuardarArchivo = new Button();
            btnSerializarProductos = new Button();
            label1 = new Label();
            btnSerializarProdXml = new Button();
            btnDeserializarJson = new Button();
            btnDeserializarXml = new Button();
            label2 = new Label();
            btnSerializarVentasJson = new Button();
            btnDeserializarVentaJson = new Button();
            btnDeserializarVentaXml = new Button();
            btnSerializarVentasXml = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.BackColor = Color.GhostWhite;
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
            btnVolver.Location = new Point(438, 503);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 27);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.BackgroundColor = SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, vendedor, cliente, precio });
            dgv.Location = new Point(12, 49);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(501, 177);
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
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.BackColor = Color.DarkGreen;
            btnGuardarArchivo.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarArchivo.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarArchivo.Location = new Point(27, 274);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(130, 48);
            btnGuardarArchivo.TabIndex = 14;
            btnGuardarArchivo.Text = "Guardar\r\nhistorial\r\n";
            btnGuardarArchivo.UseVisualStyleBackColor = false;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnSerializarProductos
            // 
            btnSerializarProductos.BackColor = Color.DarkGreen;
            btnSerializarProductos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarProductos.ForeColor = SystemColors.MenuBar;
            btnSerializarProductos.Location = new Point(27, 328);
            btnSerializarProductos.Name = "btnSerializarProductos";
            btnSerializarProductos.Size = new Size(130, 42);
            btnSerializarProductos.TabIndex = 17;
            btnSerializarProductos.Text = "Serializar productos\r\nen JSON";
            btnSerializarProductos.UseVisualStyleBackColor = false;
            btnSerializarProductos.Click += btnSerializarProductos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(27, 233);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 18;
            label1.Text = "Opciones para\r\nGUARDADO de datos:";
            // 
            // btnSerializarProdXml
            // 
            btnSerializarProdXml.BackColor = Color.DarkGreen;
            btnSerializarProdXml.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarProdXml.ForeColor = SystemColors.ControlLightLight;
            btnSerializarProdXml.Location = new Point(27, 376);
            btnSerializarProdXml.Name = "btnSerializarProdXml";
            btnSerializarProdXml.Size = new Size(130, 42);
            btnSerializarProdXml.TabIndex = 19;
            btnSerializarProdXml.Text = "Serializar productos en xml";
            btnSerializarProdXml.UseVisualStyleBackColor = false;
            btnSerializarProdXml.Click += btnSerializarProdXml_Click;
            // 
            // btnDeserializarJson
            // 
            btnDeserializarJson.BackColor = Color.Blue;
            btnDeserializarJson.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarJson.ForeColor = SystemColors.ControlLightLight;
            btnDeserializarJson.Location = new Point(323, 274);
            btnDeserializarJson.Name = "btnDeserializarJson";
            btnDeserializarJson.Size = new Size(130, 42);
            btnDeserializarJson.TabIndex = 20;
            btnDeserializarJson.Text = "Deserializar productos en json";
            btnDeserializarJson.UseVisualStyleBackColor = false;
            btnDeserializarJson.Click += btnDeserializarJson_Click;
            // 
            // btnDeserializarXml
            // 
            btnDeserializarXml.BackColor = Color.Blue;
            btnDeserializarXml.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarXml.ForeColor = SystemColors.ControlLightLight;
            btnDeserializarXml.Location = new Point(323, 322);
            btnDeserializarXml.Name = "btnDeserializarXml";
            btnDeserializarXml.Size = new Size(130, 42);
            btnDeserializarXml.TabIndex = 21;
            btnDeserializarXml.Text = "Deserializar productos en xml";
            btnDeserializarXml.UseVisualStyleBackColor = false;
            btnDeserializarXml.Click += btnDeserializarXml_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(323, 233);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 22;
            label2.Text = "Opciones para\r\nLECTURA de datos:\r\n";
            // 
            // btnSerializarVentasJson
            // 
            btnSerializarVentasJson.BackColor = Color.DarkGreen;
            btnSerializarVentasJson.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarVentasJson.ForeColor = SystemColors.ControlLightLight;
            btnSerializarVentasJson.Location = new Point(27, 424);
            btnSerializarVentasJson.Name = "btnSerializarVentasJson";
            btnSerializarVentasJson.Size = new Size(130, 42);
            btnSerializarVentasJson.TabIndex = 23;
            btnSerializarVentasJson.Text = "Serializar ventas en JSON";
            btnSerializarVentasJson.UseVisualStyleBackColor = false;
            btnSerializarVentasJson.Click += btnSerializarVentasJson_Click;
            // 
            // btnDeserializarVentaJson
            // 
            btnDeserializarVentaJson.BackColor = Color.Blue;
            btnDeserializarVentaJson.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarVentaJson.ForeColor = SystemColors.ControlLightLight;
            btnDeserializarVentaJson.Location = new Point(323, 370);
            btnDeserializarVentaJson.Name = "btnDeserializarVentaJson";
            btnDeserializarVentaJson.Size = new Size(130, 42);
            btnDeserializarVentaJson.TabIndex = 24;
            btnDeserializarVentaJson.Text = "Deserializar ventas en json";
            btnDeserializarVentaJson.UseVisualStyleBackColor = false;
            btnDeserializarVentaJson.Click += btnDeserializarVentaJson_Click;
            // 
            // btnDeserializarVentaXml
            // 
            btnDeserializarVentaXml.BackColor = Color.Blue;
            btnDeserializarVentaXml.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarVentaXml.ForeColor = SystemColors.ControlLightLight;
            btnDeserializarVentaXml.Location = new Point(323, 418);
            btnDeserializarVentaXml.Name = "btnDeserializarVentaXml";
            btnDeserializarVentaXml.Size = new Size(130, 42);
            btnDeserializarVentaXml.TabIndex = 25;
            btnDeserializarVentaXml.Text = "Deserializar ventas en xml";
            btnDeserializarVentaXml.UseVisualStyleBackColor = false;
            btnDeserializarVentaXml.Click += btnDeserializarVentaXml_Click;
            // 
            // btnSerializarVentasXml
            // 
            btnSerializarVentasXml.BackColor = Color.DarkGreen;
            btnSerializarVentasXml.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarVentasXml.ForeColor = SystemColors.ControlLightLight;
            btnSerializarVentasXml.Location = new Point(27, 472);
            btnSerializarVentasXml.Name = "btnSerializarVentasXml";
            btnSerializarVentasXml.Size = new Size(130, 42);
            btnSerializarVentasXml.TabIndex = 26;
            btnSerializarVentasXml.Text = "Serializar ventas en xml";
            btnSerializarVentasXml.UseVisualStyleBackColor = false;
            btnSerializarVentasXml.Click += btnSerializarVentasXml_Click;
            // 
            // Frm_Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(525, 542);
            Controls.Add(btnSerializarVentasXml);
            Controls.Add(btnDeserializarVentaXml);
            Controls.Add(btnDeserializarVentaJson);
            Controls.Add(btnSerializarVentasJson);
            Controls.Add(label2);
            Controls.Add(btnDeserializarXml);
            Controls.Add(btnDeserializarJson);
            Controls.Add(btnSerializarProdXml);
            Controls.Add(label1);
            Controls.Add(btnSerializarProductos);
            Controls.Add(btnGuardarArchivo);
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
        private Button btnGuardarArchivo;
        private Button btnSerializarProductos;
        private Label label1;
        private Button btnSerializarProdXml;
        private Button btnDeserializarJson;
        private Button btnDeserializarXml;
        private Label label2;
        private Button btnSerializarVentasJson;
        private Button btnDeserializarVentaJson;
        private Button btnDeserializarVentaXml;
        private Button btnSerializarVentasXml;
    }
}