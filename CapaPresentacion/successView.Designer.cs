namespace CapaPresentacion
{
    partial class successView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.closeSuccess = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radiusForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.formFade = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 289);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.check__2_;
            this.pictureBox1.Location = new System.Drawing.Point(141, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.DimGray;
            this.lblMessage.Location = new System.Drawing.Point(16, 314);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(393, 28);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "MENSAJE";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeSuccess
            // 
            this.closeSuccess.Active = false;
            this.closeSuccess.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeSuccess.BorderRadius = 0;
            this.closeSuccess.ButtonText = "ACEPTAR";
            this.closeSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSuccess.DisabledColor = System.Drawing.Color.Gray;
            this.closeSuccess.Iconcolor = System.Drawing.Color.Transparent;
            this.closeSuccess.Iconimage = null;
            this.closeSuccess.Iconimage_right = null;
            this.closeSuccess.Iconimage_right_Selected = null;
            this.closeSuccess.Iconimage_Selected = null;
            this.closeSuccess.IconMarginLeft = 0;
            this.closeSuccess.IconMarginRight = 0;
            this.closeSuccess.IconRightVisible = true;
            this.closeSuccess.IconRightZoom = 0D;
            this.closeSuccess.IconVisible = true;
            this.closeSuccess.IconZoom = 90D;
            this.closeSuccess.IsTab = false;
            this.closeSuccess.Location = new System.Drawing.Point(91, 368);
            this.closeSuccess.Margin = new System.Windows.Forms.Padding(5);
            this.closeSuccess.Name = "closeSuccess";
            this.closeSuccess.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.OnHoverTextColor = System.Drawing.Color.White;
            this.closeSuccess.selected = false;
            this.closeSuccess.Size = new System.Drawing.Size(239, 52);
            this.closeSuccess.TabIndex = 2;
            this.closeSuccess.Text = "ACEPTAR";
            this.closeSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeSuccess.Textcolor = System.Drawing.Color.White;
            this.closeSuccess.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSuccess.Click += new System.EventHandler(this.closeSuccess_Click);
            // 
            // radiusForm
            // 
            this.radiusForm.ElipseRadius = 5;
            this.radiusForm.TargetControl = this;
            // 
            // formFade
            // 
            this.formFade.Delay = 0;
            // 
            // successView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.boxshadow_notifications;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 448);
            this.Controls.Add(this.closeSuccess);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "successView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "successView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuFlatButton closeSuccess;
        private Bunifu.Framework.UI.BunifuElipse radiusForm;
        private Bunifu.Framework.UI.BunifuFormFadeTransition formFade;
    }
}