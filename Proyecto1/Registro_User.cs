﻿using System;
using System.Windows.Forms;

namespace Proyecto1
{
    internal class Registro_User : Form
    {
        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Registro_User
            // 
            this.ClientSize = new System.Drawing.Size(945, 506);
            this.Name = "Registro_User";
            this.Load += new System.EventHandler(this.Registro_User_Load);
            this.ResumeLayout(false);

        }

        private void Registro_User_Load(object sender, EventArgs e)
        {

        }
    }
}