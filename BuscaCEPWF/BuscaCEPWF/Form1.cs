using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEPWF
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BuscarCEP(maskCep.Text);
        }

        async Task BuscarCEP(string cep)
        {
            try
            {
                var cepbuscar = RestService.For<ICepApiService>("https://vaicep.com.br");
                var endereco = await cepbuscar.GetAddressAsync(cep);

                txtLogodouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtComplemento2.Text = endereco.Complemento;
                txtMunicipio.Text = endereco.Localidade;
                txtEstado.Text = endereco.Uf;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha! \n " + e.Message);
            }
        }
    }
}  
