using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Control_Inv : Form
    {
        public Control_Inv()
        {
            InitializeComponent();
        }



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void Control_Inv_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
           
        }
        private void controlBotones()
        {
            //funcion para que el apartado usuario funcione usando numeros 
                if (txtUser.Text.Trim() != string.Empty && txtUser.Text.All(char.IsDigit))
                {
                    btnAceptar.Enabled = true;
                    errorProvider1.SetError(txtUser, "");
                }
                else
                {
                // el errorpricider1 es un apartado que hace que el cliente sepa que no se puede escribir cierto parametros 
                    errorProvider1.SetError(txtUser, "El Usuario debe ser con ID");
                    btnAceptar.Enabled = false;
                    txtUser.Focus();
                }
                // esto es el apartado de Contraseña para la funcion del boton acpetar 
            if (txtContraseña.Text.Trim() != string.Empty && txtContraseña.Text.All(char.IsDigit))
            {
                btnAceptar.Enabled = true;
                errorProvider1.SetError(txtContraseña, "");
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "Agregue las contraseña numerica");
                btnAceptar.Enabled = false;
                txtContraseña.Focus();
            }
        }
        
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            controlBotones(); 
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
