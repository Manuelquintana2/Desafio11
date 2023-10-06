namespace SistemaGestion
{
    partial class FrmEliminarVenta
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
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(305, 27);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 41;
            label2.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(200, 59);
            txtComentarios.Margin = new Padding(3, 4, 3, 4);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(356, 34);
            txtComentarios.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(305, 108);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 47;
            label6.Text = "Id Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(200, 150);
            txtIdUsuario.Margin = new Padding(3, 4, 3, 4);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(356, 34);
            txtIdUsuario.TabIndex = 48;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(292, 302);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 53);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmEliminarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(txtComentarios);
            Controls.Add(label2);
            Name = "FrmEliminarVenta";
            Text = "FrmEliminarVenta";
            Load += FrmEliminarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtComentarios;
        private Label label6;
        private TextBox txtIdUsuario;
        private Button btnEliminar;
    }
}