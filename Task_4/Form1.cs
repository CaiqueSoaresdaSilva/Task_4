namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] lista = { -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 };
            string[] listaConvertida = new string[lista.Length];
            string result = "";

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] > 0)
                {
                    listaConvertida[i] = "Positivo";
                }
                else
                {
                    listaConvertida[i] = "Negativo";
                }
            }
             
            for (int i = 0;i < listaConvertida.Length;i++) { 
                if(i == 0)
                {
                    result += "[";
                }
                else
                {
                    result += ", ";
                }

                result =  result + listaConvertida[i];

                if(i == listaConvertida.Length - 1)
                {
                    result += "]";
                }
            }

            lblResult.Text = result;

        }
    }
}
