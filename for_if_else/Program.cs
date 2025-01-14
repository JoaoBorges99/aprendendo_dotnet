using System.Data.SqlTypes;
using System.Dynamic;

class Aluno {
    public string Nome {get;set;}
    public decimal[] Notas {get;set;}

    public Aluno( string nome, decimal[] notas){
        Nome = nome;
        Notas = notas;
    }
}

class Program {
    public static string RetornarNota (int nota){
        if(nota > 96 && nota < 100){
            return "A+";
        }else if (nota > 92 && nota <= 96){
            return "A";
        }else if (nota > 89 && nota <= 92){
            return "A-";
        }else if (nota > 86 && nota <= 89){
            return "B+";
        }else if (nota > 82 && nota <= 86){
            return "B";
        }else if (nota > 79 && nota <= 82){
            return "B-";
        }else if (nota > 76 && nota <= 79){
            return "C+";
        }else if (nota > 72 && nota <= 76){
            return "C";
        }else if (nota > 69 && nota <= 72){
            return "C-";
        }else if (nota > 66 && nota <= 69){
            return "D+";
        }else if (nota > 62 && nota <= 66){
            return "D";
        }else if (nota > 59 && nota <= 62){
            return "D-";
        }
        else{
            return "F";
        }
    }

    static void Main (){
        List<Aluno> alunos = [
            new("Sophia", [90,86,87,98,100]),
            new("Andrew", [92,89,81,96,90]),
            new("Emma", [90,85,87,98,68]),
            new("Logan", [90,95,87,88,96]),
        ];

        for(int i = 0; i < alunos.Count; i++){
            decimal notas = 0;
            for(int j = 0; j < alunos[i].Notas.Length; j++){
                notas += alunos[i].Notas[j];
            }
            Console.WriteLine($"Aluno: {alunos[i].Nome} - Media: {notas/alunos[i].Notas.Length} - Nota: {RetornarNota((int)(notas/alunos[i].Notas.Length))}");
        }
    }
}