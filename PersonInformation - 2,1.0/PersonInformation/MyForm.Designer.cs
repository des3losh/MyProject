namespace PersonInformation
{
    partial class MyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.btAll = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this._logo = new System.Windows.Forms.Label();
            this.cbContry = new System.Windows.Forms.ComboBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this._personPhoto = new System.Windows.Forms.PictureBox();
            this.btChoosePhoto = new System.Windows.Forms.Button();
            this.btAllPhoto = new System.Windows.Forms.Button();
            this._openPhoto = new System.Windows.Forms.OpenFileDialog();
            this._btTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._personPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(363, 164);
            this.tbID.Margin = new System.Windows.Forms.Padding(0);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(245, 26);
            this.tbID.TabIndex = 0;
            this.ToolTip.SetToolTip(this.tbID, "Put the ID of person here");
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(363, 206);
            this.tbName.Margin = new System.Windows.Forms.Padding(0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 26);
            this.tbName.TabIndex = 2;
            this.ToolTip.SetToolTip(this.tbName, "Put the Name of person here");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(291, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(291, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(290, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contry:";
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAdd.FlatAppearance.BorderSize = 2;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btAdd.Location = new System.Drawing.Point(72, 453);
            this.btAdd.Margin = new System.Windows.Forms.Padding(0, 3, 8, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 35);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFind
            // 
            this.btFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btFind.FlatAppearance.BorderSize = 2;
            this.btFind.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btFind.Location = new System.Drawing.Point(188, 453);
            this.btFind.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(100, 35);
            this.btFind.TabIndex = 7;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btAll
            // 
            this.btAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAll.FlatAppearance.BorderSize = 2;
            this.btAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btAll.Location = new System.Drawing.Point(304, 453);
            this.btAll.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(100, 35);
            this.btAll.TabIndex = 8;
            this.btAll.Text = "All";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btExit.FlatAppearance.BorderSize = 2;
            this.btExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btExit.Location = new System.Drawing.Point(536, 453);
            this.btExit.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // _logo
            // 
            this._logo.AutoSize = true;
            this._logo.Font = new System.Drawing.Font("Amethyst", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this._logo.Location = new System.Drawing.Point(99, 57);
            this._logo.Name = "_logo";
            this._logo.Size = new System.Drawing.Size(510, 48);
            this._logo.TabIndex = 10;
            this._logo.Text = "Person Info";
            // 
            // cbContry
            // 
            this.cbContry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbContry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContry.FormattingEnabled = true;
            this.cbContry.Items.AddRange(new object[] {
            "Iraq",
            "Egypt",
            "UAE",
            "Saudia Arbia",
            "Bahrine",
            ""});
            this.cbContry.Location = new System.Drawing.Point(363, 248);
            this.cbContry.Name = "cbContry";
            this.cbContry.Size = new System.Drawing.Size(245, 26);
            this.cbContry.TabIndex = 11;
            this.ToolTip.SetToolTip(this.cbContry, "Choose a Contry");
            // 
            // ToolTip
            // 
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Note";
            // 
            // ExitPicture
            // 
            this.ExitPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitPicture.BackgroundImage")));
            this.ExitPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPicture.Location = new System.Drawing.Point(660, 12);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(37, 35);
            this.ExitPicture.TabIndex = 12;
            this.ExitPicture.TabStop = false;
            this.ToolTip.SetToolTip(this.ExitPicture, "Click To Exit");
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // _personPhoto
            // 
            this._personPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._personPhoto.Location = new System.Drawing.Point(100, 152);
            this._personPhoto.Name = "_personPhoto";
            this._personPhoto.Size = new System.Drawing.Size(133, 127);
            this._personPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._personPhoto.TabIndex = 13;
            this._personPhoto.TabStop = false;
            // 
            // btChoosePhoto
            // 
            this.btChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChoosePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btChoosePhoto.FlatAppearance.BorderSize = 2;
            this.btChoosePhoto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btChoosePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btChoosePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChoosePhoto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoosePhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btChoosePhoto.Location = new System.Drawing.Point(100, 290);
            this.btChoosePhoto.Margin = new System.Windows.Forms.Padding(8);
            this.btChoosePhoto.Name = "btChoosePhoto";
            this.btChoosePhoto.Size = new System.Drawing.Size(133, 35);
            this.btChoosePhoto.TabIndex = 14;
            this.btChoosePhoto.Text = "Chose Photo";
            this.btChoosePhoto.UseVisualStyleBackColor = true;
            this.btChoosePhoto.Click += new System.EventHandler(this.btChoosePhoto_Click);
            // 
            // btAllPhoto
            // 
            this.btAllPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAllPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAllPhoto.FlatAppearance.BorderSize = 2;
            this.btAllPhoto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAllPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAllPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAllPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAllPhoto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAllPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btAllPhoto.Location = new System.Drawing.Point(420, 453);
            this.btAllPhoto.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btAllPhoto.Name = "btAllPhoto";
            this.btAllPhoto.Size = new System.Drawing.Size(100, 35);
            this.btAllPhoto.TabIndex = 15;
            this.btAllPhoto.Text = "All Photo";
            this.btAllPhoto.UseVisualStyleBackColor = true;
            this.btAllPhoto.Click += new System.EventHandler(this.btAllPhoto_Click);
            // 
            // _openPhoto
            // 
            this._openPhoto.InitialDirectory = "Desktop";
            // 
            // _btTimer
            // 
            this._btTimer.Interval = 10;
            this._btTimer.Tick += new System.EventHandler(this._btTimer_Tick);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.btAllPhoto);
            this.Controls.Add(this.btChoosePhoto);
            this.Controls.Add(this._personPhoto);
            this.Controls.Add(this.ExitPicture);
            this.Controls.Add(this.cbContry);
            this.Controls.Add(this._logo);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAll);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Info";
            this.Load += new System.EventHandler(this.MyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._personPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label _logo;
        private System.Windows.Forms.ComboBox cbContry;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox ExitPicture;
        private System.Windows.Forms.PictureBox _personPhoto;
        private System.Windows.Forms.Button btChoosePhoto;
        private System.Windows.Forms.Button btAllPhoto;
        private System.Windows.Forms.OpenFileDialog _openPhoto;
        private System.Windows.Forms.Timer _btTimer;
    }
}

