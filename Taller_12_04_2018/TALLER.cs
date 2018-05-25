using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_12_04_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Collections.Generic.List<TipoDocumento>
                tiposDocumento = new List<TipoDocumento>();

            tiposDocumento.Add(new TipoDocumento()
            {
                Id = 1,
                Nombre = "Cédula de ciudadanía"
            });

            tiposDocumento.Add(new TipoDocumento()
            {
                Id = 2,
                Nombre = "NUIP"
            });

            tiposDocumento.Add(new TipoDocumento()
            {
                Id = 3,
                Nombre = "Tarjeta de extranjería"
            });

            tiposDocumento.Add(new TipoDocumento()
            {
                Id = 4,
                Nombre = "Tarjeta de Identidad"
            });

             
            

            cbTipodeDocumento.DataSource = tiposDocumento;
            cbTipodeDocumento.DisplayMember = "Nombre";

             
            
                System.Collections.Generic.List<TipoRango>
                    tiposRango = new List<TipoRango>();

                tiposRango.Add(new TipoRango()
                {
                    Id = 1,
                    Nombre = "A"
                });

                tiposRango.Add(new TipoRango()
                {
                    Id = 2,
                    Nombre = "B"
                });

                tiposRango.Add(new TipoRango()
                {
                    Id = 3,
                    Nombre = "C"
                });

            cbRango.DataSource = tiposRango;
            cbRango.DisplayMember = "Nombre";

        }
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombredelPaciente.Text))
            {
                erpMensaje.SetError(txtNombredelPaciente, "El nombre es obligatorio");

                return;
            }

            else
            {
                erpMensaje.SetError(txtNombredelPaciente, "");
            }

            if (string.IsNullOrEmpty(cbTipodeDocumento.Text))
            {
                MessageBox.Show("El tipo de documento no puede quedar vacío");

                return;
            }

            if (string.IsNullOrEmpty(txtNumerodeDocumento.Text))
            {
                MessageBox.Show("El número de documento no puede quedar vacío");

                return;
            }

            if (string.IsNullOrEmpty(cbRango.Text))
            {
                MessageBox.Show("El rango no puede quedar vacío");

                return;
            }

            if (string.IsNullOrEmpty(txtCostoServicio.Text))
            {
                MessageBox.Show("El costo el servicio es obligatorio");

                return;
            }

            // costo del servicio mayor a 0
            if (Convert.ToInt64(txtCostoServicio.Text) <= 0)
            {
                erpMensaje.SetError(txtCostoServicio, "El numero que ingrese debe ser mayor a 0");
                return;
            }

            if (string.IsNullOrEmpty(rbtnFemenino.Text ))
            {
                MessageBox.Show("El sexo es obligatorio");

                return;

            }


            if (string.IsNullOrEmpty(rbtnMasculino.Text))
            {
                MessageBox.Show("El sexo es obligatorio");

                return;

            }

            // El nuip debe estar entre 100000000 y 9999999999

            if (((TipoDocumento)cbTipodeDocumento.SelectedItem).Id == 2)
            {
                if (Convert.ToInt64(txtNumerodeDocumento.Text) <= 1000000000)
                {
                    MessageBox.Show("Debe ingresar un numero mayor a 1.000.000.000");
                }
                if (Convert.ToInt64(txtNumerodeDocumento.Text) >= 9999999999)
                {
                    MessageBox.Show("Debe ingresar un numero mayor a 9.999.999.999");
                }
                return;
            }


        }

       
        //Calculamos el pago

        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            double CostodelServicio = 0;

            if (((TipoRango)cbRango.SelectedItem).Id ==1)
            {
                CostodelServicio = (Convert.ToInt64(txtCostoServicio.Text) - (Convert.ToInt64(txtCostoServicio.Text) * 0.30));
                     
            }

            if (((TipoRango)cbRango.SelectedItem).Id == 2)
            {
                CostodelServicio = (Convert.ToInt64(txtCostoServicio.Text) - (Convert.ToInt64(txtCostoServicio.Text) * 0.20));

            }

            if (((TipoRango)cbRango.SelectedItem).Id == 3)
            {
                CostodelServicio = (Convert.ToInt64(txtCostoServicio.Text) - (Convert.ToInt64(txtCostoServicio.Text) * 0.10));

            }

            MessageBox.Show("El valor a pagar es:" + CostodelServicio);
        }

        private void txtNumerodeDocumento_TextChanged(object sender, EventArgs e)
        {
           

           

           

        }

        private void cbTipodeDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }



    } }

