namespace Part_10___Adding_Forms
{
    partial class frmMain
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnEditNames = new System.Windows.Forms.Button();
            this.btnRemoveNames = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 12);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(142, 28);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnEditNames
            // 
            this.btnEditNames.Location = new System.Drawing.Point(12, 46);
            this.btnEditNames.Name = "btnEditNames";
            this.btnEditNames.Size = new System.Drawing.Size(142, 28);
            this.btnEditNames.TabIndex = 1;
            this.btnEditNames.Text = "Edit Names";
            this.btnEditNames.UseVisualStyleBackColor = true;
            this.btnEditNames.Click += new System.EventHandler(this.btnEditNames_Click);
            // 
            // btnRemoveNames
            // 
            this.btnRemoveNames.Location = new System.Drawing.Point(12, 80);
            this.btnRemoveNames.Name = "btnRemoveNames";
            this.btnRemoveNames.Size = new System.Drawing.Size(142, 28);
            this.btnRemoveNames.TabIndex = 2;
            this.btnRemoveNames.Text = "Remove Names";
            this.btnRemoveNames.UseVisualStyleBackColor = true;
            this.btnRemoveNames.Click += new System.EventHandler(this.btnRemoveNames_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 16;
            this.lstNames.Location = new System.Drawing.Point(172, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(222, 228);
            this.lstNames.TabIndex = 3;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 211);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(142, 28);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnRemoveNames);
            this.Controls.Add(this.btnEditNames);
            this.Controls.Add(this.btnAddName);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnEditNames;
        private System.Windows.Forms.Button btnRemoveNames;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnQuit;
    }
}

