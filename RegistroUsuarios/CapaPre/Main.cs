﻿using CapaNegocio;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPre
{

    public partial class Main : Form
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        byte i = 0;
        string numControl = "";

        public Main()
        {
            InitializeComponent();
            lbFecha.Text = DateTime.Now.ToLongDateString();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            lbInfo.Text = "";
        }

        private void RegistrarMovimiento(object sender, EventArgs e)
        {
            try
            {
                if (comboServicio.SelectedIndex != -1 && txtNumControl.Text != "" && (txtNumControl.Text.Length >= 8 || txtNumControl.Text.Length <= 9))
                {
<<<<<<< HEAD
                    negocio.Registry(txtNumControl.Text.Trim(), Convert.ToByte(txtServicio.Text.Trim()));
                    audio = new SoundPlayer(Environment.CurrentDirectory + @"\Ingresa.wav");
                    audio.Play();
                    TiempoParaPasar.Enabled = true;
                    txtNumControl.Focus();
                }
                else
                {
                    lbInfo.Text = "El usuario no existe\nNo será registrado.";
                    audio = new SoundPlayer(Environment.CurrentDirectory + @"\ElUsuarioNoExiste.wav");
                    audio.Play();
                }
                txtNumControl.Text = "";
                txtServicio.Text = "";
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void LlenarNombreCarreraDepa(object sender, EventArgs e)
        {
            try
            {
                lbNombre.Text = (string.IsNullOrEmpty(txtNumControl.Text)) ? "Ingresa un número de control" : negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["nombres"].ToString() + " " + negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["apellidopat"].ToString() + " " + negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["apellidomat"].ToString();
                lbCarreraDepa.Text = (string.IsNullOrEmpty(txtNumControl.Text)) ? "Ingresa un número de control" : negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["area"].ToString();
            }
            catch
            {
                lbNombre.Text = "¡ESTE USUARIO NO EXISTE!";
                lbCarreraDepa.Text = "Contacte con el administrador";
            }
        }

        private void ValidarServicio(object sender, EventArgs e)
        {
            if (txtServicio.Text != string.Empty)
            {
                switch (txtServicio.Text[0]) { case '8': case '9': case '0': txtServicio.Text = txtServicio.Text.Replace(txtServicio.Text[0], '\0'); break; }
                txtServicio.Text = (char.IsNumber(txtServicio.Text[0])) ? txtServicio.Text : txtServicio.Text.Replace(txtServicio.Text[0], '\0');
            }
=======
                    negocio.Registry(txtNumControl.Text.Trim(), Convert.ToByte((comboServicio.SelectedIndex + 1)));
                    lbInfo.Text = "Por favor, ingresa en menos de: ";
                    //Activar temporizador en el lbInfo
                }
                else
                    lbInfo.Text = "Selecciona un servicio, por favor.";
            }catch(Exception ex) { Console.WriteLine(ex.ToString()); }
>>>>>>> configuraciones
        }

        private void ValidarNumControl(object sender, EventArgs e)
        {
            txtNumControl.Text.ToLower();
            switch (txtNumControl.Text[0]) { case 'c': case 'b': txtNumControl.MaxLength = 9; i = 1; break; default: txtNumControl.MaxLength = 8; i = 0; break; }
            for (; i < txtNumControl.Text.Length; i++)
                txtNumControl.Text = (char.IsNumber(txtNumControl.Text[i])) ? txtNumControl.Text : txtNumControl.Text.Replace(txtNumControl.Text[i], '\0');
            Regex.Replace(txtNumControl.Text, "[d-z|\\s|\\W|añ]+", "");
            txtNumControl.Select(txtNumControl.Text.Length, 0);
            //14 54 00 74
            //01 23 45 67
            /*txtNumControl.Text = (txtNumControl.Text[2] != '5') ? txtNumControl.Text.Substring(2, 1) : txtNumControl.Text;
            txtNumControl.Text = (txtNumControl.Text[3] != '4') ? txtNumControl.Text.Substring(3, 1) : txtNumControl.Text;*/
        }

        private void CancelarF4(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing: e.Cancel = true; break;
                case CloseReason.ApplicationExitCall: e.Cancel = false; break;
            }
        }

        private void CerrarPrograma(object sender, EventArgs e)
        {
            LogOut logout = new LogOut();
            logout.Show();
        }

        private void HoraActual(object sender, EventArgs e) { lbHora.Text = DateTime.Now.ToLongTimeString(); }

        private void comboServicio_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
