﻿namespace CapaPre
{
    partial class OthersPasswords
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableOthersPasswords = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.TableChangePassword = new System.Windows.Forms.TableLayoutPanel();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.TableEditAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.panelEditAdmin = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboAdministrador = new System.Windows.Forms.ComboBox();
            this.lbAdministrador = new System.Windows.Forms.Label();
            this.tableOthersPasswords.SuspendLayout();
            this.TableChangePassword.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.TableEditAdmin.SuspendLayout();
            this.panelEditAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableOthersPasswords
            // 
            this.tableOthersPasswords.ColumnCount = 1;
            this.tableOthersPasswords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOthersPasswords.Controls.Add(this.lbTitulo, 0, 0);
            this.tableOthersPasswords.Controls.Add(this.TableChangePassword, 0, 2);
            this.tableOthersPasswords.Controls.Add(this.TableEditAdmin, 0, 1);
            this.tableOthersPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOthersPasswords.Location = new System.Drawing.Point(0, 0);
            this.tableOthersPasswords.Name = "tableOthersPasswords";
            this.tableOthersPasswords.RowCount = 3;
            this.tableOthersPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.72387F));
            this.tableOthersPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.15976F));
            this.tableOthersPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.31361F));
            this.tableOthersPasswords.Size = new System.Drawing.Size(1140, 507);
            this.tableOthersPasswords.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1134, 99);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Aquí podrás cambiar las contraseñas de otros administradores\r\nRecuerda ser cuidad" +
    "oso y no abusar de los cambios de contraseña";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableChangePassword
            // 
            this.TableChangePassword.ColumnCount = 3;
            this.TableChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableChangePassword.Controls.Add(this.panelChangePassword, 1, 0);
            this.TableChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableChangePassword.Location = new System.Drawing.Point(3, 188);
            this.TableChangePassword.Name = "TableChangePassword";
            this.TableChangePassword.RowCount = 1;
            this.TableChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableChangePassword.Size = new System.Drawing.Size(1134, 316);
            this.TableChangePassword.TabIndex = 1;
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.btnCancelar);
            this.panelChangePassword.Controls.Add(this.btnAceptar);
            this.panelChangePassword.Controls.Add(this.panelConfirmPassword);
            this.panelChangePassword.Controls.Add(this.panelNewPassword);
            this.panelChangePassword.Controls.Add(this.txtConfirmPassword);
            this.panelChangePassword.Controls.Add(this.txtNewPassword);
            this.panelChangePassword.Controls.Add(this.lbConfirmPassword);
            this.panelChangePassword.Controls.Add(this.lbNewPassword);
            this.panelChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChangePassword.Location = new System.Drawing.Point(286, 3);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(561, 310);
            this.panelChangePassword.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImage = global::CapaPre.Properties.Resources.delete;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(498, 209);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackgroundImage = global::CapaPre.Properties.Resources.aceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(427, 209);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(40, 40);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.EventoClick);
            // 
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelConfirmPassword.Location = new System.Drawing.Point(248, 175);
            this.panelConfirmPassword.Margin = new System.Windows.Forms.Padding(1);
            this.panelConfirmPassword.MaximumSize = new System.Drawing.Size(290, 3);
            this.panelConfirmPassword.MinimumSize = new System.Drawing.Size(290, 3);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(290, 3);
            this.panelConfirmPassword.TabIndex = 7;
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelNewPassword.Location = new System.Drawing.Point(248, 86);
            this.panelNewPassword.Margin = new System.Windows.Forms.Padding(1);
            this.panelNewPassword.MaximumSize = new System.Drawing.Size(290, 3);
            this.panelNewPassword.MinimumSize = new System.Drawing.Size(290, 3);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(290, 3);
            this.panelNewPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(248, 153);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtConfirmPassword.MaximumSize = new System.Drawing.Size(290, 20);
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(290, 20);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(290, 20);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtNewPassword.Location = new System.Drawing.Point(248, 62);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtNewPassword.MaximumSize = new System.Drawing.Size(290, 20);
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(290, 20);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(290, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(23, 153);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(221, 25);
            this.lbConfirmPassword.TabIndex = 3;
            this.lbConfirmPassword.Text = "Confirmar contraseña:";
            this.lbConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(56, 62);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(186, 25);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "Nueva contraseña:";
            this.lbNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableEditAdmin
            // 
            this.TableEditAdmin.ColumnCount = 3;
            this.TableEditAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableEditAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableEditAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableEditAdmin.Controls.Add(this.panelEditAdmin, 1, 0);
            this.TableEditAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableEditAdmin.Location = new System.Drawing.Point(3, 102);
            this.TableEditAdmin.Name = "TableEditAdmin";
            this.TableEditAdmin.RowCount = 1;
            this.TableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableEditAdmin.Size = new System.Drawing.Size(1134, 80);
            this.TableEditAdmin.TabIndex = 2;
            // 
            // panelEditAdmin
            // 
            this.panelEditAdmin.Controls.Add(this.btnBuscar);
            this.panelEditAdmin.Controls.Add(this.comboAdministrador);
            this.panelEditAdmin.Controls.Add(this.lbAdministrador);
            this.panelEditAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditAdmin.Location = new System.Drawing.Point(173, 3);
            this.panelEditAdmin.MaximumSize = new System.Drawing.Size(787, 74);
            this.panelEditAdmin.MinimumSize = new System.Drawing.Size(787, 74);
            this.panelEditAdmin.Name = "panelEditAdmin";
            this.panelEditAdmin.Size = new System.Drawing.Size(787, 74);
            this.panelEditAdmin.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackgroundImage = global::CapaPre.Properties.Resources.seach;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(730, 17);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnBuscar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.EventoClick);
            // 
            // comboAdministrador
            // 
            this.comboAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAdministrador.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.comboAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.comboAdministrador.FormattingEnabled = true;
            this.comboAdministrador.Location = new System.Drawing.Point(167, 21);
            this.comboAdministrador.Name = "comboAdministrador";
            this.comboAdministrador.Size = new System.Drawing.Size(545, 33);
            this.comboAdministrador.TabIndex = 2;
            this.comboAdministrador.Click += new System.EventHandler(this.ElegirAdministrador);
            // 
            // lbAdministrador
            // 
            this.lbAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAdministrador.AutoSize = true;
            this.lbAdministrador.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdministrador.Location = new System.Drawing.Point(17, 25);
            this.lbAdministrador.Name = "lbAdministrador";
            this.lbAdministrador.Size = new System.Drawing.Size(150, 25);
            this.lbAdministrador.TabIndex = 1;
            this.lbAdministrador.Text = "Administrador:";
            this.lbAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OthersPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.tableOthersPasswords);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OthersPasswords";
            this.Size = new System.Drawing.Size(1140, 507);
            this.tableOthersPasswords.ResumeLayout(false);
            this.tableOthersPasswords.PerformLayout();
            this.TableChangePassword.ResumeLayout(false);
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.TableEditAdmin.ResumeLayout(false);
            this.panelEditAdmin.ResumeLayout(false);
            this.panelEditAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableOthersPasswords;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TableLayoutPanel TableChangePassword;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Panel panelEditAdmin;
        private System.Windows.Forms.ComboBox comboAdministrador;
        private System.Windows.Forms.Label lbAdministrador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TableLayoutPanel TableEditAdmin;
    }
}