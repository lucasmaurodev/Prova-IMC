namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Metro_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarNmr(object sender, EventArgs e) //evento criado para unir os numeros
        {
            Button ApertarBotão = sender as Button; //"variavel" criada para ultiliazar o sender


            if (txtAltura.Tag.Equals(true)) //verficação para a caixa altura esta ativa
            {

                txtAltura.Text += ApertarBotão.Text;  //inserção de clicks no txtAltura
            }

            else
            {
                txtPeso.Text += ApertarBotão.Text; //inserção de clicks no txtPeso

            }     





        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {

            txtPeso.BackColor = Color.Red; //evento para alterar a cor para vermelho usando enter
            txtPeso.Tag = true;//Tags criadas para usar no evento adicionar numero
            txtAltura.Tag = false;
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red; //evento para alterar a cor para vermelho usando enter
            txtAltura.Tag = true; //Tags criadas para usar no evento adicionar numero
            txtPeso.Tag = false;


        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
          txtPeso.BackColor = Color.White; //evento para voltar a cor padrão (Branco)

        }

        private void txtAltura_Leave(object sender, EventArgs e)
        {

            txtAltura.BackColor = Color.White; //evento para voltar a cor padrão (Branco)

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtAltura.Clear(); //zerando a caixa de texto
            txtPeso.Clear(); //zerando a caixa de texto


            txtAltura.Tag = false; //resetando tag
            txtPeso.Tag = false; //resetando tag

        }

        private void button13_Click(object sender, EventArgs e)
        {

            
                double altura = double.Parse(txtAltura.Text); //criação de variavel
                double peso = double.Parse(txtPeso.Text); //criação de variavel
                double calculo;
                calculo= peso / Math.Pow(altura, 2); //calculo IMC
                txtIMC.Text = calculo.ToString("N2"); //aparecer apenas 2 casas decimais apos a virgula


            if (calculo <= 19)
            {
                lblResult.Text = "Abaixo do Peso";
            }
            else if ((calculo > 19.1) && (calculo < 25.8))
            {
                lblResult.Text = "Peso normal";
            }
            else if ((calculo >= 25.8) && (calculo < 32.3))
            {
                lblResult.Text = "Acima do Peso";
            }
            else 
            {
                lblResult.Text = "OBESO";
            }
        }
    }
}
