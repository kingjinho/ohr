namespace GetMeTheAddress
{
    partial class OHR100CS
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mLabelReceptionist = new System.Windows.Forms.Label();
            this.mLabelShopName = new System.Windows.Forms.Label();
            this.mTbShopName = new System.Windows.Forms.TextBox();
            this.mLabelShopAddress = new System.Windows.Forms.Label();
            this.mTbShopAddress = new System.Windows.Forms.TextBox();
            this.mLabelPhoneNumber = new System.Windows.Forms.Label();
            this.mTbPhone1 = new System.Windows.Forms.TextBox();
            this.mTbPhone2 = new System.Windows.Forms.TextBox();
            this.mLabelModel = new System.Windows.Forms.Label();
            this.mRb100H = new System.Windows.Forms.RadioButton();
            this.mRb100S = new System.Windows.Forms.RadioButton();
            this.mLabelCause = new System.Windows.Forms.Label();
            this.mTbCause1 = new System.Windows.Forms.TextBox();
            this.mTbCause2 = new System.Windows.Forms.TextBox();
            this.mTbCause3 = new System.Windows.Forms.TextBox();
            this.mTbCause4 = new System.Windows.Forms.TextBox();
            this.mBtnGetAddress = new System.Windows.Forms.Button();
            this.mBtnCopy = new System.Windows.Forms.Button();
            this.mBtnClear = new System.Windows.Forms.Button();
            this.mCbReceptionist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mLabelReceptionist
            // 
            this.mLabelReceptionist.AutoSize = true;
            this.mLabelReceptionist.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLabelReceptionist.Location = new System.Drawing.Point(18, 30);
            this.mLabelReceptionist.Name = "mLabelReceptionist";
            this.mLabelReceptionist.Size = new System.Drawing.Size(93, 27);
            this.mLabelReceptionist.TabIndex = 1;
            this.mLabelReceptionist.Text = "접수자";
            // 
            // mLabelShopName
            // 
            this.mLabelShopName.AutoSize = true;
            this.mLabelShopName.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLabelShopName.Location = new System.Drawing.Point(18, 96);
            this.mLabelShopName.Name = "mLabelShopName";
            this.mLabelShopName.Size = new System.Drawing.Size(93, 27);
            this.mLabelShopName.TabIndex = 7;
            this.mLabelShopName.Text = "매장명";
            // 
            // mTbShopName
            // 
            this.mTbShopName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbShopName.Location = new System.Drawing.Point(147, 95);
            this.mTbShopName.Name = "mTbShopName";
            this.mTbShopName.Size = new System.Drawing.Size(564, 30);
            this.mTbShopName.TabIndex = 8;
            this.mTbShopName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeypressListener);
            // 
            // mLabelShopAddress
            // 
            this.mLabelShopAddress.AutoSize = true;
            this.mLabelShopAddress.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLabelShopAddress.Location = new System.Drawing.Point(18, 165);
            this.mLabelShopAddress.Name = "mLabelShopAddress";
            this.mLabelShopAddress.Size = new System.Drawing.Size(66, 27);
            this.mLabelShopAddress.TabIndex = 9;
            this.mLabelShopAddress.Text = "주소";
            // 
            // mTbShopAddress
            // 
            this.mTbShopAddress.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbShopAddress.Location = new System.Drawing.Point(147, 163);
            this.mTbShopAddress.Name = "mTbShopAddress";
            this.mTbShopAddress.Size = new System.Drawing.Size(564, 30);
            this.mTbShopAddress.TabIndex = 10;
            this.mTbShopAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onAddressClickListener);
            // 
            // mLabelPhoneNumber
            // 
            this.mLabelPhoneNumber.AutoSize = true;
            this.mLabelPhoneNumber.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLabelPhoneNumber.Location = new System.Drawing.Point(18, 227);
            this.mLabelPhoneNumber.Name = "mLabelPhoneNumber";
            this.mLabelPhoneNumber.Size = new System.Drawing.Size(120, 27);
            this.mLabelPhoneNumber.TabIndex = 11;
            this.mLabelPhoneNumber.Text = "전화번호";
            // 
            // mTbPhone1
            // 
            this.mTbPhone1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbPhone1.Location = new System.Drawing.Point(147, 225);
            this.mTbPhone1.Name = "mTbPhone1";
            this.mTbPhone1.Size = new System.Drawing.Size(257, 30);
            this.mTbPhone1.TabIndex = 12;
            // 
            // mTbPhone2
            // 
            this.mTbPhone2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbPhone2.Location = new System.Drawing.Point(465, 225);
            this.mTbPhone2.Name = "mTbPhone2";
            this.mTbPhone2.Size = new System.Drawing.Size(244, 30);
            this.mTbPhone2.TabIndex = 13;
            // 
            // mLabelModel
            // 
            this.mLabelModel.AutoSize = true;
            this.mLabelModel.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLabelModel.Location = new System.Drawing.Point(18, 300);
            this.mLabelModel.Name = "mLabelModel";
            this.mLabelModel.Size = new System.Drawing.Size(93, 27);
            this.mLabelModel.TabIndex = 14;
            this.mLabelModel.Text = "모델명";
            // 
            // mRb100H
            // 
            this.mRb100H.AutoSize = true;
            this.mRb100H.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mRb100H.Location = new System.Drawing.Point(147, 304);
            this.mRb100H.Name = "mRb100H";
            this.mRb100H.Size = new System.Drawing.Size(122, 24);
            this.mRb100H.TabIndex = 15;
            this.mRb100H.TabStop = true;
            this.mRb100H.Text = "OHR-100H";
            this.mRb100H.UseVisualStyleBackColor = true;
            // 
            // mRb100S
            // 
            this.mRb100S.AutoSize = true;
            this.mRb100S.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mRb100S.Location = new System.Drawing.Point(299, 304);
            this.mRb100S.Name = "mRb100S";
            this.mRb100S.Size = new System.Drawing.Size(123, 24);
            this.mRb100S.TabIndex = 16;
            this.mRb100S.TabStop = true;
            this.mRb100S.Text = "OHR-100S";
            this.mRb100S.UseVisualStyleBackColor = true;
            // 
            // mLabelCause
            // 
            this.mLabelCause.AutoSize = true;
            this.mLabelCause.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLabelCause.Location = new System.Drawing.Point(18, 360);
            this.mLabelCause.Name = "mLabelCause";
            this.mLabelCause.Size = new System.Drawing.Size(66, 27);
            this.mLabelCause.TabIndex = 17;
            this.mLabelCause.Text = "증상";
            // 
            // mTbCause1
            // 
            this.mTbCause1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbCause1.Location = new System.Drawing.Point(148, 357);
            this.mTbCause1.Name = "mTbCause1";
            this.mTbCause1.Size = new System.Drawing.Size(564, 30);
            this.mTbCause1.TabIndex = 18;
            // 
            // mTbCause2
            // 
            this.mTbCause2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbCause2.Location = new System.Drawing.Point(148, 414);
            this.mTbCause2.Name = "mTbCause2";
            this.mTbCause2.Size = new System.Drawing.Size(564, 30);
            this.mTbCause2.TabIndex = 19;
            // 
            // mTbCause3
            // 
            this.mTbCause3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbCause3.Location = new System.Drawing.Point(148, 473);
            this.mTbCause3.Name = "mTbCause3";
            this.mTbCause3.Size = new System.Drawing.Size(564, 30);
            this.mTbCause3.TabIndex = 20;
            // 
            // mTbCause4
            // 
            this.mTbCause4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mTbCause4.Location = new System.Drawing.Point(148, 537);
            this.mTbCause4.Name = "mTbCause4";
            this.mTbCause4.Size = new System.Drawing.Size(564, 30);
            this.mTbCause4.TabIndex = 21;
            // 
            // mBtnGetAddress
            // 
            this.mBtnGetAddress.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mBtnGetAddress.Location = new System.Drawing.Point(750, 80);
            this.mBtnGetAddress.Name = "mBtnGetAddress";
            this.mBtnGetAddress.Size = new System.Drawing.Size(147, 65);
            this.mBtnGetAddress.TabIndex = 22;
            this.mBtnGetAddress.Text = "주소 가져오기";
            this.mBtnGetAddress.UseVisualStyleBackColor = true;
            this.mBtnGetAddress.Click += new System.EventHandler(this.onButtonGetAddressClickListener);
            // 
            // mBtnCopy
            // 
            this.mBtnCopy.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mBtnCopy.Location = new System.Drawing.Point(148, 585);
            this.mBtnCopy.Name = "mBtnCopy";
            this.mBtnCopy.Size = new System.Drawing.Size(214, 110);
            this.mBtnCopy.TabIndex = 23;
            this.mBtnCopy.Text = "컨트롤 + C";
            this.mBtnCopy.UseVisualStyleBackColor = true;
            this.mBtnCopy.Click += new System.EventHandler(this.mBtnCopy_Click);
            // 
            // mBtnClear
            // 
            this.mBtnClear.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mBtnClear.Location = new System.Drawing.Point(507, 585);
            this.mBtnClear.Name = "mBtnClear";
            this.mBtnClear.Size = new System.Drawing.Size(202, 110);
            this.mBtnClear.TabIndex = 24;
            this.mBtnClear.Text = "초기화";
            this.mBtnClear.UseVisualStyleBackColor = true;
            this.mBtnClear.Click += new System.EventHandler(this.mBtnClear_Click);
            // 
            // mCbReceptionist
            // 
            this.mCbReceptionist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCbReceptionist.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mCbReceptionist.FormattingEnabled = true;
            this.mCbReceptionist.Items.AddRange(new object[] {
            "구상희",
            "한홍비",
            "송영민",
            "김정엽",
            "신진호"});
            this.mCbReceptionist.Location = new System.Drawing.Point(148, 30);
            this.mCbReceptionist.Name = "mCbReceptionist";
            this.mCbReceptionist.Size = new System.Drawing.Size(241, 28);
            this.mCbReceptionist.TabIndex = 25;
            // 
            // OHR100CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 732);
            this.Controls.Add(this.mCbReceptionist);
            this.Controls.Add(this.mBtnClear);
            this.Controls.Add(this.mBtnCopy);
            this.Controls.Add(this.mBtnGetAddress);
            this.Controls.Add(this.mTbCause4);
            this.Controls.Add(this.mTbCause3);
            this.Controls.Add(this.mTbCause2);
            this.Controls.Add(this.mTbCause1);
            this.Controls.Add(this.mLabelCause);
            this.Controls.Add(this.mRb100S);
            this.Controls.Add(this.mRb100H);
            this.Controls.Add(this.mLabelModel);
            this.Controls.Add(this.mTbPhone2);
            this.Controls.Add(this.mTbPhone1);
            this.Controls.Add(this.mLabelPhoneNumber);
            this.Controls.Add(this.mTbShopAddress);
            this.Controls.Add(this.mLabelShopAddress);
            this.Controls.Add(this.mTbShopName);
            this.Controls.Add(this.mLabelShopName);
            this.Controls.Add(this.mLabelReceptionist);
            this.Controls.Add(this.label1);
            this.Name = "OHR100CS";
            this.Text = "OHR AS접수";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mLabelReceptionist;
        private System.Windows.Forms.Label mLabelShopName;
        private System.Windows.Forms.TextBox mTbShopName;
        private System.Windows.Forms.Label mLabelShopAddress;
        private System.Windows.Forms.TextBox mTbShopAddress;
        private System.Windows.Forms.Label mLabelPhoneNumber;
        private System.Windows.Forms.TextBox mTbPhone1;
        private System.Windows.Forms.TextBox mTbPhone2;
        private System.Windows.Forms.Label mLabelModel;
        private System.Windows.Forms.RadioButton mRb100H;
        private System.Windows.Forms.RadioButton mRb100S;
        private System.Windows.Forms.Label mLabelCause;
        private System.Windows.Forms.TextBox mTbCause1;
        private System.Windows.Forms.TextBox mTbCause2;
        private System.Windows.Forms.TextBox mTbCause3;
        private System.Windows.Forms.TextBox mTbCause4;
        private System.Windows.Forms.Button mBtnGetAddress;
        private System.Windows.Forms.Button mBtnCopy;
        private System.Windows.Forms.Button mBtnClear;
        private System.Windows.Forms.ComboBox mCbReceptionist;
    }
}

