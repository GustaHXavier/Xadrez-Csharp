﻿using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("ORIGEM: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] possicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, possicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("DESTINO: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);

                }

            } catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}