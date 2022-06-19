
namespace e2bapp
{
	partial class Form3
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
			this.isbnLabel = new System.Windows.Forms.Label();
			this.isbnText = new System.Windows.Forms.TextBox();
			this.ISBN = new System.Windows.Forms.Label();
			this.getButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameText = new System.Windows.Forms.TextBox();
			this.volumeLabel = new System.Windows.Forms.Label();
			this.volumeText = new System.Windows.Forms.NumericUpDown();
			this.dateLabel = new System.Windows.Forms.Label();
			this.dateText = new System.Windows.Forms.DateTimePicker();
			this.statusLabel = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.isbn10Label = new System.Windows.Forms.Label();
			this.isbn10AnsLabel = new System.Windows.Forms.Label();
			this.coverImg = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.volumeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coverImg)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("游明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.titleLabel.Location = new System.Drawing.Point(147, 20);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(374, 31);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "データベースに本を追加します。";
			// 
			// isbnLabel
			// 
			this.isbnLabel.AutoSize = true;
			this.isbnLabel.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.isbnLabel.Location = new System.Drawing.Point(12, 85);
			this.isbnLabel.Name = "isbnLabel";
			this.isbnLabel.Size = new System.Drawing.Size(87, 25);
			this.isbnLabel.TabIndex = 1;
			this.isbnLabel.Text = "ISBN-13";
			// 
			// isbnText
			// 
			this.isbnText.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.isbnText.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.isbnText.Location = new System.Drawing.Point(237, 85);
			this.isbnText.Name = "isbnText";
			this.isbnText.Size = new System.Drawing.Size(272, 33);
			this.isbnText.TabIndex = 2;
			this.isbnText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbnText_KeyPress);
			// 
			// ISBN
			// 
			this.ISBN.AutoSize = true;
			this.ISBN.Font = new System.Drawing.Font("游明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ISBN.Location = new System.Drawing.Point(149, 88);
			this.ISBN.Name = "ISBN";
			this.ISBN.Size = new System.Drawing.Size(82, 21);
			this.ISBN.TabIndex = 3;
			this.ISBN.Text = "ISBN978-";
			// 
			// getButton
			// 
			this.getButton.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.getButton.Location = new System.Drawing.Point(528, 88);
			this.getButton.Name = "getButton";
			this.getButton.Size = new System.Drawing.Size(119, 33);
			this.getButton.TabIndex = 4;
			this.getButton.Text = "データ取得";
			this.getButton.UseVisualStyleBackColor = true;
			this.getButton.Click += new System.EventHandler(this.getButton_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nameLabel.Location = new System.Drawing.Point(13, 211);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(58, 21);
			this.nameLabel.TabIndex = 5;
			this.nameLabel.Text = "書籍名";
			// 
			// nameText
			// 
			this.nameText.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nameText.Location = new System.Drawing.Point(153, 209);
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(494, 32);
			this.nameText.TabIndex = 6;
			// 
			// volumeLabel
			// 
			this.volumeLabel.AutoSize = true;
			this.volumeLabel.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.volumeLabel.Location = new System.Drawing.Point(13, 266);
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.Size = new System.Drawing.Size(42, 21);
			this.volumeLabel.TabIndex = 7;
			this.volumeLabel.Text = "巻数";
			// 
			// volumeText
			// 
			this.volumeText.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.volumeText.Location = new System.Drawing.Point(153, 267);
			this.volumeText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.volumeText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.volumeText.Name = "volumeText";
			this.volumeText.Size = new System.Drawing.Size(120, 22);
			this.volumeText.TabIndex = 8;
			this.volumeText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.dateLabel.Location = new System.Drawing.Point(13, 321);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(74, 21);
			this.dateLabel.TabIndex = 9;
			this.dateLabel.Text = "追加日時";
			// 
			// dateText
			// 
			this.dateText.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.dateText.Location = new System.Drawing.Point(153, 314);
			this.dateText.Name = "dateText";
			this.dateText.Size = new System.Drawing.Size(247, 32);
			this.dateText.TabIndex = 10;
			this.dateText.Value = new System.DateTime(2022, 6, 18, 15, 51, 38, 0);
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.statusLabel.Location = new System.Drawing.Point(13, 374);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(90, 21);
			this.statusLabel.TabIndex = 11;
			this.statusLabel.Text = "ステータス";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.radioButton1.Location = new System.Drawing.Point(153, 372);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(60, 25);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "未読";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.radioButton2.Location = new System.Drawing.Point(264, 372);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(60, 25);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.Text = "読中";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.radioButton3.Location = new System.Drawing.Point(370, 372);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(60, 25);
			this.radioButton3.TabIndex = 14;
			this.radioButton3.Text = "読了";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.addButton.Location = new System.Drawing.Point(114, 421);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(177, 56);
			this.addButton.TabIndex = 15;
			this.addButton.Text = "登録";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cancelButton.Location = new System.Drawing.Point(398, 421);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(177, 56);
			this.cancelButton.TabIndex = 16;
			this.cancelButton.Text = "キャンセル";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// isbn10Label
			// 
			this.isbn10Label.AutoSize = true;
			this.isbn10Label.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.isbn10Label.Location = new System.Drawing.Point(13, 166);
			this.isbn10Label.Name = "isbn10Label";
			this.isbn10Label.Size = new System.Drawing.Size(66, 20);
			this.isbn10Label.TabIndex = 17;
			this.isbn10Label.Text = "ISBN-10";
			// 
			// isbn10AnsLabel
			// 
			this.isbn10AnsLabel.AutoSize = true;
			this.isbn10AnsLabel.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.isbn10AnsLabel.Location = new System.Drawing.Point(151, 165);
			this.isbn10AnsLabel.Name = "isbn10AnsLabel";
			this.isbn10AnsLabel.Size = new System.Drawing.Size(215, 21);
			this.isbn10AnsLabel.TabIndex = 18;
			this.isbn10AnsLabel.Text = "ISBN-13を入力してください";
			// 
			// coverImg
			// 
			this.coverImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.coverImg.Location = new System.Drawing.Point(679, 65);
			this.coverImg.Name = "coverImg";
			this.coverImg.Size = new System.Drawing.Size(275, 379);
			this.coverImg.TabIndex = 19;
			this.coverImg.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 522);
			this.Controls.Add(this.coverImg);
			this.Controls.Add(this.isbn10AnsLabel);
			this.Controls.Add(this.isbn10Label);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.dateText);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.volumeText);
			this.Controls.Add(this.volumeLabel);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.getButton);
			this.Controls.Add(this.ISBN);
			this.Controls.Add(this.isbnText);
			this.Controls.Add(this.isbnLabel);
			this.Controls.Add(this.titleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Item";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.volumeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coverImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label isbnLabel;
		private System.Windows.Forms.TextBox isbnText;
		private System.Windows.Forms.Label ISBN;
		private System.Windows.Forms.Button getButton;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameText;
		private System.Windows.Forms.Label volumeLabel;
		private System.Windows.Forms.NumericUpDown volumeText;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.DateTimePicker dateText;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label isbn10Label;
		private System.Windows.Forms.Label isbn10AnsLabel;
		private System.Windows.Forms.PictureBox coverImg;
	}
}