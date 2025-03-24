using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lwElementos.Items.Add(elemento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario o if de una sola linea
            string chocolate = cbxChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtTraineer.Checked)
                tipo = "Traineer";
            else if (rbtJunior.Checked)
                tipo = "Junior";
            else
                tipo = "Senior";

            //string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            Persona perfilPersona1 = new Persona();
            perfilPersona1.Nombre = nombre;
            perfilPersona1.Edad = fecha;
            perfilPersona1.Chocolate = chocolate;
            perfilPersona1.Tipo = tipo;
            //perfilPersona1.ColorFavorito = colorFavorito;


            MessageBox.Show("Nombre: " + perfilPersona1.Nombre);
            MessageBox.Show(perfilPersona1.saludar());
            //MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + "Le gusta el chocolate?" + chocolate + "Tipo: " + tipo + "Color Favorito: " + colorFavorito + "Numero favorito: " + numeroFavorito);
        }
    }
}
