﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (user == "admin" && pass == "123")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult res = MessageBox.Show("Sai TTT", " ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Retry)
                {
                    txtUser.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }

            }
        }
    }
}
