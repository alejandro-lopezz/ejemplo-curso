
namespace controles
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rbtSenior = new System.Windows.Forms.RadioButton();
            this.rbtJunior = new System.Windows.Forms.RadioButton();
            this.rbtTraineer = new System.Windows.Forms.RadioButton();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.gpbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(205, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(162, 545);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(205, 422);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(183, 96);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(152, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(88, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(206, 95);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(201, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbxChocolate
            // 
            this.cbxChocolate.AutoSize = true;
            this.cbxChocolate.Location = new System.Drawing.Point(206, 136);
            this.cbxChocolate.Name = "cbxChocolate";
            this.cbxChocolate.Size = new System.Drawing.Size(135, 17);
            this.cbxChocolate.TabIndex = 2;
            this.cbxChocolate.Text = "Te gusta el chocolate?";
            this.cbxChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(213, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // gpbTipo
            // 
            this.gpbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbTipo.Controls.Add(this.rbtSenior);
            this.gpbTipo.Controls.Add(this.rbtJunior);
            this.gpbTipo.Controls.Add(this.rbtTraineer);
            this.gpbTipo.Location = new System.Drawing.Point(139, 159);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(305, 82);
            this.gpbTipo.TabIndex = 3;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo:";
            // 
            // rbtSenior
            // 
            this.rbtSenior.AutoSize = true;
            this.rbtSenior.Location = new System.Drawing.Point(222, 40);
            this.rbtSenior.Name = "rbtSenior";
            this.rbtSenior.Size = new System.Drawing.Size(55, 17);
            this.rbtSenior.TabIndex = 2;
            this.rbtSenior.Text = "Senior";
            this.rbtSenior.UseVisualStyleBackColor = true;
            // 
            // rbtJunior
            // 
            this.rbtJunior.AutoSize = true;
            this.rbtJunior.Location = new System.Drawing.Point(113, 40);
            this.rbtJunior.Name = "rbtJunior";
            this.rbtJunior.Size = new System.Drawing.Size(53, 17);
            this.rbtJunior.TabIndex = 1;
            this.rbtJunior.Text = "Junior";
            this.rbtJunior.UseVisualStyleBackColor = true;
            // 
            // rbtTraineer
            // 
            this.rbtTraineer.AutoSize = true;
            this.rbtTraineer.Checked = true;
            this.rbtTraineer.Location = new System.Drawing.Point(7, 40);
            this.rbtTraineer.Name = "rbtTraineer";
            this.rbtTraineer.Size = new System.Drawing.Size(64, 17);
            this.rbtTraineer.TabIndex = 0;
            this.rbtTraineer.TabStop = true;
            this.rbtTraineer.Text = "Traineer";
            this.rbtTraineer.UseVisualStyleBackColor = true;
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Location = new System.Drawing.Point(121, 259);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(75, 13);
            this.lblColorFavorito.TabIndex = 9;
            this.lblColorFavorito.Text = "Color Favorito:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(205, 259);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(215, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnVerPerfil.FlatAppearance.BorderSize = 4;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerPerfil.Location = new System.Drawing.Point(134, 366);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil:";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(108, 315);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(88, 13);
            this.lblNumeroFavorito.TabIndex = 12;
            this.lblNumeroFavorito.Text = "Número Favorito:";
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFavorito.Location = new System.Drawing.Point(205, 308);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(215, 20);
            this.numNumeroFavorito.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 629);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(993, 668);
            this.MinimumSize = new System.Drawing.Size(586, 668);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbxChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rbtSenior;
        private System.Windows.Forms.RadioButton rbtJunior;
        private System.Windows.Forms.RadioButton rbtTraineer;
        private System.Windows.Forms.Label lblColorFavorito;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
    }
}

