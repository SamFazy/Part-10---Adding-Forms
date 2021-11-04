namespace Part_10___Adding_Forms
{
    partial class frmChangeName
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
            this.lblChosenName = new System.Windows.Forms.Label();
            this.txtChangeName = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChosenName
            // 
            this.lblChosenName.AutoSize = true;
            this.lblChosenName.Location = new System.Drawing.Point(12, 18);
            this.lblChosenName.Name = "lblChosenName";
            this.lblChosenName.Size = new System.Drawing.Size(239, 17);
            this.lblChosenName.TabIndex = 0;
            this.lblChosenName.Text = "The Name You Chose To Change Is:";
            // 
            // txtChangeName
            // 
            this.txtChangeName.Location = new System.Drawing.Point(89, 75);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(205, 22);
            this.txtChangeName.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(89, 103);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(96, 28);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 55);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(352, 17);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Type In What You Want The Name To Be Changed To";
            // 
            // frmChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 156);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtChangeName);
            this.Controls.Add(this.lblChosenName);
            this.Name = "frmChangeName";
            this.Text = "FormChangeName";
            this.Load += new System.EventHandler(this.frmChangeName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChosenName;
        private System.Windows.Forms.TextBox txtChangeName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInstructions;
    }
}