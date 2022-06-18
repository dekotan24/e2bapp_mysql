
namespace e2bapp
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.coverImg = new System.Windows.Forms.PictureBox();
			this.nameText = new System.Windows.Forms.TextBox();
			this.isbnText = new System.Windows.Forms.TextBox();
			this.addDateText = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.reloadButton = new System.Windows.Forms.Button();
			this.configButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.radioSaveButton = new System.Windows.Forms.Button();
			this.creditLabel = new System.Windows.Forms.Label();
			this.gitLabel = new System.Windows.Forms.LinkLabel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.connLabel = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.orderCond = new System.Windows.Forms.ComboBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchCond = new System.Windows.Forms.ComboBox();
			this.searchText = new System.Windows.Forms.TextBox();
			this.bookList = new System.Windows.Forms.ListBox();
			this.bookNameLabel = new System.Windows.Forms.Label();
			this.isbnLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.statLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.volumeText = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.coverImg)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.volumeText)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.coverImg);
			this.groupBox1.Location = new System.Drawing.Point(504, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 241);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "カバー画像";
			// 
			// coverImg
			// 
			this.coverImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.coverImg.Image = global::e2bapp.Properties.Resources.book;
			this.coverImg.Location = new System.Drawing.Point(6, 18);
			this.coverImg.Name = "coverImg";
			this.coverImg.Size = new System.Drawing.Size(272, 217);
			this.coverImg.TabIndex = 0;
			this.coverImg.TabStop = false;
			this.coverImg.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// nameText
			// 
			this.nameText.Location = new System.Drawing.Point(569, 259);
			this.nameText.Name = "nameText";
			this.nameText.ReadOnly = true;
			this.nameText.Size = new System.Drawing.Size(193, 19);
			this.nameText.TabIndex = 12;
			// 
			// isbnText
			// 
			this.isbnText.Location = new System.Drawing.Point(569, 314);
			this.isbnText.Name = "isbnText";
			this.isbnText.ReadOnly = true;
			this.isbnText.Size = new System.Drawing.Size(193, 19);
			this.isbnText.TabIndex = 16;
			// 
			// addDateText
			// 
			this.addDateText.Location = new System.Drawing.Point(569, 344);
			this.addDateText.Name = "addDateText";
			this.addDateText.ReadOnly = true;
			this.addDateText.Size = new System.Drawing.Size(219, 19);
			this.addDateText.TabIndex = 18;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(3, 3);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(60, 29);
			this.addButton.TabIndex = 26;
			this.addButton.Text = "追加";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// reloadButton
			// 
			this.reloadButton.Location = new System.Drawing.Point(69, 3);
			this.reloadButton.Name = "reloadButton";
			this.reloadButton.Size = new System.Drawing.Size(65, 29);
			this.reloadButton.TabIndex = 28;
			this.reloadButton.Text = "再読込";
			this.reloadButton.UseVisualStyleBackColor = true;
			this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
			// 
			// configButton
			// 
			this.configButton.Location = new System.Drawing.Point(206, 3);
			this.configButton.Name = "configButton";
			this.configButton.Size = new System.Drawing.Size(60, 29);
			this.configButton.TabIndex = 32;
			this.configButton.Text = "設定";
			this.configButton.UseVisualStyleBackColor = true;
			this.configButton.Click += new System.EventHandler(this.configButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.addButton);
			this.flowLayoutPanel1.Controls.Add(this.reloadButton);
			this.flowLayoutPanel1.Controls.Add(this.radioSaveButton);
			this.flowLayoutPanel1.Controls.Add(this.configButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(510, 394);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 35);
			this.flowLayoutPanel1.TabIndex = 11;
			// 
			// radioSaveButton
			// 
			this.radioSaveButton.Location = new System.Drawing.Point(140, 3);
			this.radioSaveButton.Name = "radioSaveButton";
			this.radioSaveButton.Size = new System.Drawing.Size(60, 29);
			this.radioSaveButton.TabIndex = 30;
			this.radioSaveButton.Text = "保存";
			this.radioSaveButton.UseVisualStyleBackColor = true;
			this.radioSaveButton.Click += new System.EventHandler(this.radioSaveButton_Click);
			// 
			// creditLabel
			// 
			this.creditLabel.AutoSize = true;
			this.creditLabel.Location = new System.Drawing.Point(607, 434);
			this.creditLabel.Name = "creditLabel";
			this.creditLabel.Size = new System.Drawing.Size(41, 12);
			this.creditLabel.TabIndex = 12;
			this.creditLabel.Text = "e2bapp";
			// 
			// gitLabel
			// 
			this.gitLabel.AutoSize = true;
			this.gitLabel.Location = new System.Drawing.Point(757, 434);
			this.gitLabel.Name = "gitLabel";
			this.gitLabel.Size = new System.Drawing.Size(40, 12);
			this.gitLabel.TabIndex = 13;
			this.gitLabel.TabStop = true;
			this.gitLabel.Text = "GitHub";
			this.gitLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitLabel_LinkClicked);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(592, 370);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 16);
			this.radioButton1.TabIndex = 20;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "未読";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(663, 370);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 16);
			this.radioButton2.TabIndex = 22;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "読中";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(729, 370);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(47, 16);
			this.radioButton3.TabIndex = 24;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "読了";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// connLabel
			// 
			this.connLabel.AutoSize = true;
			this.connLabel.ForeColor = System.Drawing.Color.Gray;
			this.connLabel.Location = new System.Drawing.Point(734, 434);
			this.connLabel.Name = "connLabel";
			this.connLabel.Size = new System.Drawing.Size(17, 12);
			this.connLabel.TabIndex = 17;
			this.connLabel.Text = "●";
			this.toolTip1.SetToolTip(this.connLabel, "現在の接続状況です。\r\n灰：未接続\r\n黄：接続試行中\r\n赤：接続エラー\r\n青：接続完了");
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::e2bapp.Properties.Resources.copy;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(768, 313);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(20, 20);
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::e2bapp.Properties.Resources.copy;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(768, 258);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// orderCond
			// 
			this.orderCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.orderCond.FormattingEnabled = true;
			this.orderCond.Items.AddRange(new object[] {
            "名前 昇順",
            "追加日時 昇順",
            "名前 降順",
            "追加日時 降順"});
			this.orderCond.Location = new System.Drawing.Point(315, 9);
			this.orderCond.Name = "orderCond";
			this.orderCond.Size = new System.Drawing.Size(106, 20);
			this.orderCond.TabIndex = 6;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(427, 7);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(71, 23);
			this.searchButton.TabIndex = 8;
			this.searchButton.Text = "検索";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchCond
			// 
			this.searchCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.searchCond.FormattingEnabled = true;
			this.searchCond.Items.AddRange(new object[] {
            "タイトル",
            "ISBN-13",
            "巻数"});
			this.searchCond.Location = new System.Drawing.Point(229, 9);
			this.searchCond.Name = "searchCond";
			this.searchCond.Size = new System.Drawing.Size(80, 20);
			this.searchCond.TabIndex = 4;
			// 
			// searchText
			// 
			this.searchText.Location = new System.Drawing.Point(3, 9);
			this.searchText.Name = "searchText";
			this.searchText.Size = new System.Drawing.Size(220, 19);
			this.searchText.TabIndex = 2;
			this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchText_KeyPress);
			// 
			// bookList
			// 
			this.bookList.FormattingEnabled = true;
			this.bookList.ItemHeight = 12;
			this.bookList.Location = new System.Drawing.Point(3, 36);
			this.bookList.Name = "bookList";
			this.bookList.Size = new System.Drawing.Size(495, 400);
			this.bookList.TabIndex = 10;
			this.bookList.SelectedIndexChanged += new System.EventHandler(this.bookList_SelectedIndexChanged);
			// 
			// bookNameLabel
			// 
			this.bookNameLabel.AutoSize = true;
			this.bookNameLabel.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.bookNameLabel.Location = new System.Drawing.Point(507, 260);
			this.bookNameLabel.Name = "bookNameLabel";
			this.bookNameLabel.Size = new System.Drawing.Size(44, 16);
			this.bookNameLabel.TabIndex = 23;
			this.bookNameLabel.Text = "書籍名";
			// 
			// isbnLabel
			// 
			this.isbnLabel.AutoSize = true;
			this.isbnLabel.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.isbnLabel.Location = new System.Drawing.Point(507, 315);
			this.isbnLabel.Name = "isbnLabel";
			this.isbnLabel.Size = new System.Drawing.Size(51, 16);
			this.isbnLabel.TabIndex = 24;
			this.isbnLabel.Text = "ISBN13";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(507, 345);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "追加日時";
			// 
			// statLabel
			// 
			this.statLabel.AutoSize = true;
			this.statLabel.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.statLabel.Location = new System.Drawing.Point(507, 370);
			this.statLabel.Name = "statLabel";
			this.statLabel.Size = new System.Drawing.Size(68, 16);
			this.statLabel.TabIndex = 26;
			this.statLabel.Text = "ステータス";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(507, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "巻数";
			// 
			// volumeText
			// 
			this.volumeText.Location = new System.Drawing.Point(569, 287);
			this.volumeText.Name = "volumeText";
			this.volumeText.ReadOnly = true;
			this.volumeText.Size = new System.Drawing.Size(193, 19);
			this.volumeText.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 447);
			this.Controls.Add(this.volumeText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.statLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.isbnLabel);
			this.Controls.Add(this.bookNameLabel);
			this.Controls.Add(this.orderCond);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchCond);
			this.Controls.Add(this.searchText);
			this.Controls.Add(this.bookList);
			this.Controls.Add(this.connLabel);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.gitLabel);
			this.Controls.Add(this.creditLabel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.addDateText);
			this.Controls.Add(this.isbnText);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "e2bapp - Easy Book Manage Tool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.coverImg)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.volumeText)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox coverImg;
		private System.Windows.Forms.TextBox nameText;
		private System.Windows.Forms.TextBox isbnText;
		private System.Windows.Forms.TextBox addDateText;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button reloadButton;
		private System.Windows.Forms.Button configButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label creditLabel;
		private System.Windows.Forms.LinkLabel gitLabel;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label connLabel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox orderCond;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox searchCond;
		private System.Windows.Forms.TextBox searchText;
		private System.Windows.Forms.ListBox bookList;
		private System.Windows.Forms.Button radioSaveButton;
		private System.Windows.Forms.Label bookNameLabel;
		private System.Windows.Forms.Label isbnLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label statLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown volumeText;
	}
}

