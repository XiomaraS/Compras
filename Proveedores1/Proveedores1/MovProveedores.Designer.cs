﻿namespace Proveedores1
{
    partial class MovProveedores
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
            this.Dgv_movProv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movProv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_movProv
            // 
            this.Dgv_movProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_movProv.Location = new System.Drawing.Point(31, 174);
            this.Dgv_movProv.Name = "Dgv_movProv";
            this.Dgv_movProv.Size = new System.Drawing.Size(592, 169);
            this.Dgv_movProv.TabIndex = 0;
            this.Dgv_movProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_movProv_CellContentClick);
            this.Dgv_movProv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_movProv_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo Movimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movimientos Proveedores";
            // 
            // MovProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(691, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dgv_movProv);
            this.Name = "MovProveedores";
            this.Text = "6201 Movimientos Proveedores";
            this.Load += new System.EventHandler(this.MovProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Dgv_movProv;
    }
}