using System;

namespace Exercicio_C__3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("=======================================================");
            Console.WriteLine("Bem vindo a piscina antes de entrar, Digite a sua idade");
            Console.WriteLine("=======================================================");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=5 && idade <=7) {
                Console.WriteLine(" Você vai para a piscina infantil A");
            }else{
                if(idade >= 8 && idade <=10) {
                    Console.WriteLine("Você vai pra piscina Infantil B");
                }else {
                    if(idade >=8 && idade <=10) {
                        Console.WriteLine("Você vai pra piscina juvenil A");
                    }else {
                        if(idade >=11 && idade <= 13) {
                            Console.WriteLine("Você Vai pra piscina Juvenil A");
                        }else {
                            if(idade >=14 && idade <= 17) {
                                Console.WriteLine("Você vai pra piscina Juvenil B");
                            }else {
                                Console.WriteLine("Você vai nadar com os Seniores");
                            }
                        }
                    }
                }
            }

                
            

            








        }   
    }
}
