using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {   
            float nota1 ,nota2 ,nota3, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3)/3;

            if(media>5){
                Console.WriteLine("O aluno está aprovado com a média de "+media);
            }else{
                Console.WriteLine("O aluno está REPROVADO com a média de "+media);
            }

            
        }
    }
}
