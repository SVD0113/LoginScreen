namespace LoginScreen
{
    partial class Form1
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
            this.lblAppName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lbErrorMsg = new System.Windows.Forms.Label();
            this.btnAllDelete1 = new System.Windows.Forms.Button();
            this.btnAllDelete2 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAppName.ForeColor = System.Drawing.Color.Red;
            this.lblAppName.Location = new System.Drawing.Point(163, 75);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(194, 64);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Login";
            this.lblAppName.Click += new System.EventHandler(this.lblAppName_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(31, 193);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(480, 37);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "아이디";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Cyan;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(195, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPW
            // 
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPW.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPW.ForeColor = System.Drawing.Color.Silver;
            this.txtPW.Location = new System.Drawing.Point(31, 258);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(480, 37);
            this.txtPW.TabIndex = 3;
            this.txtPW.Text = "패스워드";
            this.txtPW.Enter += new System.EventHandler(this.txtPW_Enter);
            this.txtPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPW_KeyDown);
            this.txtPW.Leave += new System.EventHandler(this.txtPW_Leave);
            // 
            // lbErrorMsg
            // 
            this.lbErrorMsg.AutoSize = true;
            this.lbErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMsg.Location = new System.Drawing.Point(29, 308);
            this.lbErrorMsg.Name = "lbErrorMsg";
            this.lbErrorMsg.Size = new System.Drawing.Size(229, 12);
            this.lbErrorMsg.TabIndex = 7;
            this.lbErrorMsg.Text = "아이디 또는 패스워드가 잘못 되었습니다.";
            this.lbErrorMsg.Visible = false;
            // 
            // btnAllDelete1
            // 
            this.btnAllDelete1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllDelete1.Location = new System.Drawing.Point(472, 193);
            this.btnAllDelete1.Name = "btnAllDelete1";
            this.btnAllDelete1.Size = new System.Drawing.Size(39, 37);
            this.btnAllDelete1.TabIndex = 4;
            this.btnAllDelete1.Text = "X";
            this.btnAllDelete1.UseVisualStyleBackColor = true;
            this.btnAllDelete1.Click += new System.EventHandler(this.btnAllDelete1_Click);
            // 
            // btnAllDelete2
            // 
            this.btnAllDelete2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllDelete2.Location = new System.Drawing.Point(472, 258);
            this.btnAllDelete2.Name = "btnAllDelete2";
            this.btnAllDelete2.Size = new System.Drawing.Size(39, 37);
            this.btnAllDelete2.TabIndex = 5;
            this.btnAllDelete2.Text = "X";
            this.btnAllDelete2.UseVisualStyleBackColor = true;
            this.btnAllDelete2.Click += new System.EventHandler(this.btnAllDelete2_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShow.Location = new System.Drawing.Point(427, 258);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(39, 37);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "😎";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAllDelete2);
            this.Controls.Add(this.btnAllDelete1);
            this.Controls.Add(this.lbErrorMsg);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAppName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lbErrorMsg;
        private System.Windows.Forms.Button btnAllDelete1;
        private System.Windows.Forms.Button btnAllDelete2;
        private System.Windows.Forms.Button btnShow;
    }
}

