namespace Part_10___Adding_Forms
{
    partial class FormAddName
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
            this.btnDone = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(368, 75);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(103, 28);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 16;
            this.lstNames.Location = new System.Drawing.Point(12, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(222, 228);
            this.lstNames.TabIndex = 4;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(252, 27);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(226, 17);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Enter a Name Below and Click Add";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(258, 47);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(213, 22);
            this.txtAddName.TabIndex = 6;
            this.txtAddName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 261);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnDone);
            this.Name = "FormAddName";
            this.Text = " Add Name";
            this.Load += new System.EventHandler(this.FormAddName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAdd;
    }
}