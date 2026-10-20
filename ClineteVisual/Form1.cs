using System;
using System.Windows.Forms;
using ContratosCompartidos;
using ServidorDistribuido;


namespace ClineteVisual
{
    public partial class Form1 : Form
    {
        private readonly IOperacionesRemotas _operaciones;
        public Form1()
        {
            InitializeComponent();
            _operaciones = new OperacionesServidor(); // Reemplazar con la implementación real del proxy
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos valores de los controles visuales
                int num1 = Convert.ToInt32(txtNumero1.Text);
                int num2 = Convert.ToInt32(txtNumero2.Text);

                // Invocación de métodos del componente
                int resultadoSuma = _operaciones.Sumar(num1, num2);
                string mensaje = _operaciones.ObtenerMensajePersonalizado("Jesus");

                // Mostrar resultados en la interfaz
                lblResultado.Text = $"Suma: {resultadoSuma}\nMensaje: {mensaje}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
