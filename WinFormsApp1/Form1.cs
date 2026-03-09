namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double alt, peso, imc;
            alt = (double)numAltura.Value;
            peso = (double)numPeso.Value;


            imc = peso / Math.Pow(alt, 2);

            lblresultado.Text = $"IMC: {imc:F2} kg/m²";
            lblClassif.Text = Classificar(imc);
        }


        string Classificar(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do Peso";
            if (imc < 25)
                return "Peso Ideal";
            if (imc < 30)
                return "Obesidade I";
            if (imc < 35)
                return "Obesidade II";
            if (imc < 40)
                return "Obesidade III";
            return "Obesidade mórbida";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bem vindo a calculadora de imc");
        }

        private void numAltura_ValueChanged(object sender, EventArgs e)
        {
            decimal a = numAltura.Value;
            /* if (a != 0)
                 Calcular.Enabled = true;
             else
                 Calcular.Enabled = false;
            */
            Calcular.Enabled = (a != 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("deseja mesmo fechar?", "calculadora de imc", MessageBoxButtons.YesNo);
                if (r == DialogResult.No)
                    e.Cancel = true;  
        }
    }
}
