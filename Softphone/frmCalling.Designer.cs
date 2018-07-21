namespace Softphone
{
    partial class frmCalling
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
            this.btnHangup = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnAccpect = new System.Windows.Forms.Button();
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHangup
            // 
            this.btnHangup.BackColor = System.Drawing.Color.Teal;
            this.btnHangup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangup.ForeColor = System.Drawing.Color.DimGray;
            this.btnHangup.Location = new System.Drawing.Point(285, 75);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.Size = new System.Drawing.Size(81, 45);
            this.btnHangup.TabIndex = 22;
            this.btnHangup.Text = "Hangup";
            this.btnHangup.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.Teal;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.DimGray;
            this.btnHold.Location = new System.Drawing.Point(164, 75);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(67, 46);
            this.btnHold.TabIndex = 21;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            // 
            // btnAccpect
            // 
            this.btnAccpect.BackColor = System.Drawing.Color.Teal;
            this.btnAccpect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccpect.ForeColor = System.Drawing.Color.DimGray;
            this.btnAccpect.Location = new System.Drawing.Point(21, 76);
            this.btnAccpect.Name = "btnAccpect";
            this.btnAccpect.Size = new System.Drawing.Size(87, 45);
            this.btnAccpect.TabIndex = 20;
            this.btnAccpect.Text = "Accpect";
            this.btnAccpect.UseVisualStyleBackColor = false;
            this.btnAccpect.Click += new System.EventHandler(this.btnAccpect_Click);
            // 
            // lb_Log
            // 
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(56, 185);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(321, 264);
            this.lb_Log.TabIndex = 23;
            // 
            // frmCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 486);
            this.Controls.Add(this.lb_Log);
            this.Controls.Add(this.btnHangup);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnAccpect);
            this.Name = "frmCalling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCalling";
            this.Load += new System.EventHandler(this.frmCalling_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHangup;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnAccpect;
        private System.Windows.Forms.ListBox lb_Log;
    }
}