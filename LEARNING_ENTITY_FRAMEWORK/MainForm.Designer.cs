namespace LEARNING_ENTITY_FRAMEWORK
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.loadAddressesIncludedPersonButton = new System.Windows.Forms.Button();
			this.loadPeopleIncludedAddressButton = new System.Windows.Forms.Button();
			this.addNewPeopleButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loadAddressesIncludedPersonButton
			// 
			this.loadAddressesIncludedPersonButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loadAddressesIncludedPersonButton.Location = new System.Drawing.Point(12, 70);
			this.loadAddressesIncludedPersonButton.Name = "loadAddressesIncludedPersonButton";
			this.loadAddressesIncludedPersonButton.Size = new System.Drawing.Size(283, 23);
			this.loadAddressesIncludedPersonButton.TabIndex = 5;
			this.loadAddressesIncludedPersonButton.Text = "Load Addresses Included Person";
			this.loadAddressesIncludedPersonButton.UseVisualStyleBackColor = true;
			this.loadAddressesIncludedPersonButton.Click += new System.EventHandler(this.LoadAddressesIncludedPersonButton_Click);
			// 
			// loadPeopleIncludedAddressButton
			// 
			this.loadPeopleIncludedAddressButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loadPeopleIncludedAddressButton.Location = new System.Drawing.Point(12, 41);
			this.loadPeopleIncludedAddressButton.Name = "loadPeopleIncludedAddressButton";
			this.loadPeopleIncludedAddressButton.Size = new System.Drawing.Size(283, 23);
			this.loadPeopleIncludedAddressButton.TabIndex = 4;
			this.loadPeopleIncludedAddressButton.Text = "Load People Included Address";
			this.loadPeopleIncludedAddressButton.UseVisualStyleBackColor = true;
			this.loadPeopleIncludedAddressButton.Click += new System.EventHandler(this.LoadPeopleIncludedAddressButton_Click);
			// 
			// addNewPeopleButton
			// 
			this.addNewPeopleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addNewPeopleButton.Location = new System.Drawing.Point(12, 12);
			this.addNewPeopleButton.Name = "addNewPeopleButton";
			this.addNewPeopleButton.Size = new System.Drawing.Size(283, 23);
			this.addNewPeopleButton.TabIndex = 3;
			this.addNewPeopleButton.Text = "Add New People";
			this.addNewPeopleButton.UseVisualStyleBackColor = true;
			this.addNewPeopleButton.Click += new System.EventHandler(this.AddNewPeopleButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 101);
			this.Controls.Add(this.loadAddressesIncludedPersonButton);
			this.Controls.Add(this.loadPeopleIncludedAddressButton);
			this.Controls.Add(this.addNewPeopleButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button loadAddressesIncludedPersonButton;
		private System.Windows.Forms.Button loadPeopleIncludedAddressButton;
		private System.Windows.Forms.Button addNewPeopleButton;
	}
}
