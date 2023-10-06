namespace SistemaGestion
{
    partial class FrmCrearVenta
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
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(329, 29);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 39;
            label2.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(209, 61);
            txtComentarios.Margin = new Padding(3, 4, 3, 4);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(356, 34);
            txtComentarios.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(329, 125);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 45;
            label6.Text = "Id Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(209, 168);
            txtIdUsuario.Margin = new Padding(3, 4, 3, 4);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(356, 34);
            txtIdUsuario.TabIndex = 46;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(307, 329);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 53);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmCrearVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(txtComentarios);
            Controls.Add(label2);
            Name = "FrmCrearVenta";
            Text = "FrmCrearVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtComentarios;
        private Label label6;
        private TextBox txtIdUsuario;
        private Button btnGuardar;
    }
}