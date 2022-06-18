
namespace e2bapp
{
	partial class Form2
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
			this.titleLabel = new System.Windows.Forms.Label();
			this.urlLabel = new System.Windows.Forms.Label();
			this.urlText = new System.Windows.Forms.TextBox();
			this.portLabel = new System.Windows.Forms.Label();
			this.portText = new System.Windows.Forms.NumericUpDown();
			this.userText = new System.Windows.Forms.TextBox();
			this.userLabel = new System.Windows.Forms.Label();
			this.passText = new System.Windows.Forms.TextBox();
			this.passLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.createButton = new System.Windows.Forms.Button();
			this.reloadButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.portText)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("游明朝", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(157, 21);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(214, 41);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "e2bapp config";
			// 
			// urlLabel
			// 
			this.urlLabel.AutoSize = true;
			this.urlLabel.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.urlLabel.Location = new System.Drawing.Point(12, 119);
			this.urlLabel.Name = "urlLabel";
			this.urlLabel.Size = new System.Drawing.Size(97, 17);
			this.urlLabel.TabIndex = 1;
			this.urlLabel.Text = "Database URL";
			// 
			// urlText
			// 
			this.urlText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.urlText.Location = new System.Drawing.Point(136, 119);
			this.urlText.Name = "urlText";
			this.urlText.Size = new System.Drawing.Size(290, 19);
			this.urlText.TabIndex = 2;
			this.urlText.Text = "localhost";
			// 
			// portLabel
			// 
			this.portLabel.AutoSize = true;
			this.portLabel.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.portLabel.Location = new System.Drawing.Point(12, 160);
			this.portLabel.Name = "portLabel";
			this.portLabel.Size = new System.Drawing.Size(96, 17);
			this.portLabel.TabIndex = 3;
			this.portLabel.Text = "Database Port";
			// 
			// portText
			// 
			this.portText.Location = new System.Drawing.Point(136, 160);
			this.portText.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.portText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.portText.Name = "portText";
			this.portText.Size = new System.Drawing.Size(81, 19);
			this.portText.TabIndex = 4;
			this.portText.Value = new decimal(new int[] {
            1433,
            0,
            0,
            0});
			// 
			// userText
			// 
			this.userText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.userText.Location = new System.Drawing.Point(136, 202);
			this.userText.Name = "userText";
			this.userText.Size = new System.Drawing.Size(139, 19);
			this.userText.TabIndex = 6;
			this.userText.Text = "sa";
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.userLabel.Location = new System.Drawing.Point(12, 202);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(99, 17);
			this.userLabel.TabIndex = 5;
			this.userLabel.Text = "Database User";
			// 
			// passText
			// 
			this.passText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.passText.Location = new System.Drawing.Point(136, 247);
			this.passText.Name = "passText";
			this.passText.Size = new System.Drawing.Size(213, 19);
			this.passText.TabIndex = 8;
			this.passText.UseSystemPasswordChar = true;
			// 
			// passLabel
			// 
			this.passLabel.AutoSize = true;
			this.passLabel.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.passLabel.Location = new System.Drawing.Point(12, 247);
			this.passLabel.Name = "passLabel";
			this.passLabel.Size = new System.Drawing.Size(100, 17);
			this.passLabel.TabIndex = 7;
			this.passLabel.Text = "Database Pass";
			// 
			// saveButton
			// 
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.saveButton.Font = new System.Drawing.Font("游明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.saveButton.Location = new System.Drawing.Point(15, 303);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(234, 47);
			this.saveButton.TabIndex = 9;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("游明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cancelButton.Location = new System.Drawing.Point(273, 303);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(234, 47);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(432, 117);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(75, 23);
			this.createButton.TabIndex = 3;
			this.createButton.Text = "DB作成";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// reloadButton
			// 
			this.reloadButton.Font = new System.Drawing.Font("游明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.reloadButton.Location = new System.Drawing.Point(421, 188);
			this.reloadButton.Name = "reloadButton";
			this.reloadButton.Size = new System.Drawing.Size(86, 41);
			this.reloadButton.TabIndex = 11;
			this.reloadButton.Text = "Reload";
			this.reloadButton.UseVisualStyleBackColor = true;
			this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 382);
			this.Controls.Add(this.reloadButton);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.passText);
			this.Controls.Add(this.passLabel);
			this.Controls.Add(this.userText);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.portText);
			this.Controls.Add(this.portLabel);
			this.Controls.Add(this.urlText);
			this.Controls.Add(this.urlLabel);
			this.Controls.Add(this.titleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "config";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.portText)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label urlLabel;
		private System.Windows.Forms.TextBox urlText;
		private System.Windows.Forms.Label portLabel;
		private System.Windows.Forms.NumericUpDown portText;
		private System.Windows.Forms.TextBox userText;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.TextBox passText;
		private System.Windows.Forms.Label passLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button reloadButton;
	}
}