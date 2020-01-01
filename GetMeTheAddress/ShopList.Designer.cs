namespace GetMeTheAddress
{
    partial class ShopList
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
            this.mCbShopList = new System.Windows.Forms.ComboBox();
            this.mBtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mCbShopList
            // 
            this.mCbShopList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCbShopList.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mCbShopList.FormattingEnabled = true;
            this.mCbShopList.ItemHeight = 20;
            this.mCbShopList.Location = new System.Drawing.Point(60, 89);
            this.mCbShopList.Name = "mCbShopList";
            this.mCbShopList.Size = new System.Drawing.Size(671, 28);
            this.mCbShopList.TabIndex = 0;
            // 
            // mBtnOK
            // 
            this.mBtnOK.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mBtnOK.Location = new System.Drawing.Point(317, 228);
            this.mBtnOK.Name = "mBtnOK";
            this.mBtnOK.Size = new System.Drawing.Size(156, 91);
            this.mBtnOK.TabIndex = 1;
            this.mBtnOK.Text = "확인";
            this.mBtnOK.UseVisualStyleBackColor = true;
            this.mBtnOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onButtonClickListener);
            // 
            // ShopList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mBtnOK);
            this.Controls.Add(this.mCbShopList);
            this.Name = "ShopList";
            this.Text = "검색결과";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mCbShopList;
        private System.Windows.Forms.Button mBtnOK;
    }
}