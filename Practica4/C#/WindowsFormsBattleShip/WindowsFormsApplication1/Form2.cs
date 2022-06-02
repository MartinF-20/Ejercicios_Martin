using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApplication1.Properties;
namespace WindowsFormsApplication1
{

    public partial class Form2 : Form
    {
        public static int RODADA = 1;
        public static int barcosP = 4;
        public static int barcosE = 4;
        int rodadas = 10;
        Random aleatorio = new Random();
        public static int puntuacionP = 0;
        public static int puntuacionE = 0;
        List<Button> botoesjogador;
        List<Button> botoesinimigos;


        //criando numero aleatório
        public Form2()
        {
            InitializeComponent();
                barcosP = 4;
            RODADA = 1;
            puntuacionE = 0;
            puntuacionP = 0;
            this.DoubleBuffered = true;
            botões();
            alo.Text = null;
            inimigoCasas.Enabled = false;
            inimigoCasas.Text = null;
            textoAuxiliar.Text = "Elija la ubicación de su barco haciendo clic en los botones";
            alo.Text = "Rodadas: " + rodadas;
            PONTUACAOE.Text = "Puntuacion del enemigo: "+ puntuacionE;
            PONTUACAOP.Text = "Tu puntuacion: " + puntuacionP;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tempoJogadaInimigo_Tick(object sender, EventArgs e)
        {

        }

        private void Btn_a2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void AtaqueBot(object sender, EventArgs e)
        {
            if (rodadas == 0)
            {
                if (puntuacionE > puntuacionP)
                {
                    MessageBox.Show("Partida perdida");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else if (puntuacionP > puntuacionE)
                {
                    MessageBox.Show("Partida ganada");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Empate");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);

                }
            }
            for (int i = 0; i < 1; i++)
            {
                if (RODADA == 0)
                {
                    int resultado = aleatorio.Next(botoesinimigos.Count);
                    if (botoesinimigos[resultado].Tag == "NAVIO")
                    {
                        botoesinimigos[resultado].Tag = "";
                        botoesinimigos[resultado].BackgroundImage = Properties.Resources.bombardeiroEncontrado;
                        puntuacionE++;
                        PONTUACAOE.Text = "Puntuacion enemiga: " + puntuacionE;
                        inimigoCasas.Enabled = true;
                        rodadas--;
                        alo.Text = "Rodadas: " + rodadas;
                    }
                    else { 

                    botoesinimigos[resultado].BackgroundImage = Properties.Resources.ONDA;
                    inimigoCasas.Enabled = true;
                        rodadas--;
                        alo.Text = "Rodadas: " + rodadas;
                    }
                }
            }
            RODADA = 1;
        }
        private void inimigoCasas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (inimigoCasas.Text != "")
            {
                if (rodadas == 0)
                {
                    if (puntuacionE > puntuacionP)
                    {
                        MessageBox.Show("Partida perdida");
                        inimigoCasas.Enabled = false;
                        Environment.Exit(1);
                    }
                    else if (puntuacionP > puntuacionE)
                    {
                        MessageBox.Show("Partida ganada");
                        inimigoCasas.Enabled = false;
                        Environment.Exit(1);
                    }
                    else
                    {
                        MessageBox.Show("Empate");
                        inimigoCasas.Enabled = false;
                        Environment.Exit(1);

                    }
                }
                var escolha = inimigoCasas.Text;
                escolha = escolha.ToLower();
                int coordenada = botoesjogador.FindIndex(a => a.Name == escolha);
                if (botoesjogador[coordenada].Enabled)
                {

                    if (botoesjogador[coordenada].Tag == "NAVIOE")
                    {
                        puntuacionP++;
                        PONTUACAOP.Text = "Tu puntuacion: " + puntuacionP;
                        botoesjogador[coordenada].Enabled = false;
                        botoesjogador[coordenada].BackgroundImage = Properties.Resources.bombardeiroEncontrado;
                        inimigoCasas.Enabled = false; RODADA = 0;
                        RODADA = 0;
                        AtaqueBot(sender,e);
                    }
                    else
                    {
                        botoesjogador[coordenada].Enabled = false;
                        botoesjogador[coordenada].BackgroundImage = Properties.Resources.ONDA;
                        inimigoCasas.Enabled = false; RODADA = 0;
                        AtaqueBot(sender, e);
                    }
                }
            }
            else
            {
                textoAuxiliar.Text = "Elija una casa existente";
            }
        }

        private void jogadorTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void posiçãodeataqueinimigo(object sender, EventArgs e)
        {

        }
        private void botões()
        {
            botoesjogador = new List<Button> { a1, a2, a3, a4, this.b1, this.b2, this.b3, this.b4, c1, c3, c2, c4, d1, d2, d3, d4 };
            botoesinimigos = new List<Button> { BtnBot_a1, BtnBot_a2, BtnBot_a3, BtnBot_a4, BtnBot_b1, BtnBot_b2, BtnBot_b3, BtnBot_b4, BtnBot_c1, BtnBot_c2, BtnBot_c3, BtnBot_c4, BtnBot_d1, BtnBot_d2, BtnBot_d3, BtnBot_d4 };
            for (int i = 0; i < botoesjogador.Count; i++)
            {
                botoesjogador[i].Tag = i;

            }
            for (int i = 0; i < botoesinimigos.Count; i++)
            {
                botoesinimigos[i].Tag = null;
                inimigoCasas.Items.Add(botoesinimigos[i].Text);
            }
            //  PARTE MAIS ARCAICA DO PROGAMA 
            Random aleatorio = new Random();
            int b1 = 0; int b2 = 0; int b3 = 0; int b4 = 0; int l1 = 0; int l2 = 0; int l3 = 0; int l4 = 0;
            for (int i = 0; i < 4; i++)
            {


                int linha = aleatorio.Next(1, 5);
                int coluna = aleatorio.Next(1, 5);

                switch (i)
                {
                    case 0:
                        l1 = linha;
                        b1 = coluna;

                        break;
                    case 1:
                        l2 = linha;
                        b2 = coluna;

                        break;
                    case 2:

                        l3 = linha;
                        b3 = coluna;
                        break;
                    case 3:

                        l4 = linha;
                        b4 = coluna;
                        break;

                }


                if (i == 3)
                {
                    if (l1 == l2 && b2 == b1)
                    {
                        i = -1;
                    }
                    if (l1 == l3 && b1 == b3)
                    {
                        i = -1;
                    }
                    if (l1 == l4 && b1 == b4)
                    {
                        i = -1;
                    }
                    if (l3 == l2 && b2 == b3)
                    {
                        i = -1;
                    }
                    if (l4 == l3 && b4 == b3)
                    {
                        i = -1;
                    }
                    if (l4 == l2 && b2 == b4)
                    {
                        i = -1;
                    }
                }

            }
            string[] a = new string[4] { "a", "b", "c", "d" };
            string l11 = "";
            string l22 = "";
            string l33 = "";
            string l44 = "";

            int pa = 1;
            for (int i = 0; i < 4; i++)
            {

                if (l1 == pa)
                {
                    l11 = a[i];
                }
                if (l2 == pa)
                {
                    l22 = a[i];
                }
                if (l3 == pa)
                {
                    l33 = a[i];
                }
                if (l4 == pa)
                {
                    l44 = a[i];
                }
                pa++;
            }
            l11 += (b1);
            l22 += (b2);
            l33 += (b3);
            l44 += (b4);            
            int coordenada1 = botoesjogador.FindIndex(b => b.Name == l11);            
            int coordenada2 = botoesjogador.FindIndex(b => b.Name == l22);
            int coordenada3 = botoesjogador.FindIndex(b => b.Name == l33);
            int coordenada4 = botoesjogador.FindIndex(b => b.Name == l44);
            botoesjogador[coordenada1].Tag = "NAVIOE";
            botoesjogador[coordenada2].Tag = "NAVIOE";
            botoesjogador[coordenada3].Tag = "NAVIOE";
            botoesjogador[coordenada4].Tag = "NAVIOE";
        }

   


        private void posiçãoDeButoesInimigo(object sender, EventArgs e)

        {
            if (barcosP > 0)
            {
                
                var butao = (Button)sender;
                butao.Enabled = false;
                indicadorNavioslb.Text = "Navios Restantes: " + (barcosP -1);
                butao.Tag = "NAVIO";
                butao.BackgroundImage = Properties.Resources.bombardeiro;
                barcosP--;

            }
            if (barcosP == 0)
            {
               
                textoAuxiliar.Top = 100;
                textoAuxiliar.Left = 70;
                textoAuxiliar.Text = "Ahora elige la posición de bombardeo enemiga";
                if (RODADA == 1)
                {
                    inimigoCasas.Enabled = true;
                    RODADA = 0;
                }
               
            }
            if (rodadas == 0)
            {
                if (puntuacionE > puntuacionP)
                {
                    MessageBox.Show("Partida perdida");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else if (puntuacionP > puntuacionE)
                {
                    MessageBox.Show("Partida ganada");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Empate");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);

                }
            }
        }

        private void Butao_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void PONTUACAOE_Click(object sender, EventArgs e)
        {

        }
    }
}
