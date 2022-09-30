using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Service;



namespace winform_app
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPokemon()
        {
            InitializeComponent();
        }
      

        private void frmPokemon_Load(object sender, EventArgs e)
        {

            cargar();
            cbcampo.Items.Add("Numero");
            cbcampo.Items.Add("Nombre");
            cbcampo.Items.Add("Descripcion");


        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {

                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }


        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemons.DataSource = listaPokemon;
                ocultar();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultar()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            
            try
            {
                pcbpokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pcbpokemon.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            cargar();

        }

        private void btnmodificar_Click(object sender, EventArgs e)

        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btneliminarfisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btneliminarlogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico= false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Sure do you want to delete this Pokemon?", "Deleting..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarlogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);
                    cargar();

                    MessageBox.Show("El pokemon ha sido eliminado");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if(cbcampo.SelectedIndex < 0)
            {
                MessageBox.Show("Select the column Please");
                return true;
            }
            if(cbcriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Select the criterial Please");
                return true;
            }

            if (cbcampo.SelectedItem.ToString() == "Numero") 
            { 
                if (string.IsNullOrEmpty(txbfiltro.Text))
                {
                    MessageBox.Show("Insert a number Please");
                    return true;
                }
            
                if (!(soloNumeros(txbfiltro.Text))) 
                {
                    MessageBox.Show("Insert numbers only please");
                    return true;
                }
                
            }
                

            return false;
        }

        private bool soloNumeros(string cadena)
        {

            foreach (char caracter in cadena)
            {
                if(!(char.IsNumber(caracter)))
                        return false;

            }
            return true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
             {

            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cbcampo.SelectedItem.ToString();
                string criterio = cbcriterio.SelectedItem.ToString();
                string filtro = txbfiltro.Text;
                dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

                }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listafiltrada;

            string filtro = txtfiltro.Text;

            if (filtro != "")
            {
                listafiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = listaPokemon;
            }

            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = listafiltrada;
            ocultar();
        }

        private void cbcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cbcampo.SelectedItem.ToString();
            if(option == "Numero")
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Mayor a");
                cbcriterio.Items.Add("Menor a");
                cbcriterio.Items.Add("Igual a");
            }
            else
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Comienza con");
                cbcriterio.Items.Add("Termina con");
                cbcriterio.Items.Add("Contiene");
            }
        }
    }
    
}
          
    

