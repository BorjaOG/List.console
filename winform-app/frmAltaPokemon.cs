using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Service;
using System.Configuration;

namespace winform_app
{
    public partial class frmAltaPokemon : Form 
    {


        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
    
        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio service = new PokemonNegocio();

            try
            {
                if(pokemon == null)
                   pokemon = new Pokemon();

                pokemon.Numero = int.Parse(tbNumero.Text);
                pokemon.Nombre = tbNombre.Text;
                pokemon.Descripcion = tbDescripcion.Text;
                pokemon.UrlImagen = txbUrl.Text;
                pokemon.Tipo = (elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (elemento)cboDebilidad.SelectedItem;

                if (pokemon.Id != 0)
                {
                    service.modificar(pokemon);
                    MessageBox.Show("El pokemon ha sido modificado");

                }
                else
                {
                    
                    service.agregar(pokemon);
                    MessageBox.Show("El pokemon ha sido agregado");
                }
                    
                if(archivo != null && (txbUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images folder"] + archivo.SafeFileName);

                Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            element elementoservice = new element();
            try
            {
                cboTipo.DataSource = elementoservice.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoservice.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null) 
                {
                    tbNumero.Text = pokemon.Numero.ToString();
                    tbDescripcion.Text = pokemon.Descripcion;
                    tbNombre.Text = pokemon.Nombre;
                    txbUrl.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrl.Text);
        }
        private void cargarImagen(string imagen)
        {

            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBox1.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarimagen_Click(object sender, EventArgs e)
        {
             archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {              
             txbUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images folder"] + archivo.SafeFileName);

            }
        }
    }
}
