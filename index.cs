using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int pera = 5, maca = 5, uva = 5, banana = 5, manga = 5 , batata = 5 , feijao = 5, arroz = 5 , macarrao = 5;
            string op1, escolha;
            int quant;

            while (true)
            {
                Console.WriteLine("BEM VINDO! ESCOLHA SEUS PRODUTOS:");
                Console.WriteLine("Temos: \nPera: " + pera);
                Console.WriteLine("Maça: " + maca);
                Console.WriteLine("Uva: " + uva);
                Console.WriteLine("Banana: " + banana);
                Console.WriteLine("Manga: " + manga);
                Console.WriteLine("Feijão: " + feijao);
                Console.WriteLine("Arroz: " + arroz);
                Console.WriteLine("Batata: " + batata);
                Console.WriteLine("Macarrao: " + macarrao);



                Console.Write("Escolha um produto (Pera, Maça, Uva, Banana, Manga): ");
                op1 = Console.ReadLine();

                Console.Write("Digite a quantidade desejada: ");
                
                if (!int.TryParse(Console.ReadLine(), out quant))
                {
                    Console.WriteLine("Quantidade inválida. Tente novamente.");
                    continue;
                }

                switch (op1.ToLower())
                {
                    case "pera":
                        if (quant <= pera) pera -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "maca":
                        if (quant <= maca) maca -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "uva":
                        if (quant <= uva) uva -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "banana":
                        if (quant <= banana) banana -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "manga":
                        if (quant <= manga) manga -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "feijao":
                        if (quant <= feijao) feijao -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "Arroz":
                        if (quant <= arroz) arroz -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "batata":
                        if (quant <= batata) batata -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    case "macarrao":
                        if (quant <= macarrao) macarrao -= quant;
                        else Console.WriteLine("Quantidade indisponível.");
                        break;
                    default:
                        Console.WriteLine("Produto não encontrado. Tente novamente.");
                        continue;
                }
                        
                Console.Write("Deseja escolher algo mais? (sim/não): ");
                escolha = Console.ReadLine();

                if (escolha.ToLower() != "sim")
                {
                    Console.WriteLine("Obrigado pela compra!");
                    break;
                }
            }
        }
    }
}
