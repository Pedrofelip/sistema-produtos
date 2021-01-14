using System;

namespace sistema_de_produtos_26._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta1;
            int resposta2;
            string resposta3;
            float resposta4;
            string resposta5;
            string[] nome = new string[10];
            float[] preco = new float[10];
            int i = 0;
            float[] desconto = new float[10];
           

            Console.Clear();
            Console.WriteLine("Iniciar programa? digite s ou n");
            resposta1 = Console.ReadLine();
            
            if (resposta1 == "s")
            {
                do
                {
                    Console.WriteLine("---painel inicial---");
                    Console.WriteLine("[1] - cadastrar produtos");
                    Console.WriteLine("[2] - exibir produtos cadastrados");
                    Console.WriteLine("[0] - sair");
                    resposta2 = int.Parse(Console.ReadLine());
                    
                    switch (resposta2)
                    {
                        case 1:
                            do
                            {
                                if (i<10)
                                {
                                    Console.WriteLine($"Digite o nome para cadastro do {i+1}° produto:");
                                    nome[i] = Console.ReadLine();
                                    Console.WriteLine($"Digite o preço do {i+1}° produto:");
                                    preco[i] = float.Parse(Console.ReadLine());
                                    Console.WriteLine($"Existe algum valor de desconto no {i+1}° produto? digite s-sim ou n-não");
                                    resposta3 = Console.ReadLine();
                                        if (resposta3.ToLower() == "s")
                                        {
                                            Console.WriteLine($"qual o valor do desconto? insira o valor em porcentagem mas sem o sinal de % ");
                                            resposta4 = float.Parse(Console.ReadLine());
                                            desconto[i] = Desconto(preco[i],resposta4);
                                            Console.WriteLine($"Valor do produto com desconto: {desconto[i]}$");
                                            preco = desconto;
                                            Console.WriteLine("\n---------------produto cadastrado---------------\n");
                                        }
                                    i++;
                                }else{
                                          break;      
                                    }
                                Console.WriteLine("Gostaria de cadastrar outro produto? digite s-sim ou n-não ");
                                resposta5 = Console.ReadLine();    
                            } while (resposta5.ToLower() == "s");
                            break;
                    
                        case 2:
                                Console.WriteLine("-----Lista de itens cadastrados-----");
                                for (var n = 0; n < 10; n++)
                                {
                                    Console.WriteLine($"-----item de numero {n+1}-----");
                                    Console.WriteLine($"Nome do produto: {nome[n]}");
                                    Console.WriteLine($"Valor do produto: {preco[n]}\n\n");
                                }
                        break;
                        
                        default:
                                Console.WriteLine($"Opção invalida, por favor tente novamente");
                            break;
                    }
                } while (resposta2 != 0);
            }
            float Desconto(float a, float b){

                float d1 = a/100;
                float d2 = d1*b;
                float d3 = a - d2;

                return d3;

            }


        }
    }
}
