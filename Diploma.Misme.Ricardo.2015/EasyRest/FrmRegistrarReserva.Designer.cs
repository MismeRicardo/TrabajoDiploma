namespace EasyRest
{
    partial class FrmRegistrarReserva
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
            this.btnVeriCli = new DevComponents.DotNetBar.ButtonX();
            this.txtDniCli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDniCli = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnVeriCli
            // 
            this.btnVeriCli.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVeriCli.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVeriCli.Location = new System.Drawing.Point(321, 26);
            this.btnVeriCli.Name = "btnVeriCli";
            this.btnVeriCli.Size = new System.Drawing.Size(75, 23);
            this.btnVeriCli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVeriCli.TabIndex = 0;
            this.btnVeriCli.Text = "Verificar";
            // 
            // txtDniCli
            // 
            this.txtDniCli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDniCli.Border.Class = "TextBoxBorder";
            this.txtDniCli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDniCli.ForeColor = System.Drawing.Color.Black;
            this.txtDniCli.Location = new System.Drawing.Point(176, 26);
            this.txtDniCli.Name = "txtDniCli";
            this.txtDniCli.Size = new System.Drawing.Size(100, 20);
            this.txtDniCli.TabIndex = 1;
            // 
            // lblDniCli
            // 
            // 
            // 
            // 
            this.lblDniCli.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDniCli.Location = new System.Drawing.Point(62, 26);
            this.lblDniCli.Name = "lblDniCli";
            this.lblDniCli.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDniCli.Size = new System.Drawing.Size(75, 23);
            this.lblDniCli.TabIndex = 2;
            this.lblDniCli.Text = "DNI Cliente";
            this.lblDniCli.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // FrmRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 399);
            this.Controls.Add(this.lblDniCli);
            this.Controls.Add(this.txtDniCli);
            this.Controls.Add(this.btnVeriCli);
            this.DoubleBuffered = true;
            this.Name = "FrmRegistrarReserva";
            this.Text = "FrmRegistrarReserva";
            this.Load += new System.EventHandler(this.FrmRegistrarReserva_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnVeriCli;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDniCli;
        private DevComponents.DotNetBar.LabelX lblDniCli;

 
    }
}