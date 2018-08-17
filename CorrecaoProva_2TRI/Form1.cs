using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrecaoProva_2TRI
{
    public partial class Form1 : Form
    {
        /*
            Valores das Jogadas:
            0 = Nenhuma jogada;
            1 = Pedra;
            2 = Papel;
            3 = Tesoura;             
        */

        Jogadas jogadaSelecionada = Jogadas.NENHUMA;
        enum Jogadas
        {
            NENHUMA,
            Pedra,
            Papel,
            Tesoura
        }

        int rodada = 1,
            empates = 0,
            derrotas = 0,
            vitorias = 0;

        string[] jogadas = new string[3]
        {
            "Pedra",  //0
            "Papel",  //1
            "Tesoura" //2
        };


        public Form1()
        {
            InitializeComponent();
        }

        private bool ChecarJogadaValida()
        {
            return jogadaSelecionada != Jogadas.NENHUMA;
        }

        private void AvancarRodada()
        {
            DesselecionarJogada();
            rodada++;
            AtualizarLabelsJogo();
        }

        private void DesselecionarJogada()
        {
            jogadaSelecionada = 0;
            AtualizarJogadaSelecionada();
        }

        private void AtualizarJogadaSelecionada()
        {
            if (ChecarJogadaValida())
            {
                lblJogadaSelecionada.Text = string.Format(
                "Jogada Selecionada: {0}",
                jogadaSelecionada.ToString()
                //subtrai um para coincidir com os valores da Array jogadas
            ); 
            }
            else
            {
                lblJogadaSelecionada.Text = "Nenhuma jogada selecionada";
            }
        }

        private void AtualizarLabelsJogo()
        {
            lblRodada.Text = "Rodada: " + rodada;
            lblVitorias.Text = "Vitórias: " + vitorias;
            lblEmpates.Text = "Empates: " + empates;
            lblDerrotas.Text = "Derrotas: " + derrotas;
        }

        private void ExibirJogada(string nomeJogador, Jogadas jogada)
        {
            rtbResultado.AppendText(
                string.Format(
                    "{0}: {1} \n",
                    nomeJogador,
                    jogada.ToString().ToLower().First().ToString().ToUpper() + jogada.ToString().Substring(1)
                )
            );
        }

        private void Jogar()
        {
            Random rnd = new Random();
            Jogadas jogadaComputador = (Jogadas)rnd.Next(1, jogadas.Length + 1);

            ExibirJogada("Jogador", jogadaSelecionada);
            ExibirJogada("Computador", jogadaComputador);

            if (jogadaSelecionada == Jogadas.Pedra)//Pedra
            {
                if (jogadaComputador == Jogadas.Pedra) //Pedra
                {
                    // Empate
                    Empate();
                }
                else if (jogadaComputador == Jogadas.Papel) //Papel
                {
                    // Derrota
                    Derrota();
                }
                else if (jogadaComputador == Jogadas.Tesoura) //Tesoura
                {
                    // Vitória
                    Vitoria();
                }
            }
            else if (jogadaSelecionada == Jogadas.Papel)//Papel
            {
                if (jogadaComputador == Jogadas.Pedra) //Pedra
                {
                    // Vitória
                    Vitoria();
                }
                else if (jogadaComputador == Jogadas.Papel) //Papel
                {
                    // Empate
                    Empate();
                }
                else if (jogadaComputador == Jogadas.Tesoura) //Tesoura
                {
                    // Derrota
                    Derrota();
                }
            }
            else if (jogadaSelecionada == Jogadas.Tesoura)//Tesoura
            {
                if (jogadaComputador == Jogadas.Pedra) //Pedra
                {
                    // Derrota
                    Derrota();
                }
                else if (jogadaComputador == Jogadas.Papel) //Papel
                {
                    // Vitória
                    Vitoria();
                }
                else if (jogadaComputador == Jogadas.Tesoura) //Tesoura
                {
                    // Empate
                    Empate();
                }
            }

            AvancarRodada();
        }

        private void Empate()
        {
            empates++;

            rtbResultado.AppendText("Empatou :P \n");
        }
        private void Derrota()
        {
            derrotas++;

            rtbResultado.AppendText("Você Perdeu :/ \n");
        }
        private void Vitoria()
        {
            vitorias++;

            rtbResultado.AppendText("Você Ganhou!!! \n");
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = Jogadas.Pedra;

            AtualizarJogadaSelecionada();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = Jogadas.Papel;

            AtualizarJogadaSelecionada();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = Jogadas.Tesoura;

            AtualizarJogadaSelecionada();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (ChecarJogadaValida())
            {
                Jogar();
            }
        }

        private void btnDesselecionar_Click(object sender, EventArgs e)
        {
            DesselecionarJogada();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            rodada = 1;
            vitorias = 0;
            empates = 0;
            derrotas = 0;
            AtualizarJogadaSelecionada();
            DesselecionarJogada();
        }
    }
}
