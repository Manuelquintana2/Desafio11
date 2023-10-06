namespace SistemaGestion
{
    partial class FrmModificarProductoVendido
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
            label1 = new Label();
            numStock = new NumericUpDown();
            label6 = new Label();
            txtProducto = new TextBox();
            label2 = new Label();
            txtVenta = new TextBox();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(328, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 48;
            label1.Text = "Stock";
            // 
            // numStock
            // 
            numStock.DecimalPlaces = 2;
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location = new Point(276, 56);
            numStock.Margin = new Padding(3, 4, 3, 4);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(173, 34);
            numStock.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(308, 114);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 50;
            label6.Text = "Id Productos";
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.Location = new Point(190, 146);
            txtProducto.Margin = new Padding(3, 4, 3, 4);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(356, 34);
            txtProducto.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(308, 201);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 53;
            label2.Text = "Id Ventas";
            // 
            // txtVenta
            // 
            txtVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtVenta.Location = new Point(190, 233);
            txtVenta.Margin = new Padding(3, 4, 3, 4);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(356, 34);
            txtVenta.TabIndex = 54;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(286, 331);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(153, 53);
            btnModificar.TabIndex = 55;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmModificarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(txtVenta);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(label6);
            Controls.Add(numStock);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "FrmModificarProductoVendido";
            Text = "FrmModificarProductoVendido";
            Load += FrmModificarProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numStock;
        private Label label6;
        private TextBox txtProducto;
        private Label label2;
        private TextBox txtVenta;
        private Button btnModificar;
    }
}