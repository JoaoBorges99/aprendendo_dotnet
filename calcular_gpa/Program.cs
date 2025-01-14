class Curso {
    public string NomeCurso {get; set;}
    public int Nota {get; set;}
    public int HorasCredito {get; set;}

    public Curso(string nomeCurso, int nota, int horasCredito){
        NomeCurso = nomeCurso;
        Nota = nota;
        HorasCredito = horasCredito;
    }
}
class Program{
    static void Main(){
        Dictionary<string, List<Curso>> aluno = new Dictionary<string, List<Curso>> {
            {
                "Sophia Johnson", [new Curso("English 101", 4,3), new Curso("Algebra 101", 3,3), new Curso("Biology 101", 3,4), new Curso("Computer Science I", 3,4),new Curso("Psychology 101", 4,3), ]
            },
        };

        foreach(var valores in aluno){
            Console.WriteLine($"Aluno: {valores.Key}");
            decimal gpa = 0;
            decimal creditos = 0;
            for(int i = 0; i < valores.Value.Count; i++){
                Console.WriteLine($"Course: {valores.Value[i].NomeCurso} - Nota: {valores.Value[i].Nota} - Credito: {valores.Value[i].HorasCredito}");
                gpa += valores.Value[i].Nota * valores.Value[i].HorasCredito;
                creditos += valores.Value[i].HorasCredito;
            }
            Console.WriteLine($"GPA Final: {Math.Round(gpa/creditos,2)}");
        }
    }
}
