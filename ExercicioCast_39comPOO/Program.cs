using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCast_38 {
    class Program {
        static void Main(string[] args) {



            Console.Write("entre com a quantidade de estudantes deseja classificar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {

            NotaPOO aluno = new NotaPOO();


                Console.WriteLine("Entre com o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Entre com as 3 notas.");
                Console.Write("Nota trabalhos:");
                aluno.Nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota semestre: ");
                aluno.Nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota final: ");
                aluno.Nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                aluno.ExibirNotas();
                aluno.Classificacao();
                Console.WriteLine();
                Console.WriteLine();
                Console.ReadKey();
            }
        }

    }
    public class NotaPOO {

        private string nome;

        public string Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }
        



        private double nota1;

        public double Nota1 {
            get { return this.nota1; }
            set { this.nota1 = value; }
        }
        private double nota2;

        public double Nota2 {
            get { return this.nota2; }
            set { this.nota2 = value; }
        }
        private double nota3;

        public double Nota3 {
            get { return nota3; }
            set { nota3 = value; }
        }        
        public void ExibirNotas() {
            Console.Clear();
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("Nota 1: " + this.nota1);
            Console.WriteLine("Nota 2: " + this.nota2);
            Console.WriteLine("Nota 3: " + this.nota3);
            Console.WriteLine("Nota final: "+CalculoNotas());

        }
        public void Classificacao() {

            
            if (CalculoNotas() >= 8 && CalculoNotas() <= 10) {
                char x = 'A';
                Console.WriteLine("Classificação: "+x);
            }
            else if (CalculoNotas() <= 8 && CalculoNotas() >= 7) {
                char x = 'B';
                Console.WriteLine("Classificação: " + x);
            }
            else if (CalculoNotas() <= 7 && CalculoNotas() >= 6) {
                char x = 'C';
                Console.WriteLine("Classificação: " + x);
            }
            else if (CalculoNotas() <= 6 && CalculoNotas() >= 5) {
                char x = 'D';
                Console.WriteLine("Classificação: " + x);
            }
            else if (CalculoNotas() <= 5) {
                char x = 'R';
                Console.WriteLine("Classificação: " + x);
            }


        }




        private double CalculoNotas() {
            double n1 = this.Nota1;
            double n2 = this.nota2;
            double n3 = this.nota3;

            double final = (n1 + n2 + n3) / 3;
            return final;

        }
    }
}
