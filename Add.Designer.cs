
namespace e2bapp
{
	partial class Add
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
			this.ungetImageCheck = new System.Windows.Forms.CheckBox();
			this.autoRegistCheck = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.ndlEngine = new System.Windows.Forms.RadioButton();
			this.amazonEngine = new System.Windows.Forms.RadioButton();
			this.volumeGetType = new System.Windows.Forms.GroupBox();
			this.volume_db = new System.Windows.Forms.RadioButton();
			this.volume_title = new System.Windows.Forms.RadioButton();
			this.lastSearchISBNLink = new System.Windows.Forms.LinkLabel();
			this.deleteRegistButton = new System.Windows.Forms.Button();
			this.editRegistButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.volumeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coverImg)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.volumeGetType.SuspendLayout();
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
			this.volumeText.Size = new System.Drawing.Size(138, 22);
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
			this.dateText.Size = new System.Drawing.Size(138, 32);
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
			this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.addButton.Location = new System.Drawing.Point(54, 421);
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
			this.cancelButton.Location = new System.Drawing.Point(279, 421);
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
			this.isbn10AnsLabel.Size = new System.Drawing.Size(217, 21);
			this.isbn10AnsLabel.TabIndex = 18;
			this.isbn10AnsLabel.Text = "ISBN-13を入力してください";
			this.isbn10AnsLabel.Click += new System.EventHandler(this.isbn10AnsLabel_Click);
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
			// ungetImageCheck
			// 
			this.ungetImageCheck.AutoSize = true;
			this.ungetImageCheck.Location = new System.Drawing.Point(679, 450);
			this.ungetImageCheck.Name = "ungetImageCheck";
			this.ungetImageCheck.Size = new System.Drawing.Size(110, 16);
			this.ungetImageCheck.TabIndex = 20;
			this.ungetImageCheck.Text = "画像を取得しない";
			this.ungetImageCheck.UseVisualStyleBackColor = true;
			// 
			// autoRegistCheck
			// 
			this.autoRegistCheck.AutoSize = true;
			this.autoRegistCheck.Location = new System.Drawing.Point(679, 473);
			this.autoRegistCheck.Name = "autoRegistCheck";
			this.autoRegistCheck.Size = new System.Drawing.Size(72, 16);
			this.autoRegistCheck.TabIndex = 21;
			this.autoRegistCheck.Text = "自動登録";
			this.autoRegistCheck.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.ndlEngine);
			this.groupBox1.Controls.Add(this.amazonEngine);
			this.groupBox1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupBox1.Location = new System.Drawing.Point(325, 266);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(154, 101);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "検索エンジン";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.linkLabel1.Location = new System.Drawing.Point(89, 70);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(51, 14);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "利用規約";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// ndlEngine
			// 
			this.ndlEngine.AutoSize = true;
			this.ndlEngine.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ndlEngine.Location = new System.Drawing.Point(6, 63);
			this.ndlEngine.Name = "ndlEngine";
			this.ndlEngine.Size = new System.Drawing.Size(87, 25);
			this.ndlEngine.TabIndex = 1;
			this.ndlEngine.Text = "openBD";
			this.ndlEngine.UseVisualStyleBackColor = true;
			this.ndlEngine.CheckedChanged += new System.EventHandler(this.ndlEngine_CheckedChanged);
			// 
			// amazonEngine
			// 
			this.amazonEngine.AutoSize = true;
			this.amazonEngine.Checked = true;
			this.amazonEngine.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.amazonEngine.Location = new System.Drawing.Point(6, 32);
			this.amazonEngine.Name = "amazonEngine";
			this.amazonEngine.Size = new System.Drawing.Size(86, 25);
			this.amazonEngine.TabIndex = 0;
			this.amazonEngine.TabStop = true;
			this.amazonEngine.Text = "Amazon";
			this.amazonEngine.UseVisualStyleBackColor = true;
			// 
			// volumeGetType
			// 
			this.volumeGetType.Controls.Add(this.volume_db);
			this.volumeGetType.Controls.Add(this.volume_title);
			this.volumeGetType.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.volumeGetType.Location = new System.Drawing.Point(485, 267);
			this.volumeGetType.Name = "volumeGetType";
			this.volumeGetType.Size = new System.Drawing.Size(132, 100);
			this.volumeGetType.TabIndex = 23;
			this.volumeGetType.TabStop = false;
			this.volumeGetType.Text = "巻数取得方法";
			this.volumeGetType.Visible = false;
			// 
			// volume_db
			// 
			this.volume_db.AutoSize = true;
			this.volume_db.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.volume_db.Location = new System.Drawing.Point(6, 63);
			this.volume_db.Name = "volume_db";
			this.volume_db.Size = new System.Drawing.Size(116, 25);
			this.volume_db.TabIndex = 1;
			this.volume_db.Text = "DB [非推奨]";
			this.volume_db.UseVisualStyleBackColor = true;
			// 
			// volume_title
			// 
			this.volume_title.AutoSize = true;
			this.volume_title.Checked = true;
			this.volume_title.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.volume_title.Location = new System.Drawing.Point(6, 32);
			this.volume_title.Name = "volume_title";
			this.volume_title.Size = new System.Drawing.Size(92, 25);
			this.volume_title.TabIndex = 0;
			this.volume_title.TabStop = true;
			this.volume_title.Text = "タイトル";
			this.volume_title.UseVisualStyleBackColor = true;
			// 
			// lastSearchISBNLink
			// 
			this.lastSearchISBNLink.AutoSize = true;
			this.lastSearchISBNLink.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lastSearchISBNLink.Location = new System.Drawing.Point(235, 121);
			this.lastSearchISBNLink.Name = "lastSearchISBNLink";
			this.lastSearchISBNLink.Size = new System.Drawing.Size(15, 17);
			this.lastSearchISBNLink.TabIndex = 24;
			this.lastSearchISBNLink.TabStop = true;
			this.lastSearchISBNLink.Text = "_";
			this.lastSearchISBNLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lastSearchISBNLink_LinkClicked);
			// 
			// deleteRegistButton
			// 
			this.deleteRegistButton.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.deleteRegistButton.ForeColor = System.Drawing.Color.Red;
			this.deleteRegistButton.Location = new System.Drawing.Point(580, 421);
			this.deleteRegistButton.Name = "deleteRegistButton";
			this.deleteRegistButton.Size = new System.Drawing.Size(67, 56);
			this.deleteRegistButton.TabIndex = 25;
			this.deleteRegistButton.Text = "登録削除";
			this.deleteRegistButton.UseVisualStyleBackColor = true;
			this.deleteRegistButton.Click += new System.EventHandler(this.deleteRegistButton_Click);
			// 
			// editRegistButton
			// 
			this.editRegistButton.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.editRegistButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.editRegistButton.Location = new System.Drawing.Point(507, 421);
			this.editRegistButton.Name = "editRegistButton";
			this.editRegistButton.Size = new System.Drawing.Size(67, 56);
			this.editRegistButton.TabIndex = 26;
			this.editRegistButton.Text = "編集";
			this.editRegistButton.UseVisualStyleBackColor = true;
			this.editRegistButton.Click += new System.EventHandler(this.editRegistButton_Click);
			// 
			// Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 522);
			this.Controls.Add(this.editRegistButton);
			this.Controls.Add(this.deleteRegistButton);
			this.Controls.Add(this.lastSearchISBNLink);
			this.Controls.Add(this.volumeGetType);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.autoRegistCheck);
			this.Controls.Add(this.ungetImageCheck);
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
			this.Name = "Add";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Item";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.volumeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coverImg)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.volumeGetType.ResumeLayout(false);
			this.volumeGetType.PerformLayout();
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
		private System.Windows.Forms.CheckBox ungetImageCheck;
		private System.Windows.Forms.CheckBox autoRegistCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton ndlEngine;
		private System.Windows.Forms.RadioButton amazonEngine;
		private System.Windows.Forms.GroupBox volumeGetType;
		private System.Windows.Forms.RadioButton volume_db;
		private System.Windows.Forms.RadioButton volume_title;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel lastSearchISBNLink;
		private System.Windows.Forms.Button deleteRegistButton;
		private System.Windows.Forms.Button editRegistButton;
	}
}