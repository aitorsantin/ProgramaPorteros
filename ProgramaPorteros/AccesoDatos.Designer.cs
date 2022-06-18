namespace ProgramaPorteros
{
    partial class AccesoDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbConexion = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la conexion a base de datos";
            // 
            // cbConexion
            // 
            this.cbConexion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConexion.FormattingEnabled = true;
            this.cbConexion.Location = new System.Drawing.Point(198, 84);
            this.cbConexion.Name = "cbConexion";
            this.cbConexion.Size = new System.Drawing.Size(393, 21);
            this.cbConexion.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(339, 143);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Aceptar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // AccesoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 207);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cbConexion);
            this.Controls.Add(this.label1);
            this.Name = "AccesoDatos";
            this.Text = "AccesoDatos";
            this.Load += new System.EventHandler(this.AccesoDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConexion;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}