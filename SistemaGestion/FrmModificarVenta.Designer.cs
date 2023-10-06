namespace SistemaGestion
{
    partial class FrmModificarVenta
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
            label2 = new Label();
            txtComentarios = new TextBox();
            label6 = new Label();
            txtIdUsuario = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(300, 19);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 40;
            label2.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(195, 51);
            txtComentarios.Margin = new Padding(3, 4, 3, 4);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(356, 34);
            txtComentarios.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(300, 102);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 46;
            label6.Text = "Id Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(195, 144);
            txtIdUsuario.Margin = new Padding(3, 4, 3, 4);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(356, 34);
            txtIdUsuario.TabIndex = 47;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(278, 322);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(153, 53);
            btnModificar.TabIndex = 48;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmModificarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(txtComentarios);
            Controls.Add(label2);
            Name = "FrmModificarVenta";
            Text = "FrmModificarVenta";
            Load += FrmModificarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtComentarios;
        private Label label6;
        private TextBox txtIdUsuario;
        private Button btnModificar;
    }
}