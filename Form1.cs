using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) 
            { 
                txtID.Text = "아이디"; 
                txtID.ForeColor = Color.Silver; 
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        string myID = "admin";  
        string myPW = "superman";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text.Trim();
            string inputPW = txtPW.Text.Trim();

            if (inputID == myID && inputPW == myPW) { 
                MessageBox.Show("로그인성공!"); 
            } 
            else {
                lbErrorMsg.Visible = true;
                // MessageBox.Show("로그인실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                txtPW.Focus(); // 패스워드입력창이포커스를갖게끔}
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                btnLogin.PerformClick(); // 버튼이눌린것처럼만들기}
            }
        }

        private void btnAllDelete1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnAllDelete2_Click(object sender, EventArgs e)
        {
            txtPW.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = !txtPW.UseSystemPasswordChar;
        }
    }
}
