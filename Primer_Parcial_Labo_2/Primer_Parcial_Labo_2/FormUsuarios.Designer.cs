﻿namespace Primer_Parcial_Labo_2
{
    partial class FormUsuarios
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.lbl_usuarios = new System.Windows.Forms.Label();
            this.btn_agregarUsuario = new System.Windows.Forms.Button();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(480, 26);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowTemplate.Height = 25;
            this.dgv_usuarios.Size = new System.Drawing.Size(435, 457);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // lbl_usuarios
            // 
            this.lbl_usuarios.AutoSize = true;
            this.lbl_usuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuarios.Location = new System.Drawing.Point(12, 9);
            this.lbl_usuarios.Name = "lbl_usuarios";
            this.lbl_usuarios.Size = new System.Drawing.Size(95, 30);
            this.lbl_usuarios.TabIndex = 1;
            this.lbl_usuarios.Text = "Usuarios";
            // 
            // btn_agregarUsuario
            // 
            this.btn_agregarUsuario.Location = new System.Drawing.Point(12, 72);
            this.btn_agregarUsuario.Name = "btn_agregarUsuario";
            this.btn_agregarUsuario.Size = new System.Drawing.Size(216, 41);
            this.btn_agregarUsuario.TabIndex = 4;
            this.btn_agregarUsuario.Text = "Agregar usuario";
            this.btn_agregarUsuario.UseVisualStyleBackColor = true;
            this.btn_agregarUsuario.Click += new System.EventHandler(this.btn_agregarUsuario_Click);
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(251, 72);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(216, 41);
            this.btn_eliminarUsuario.TabIndex = 5;
            this.btn_eliminarUsuario.Text = "Eliminar usuario";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Location = new System.Drawing.Point(12, 128);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(455, 355);
            this.pnl_contenedor.TabIndex = 6;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 495);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.btn_eliminarUsuario);
            this.Controls.Add(this.btn_agregarUsuario);
            this.Controls.Add(this.lbl_usuarios);
            this.Controls.Add(this.dgv_usuarios);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label lbl_usuarios;
        private System.Windows.Forms.Button btn_agregarUsuario;
        private System.Windows.Forms.Button btn_eliminarUsuario;
        private System.Windows.Forms.Panel pnl_contenedor;
    }
}