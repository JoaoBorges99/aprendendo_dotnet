// Calcular e imprimir notas de alunos

List<Dictionary<string, List<int>>> lista_alunos_notas = new List<Dictionary<string, List<int>>>
{
    new Dictionary<string, List<int>>
    {
        { "Sophia", [93,87,98,95,100] },
        { "Nicolas", [80,83,82,88,85] },
        { "Zarirah", [84,96,73,85,79] },
        { "Jeong", [90,92,98,100,97] },
    }
};

foreach(Dictionary<string,List<int>> alunos_notas in lista_alunos_notas){
    foreach(var nome in alunos_notas){
        int number = 0;
        for(int i = 0; i < nome.Value.Count; i++){
            number += nome.Value[i];
        }
        decimal media = number/(decimal)nome.Value.Count;
        string nota = "";

        if(media >= 97 && media <= 100){
            nota = "A+";
        }else if(media >= 93 && media <= 96){
            nota = "A";
        }else if(media >= 90 && media <= 92){
            nota = "A-";
        }else if(media >= 87 && media <= 89){
            nota = "B+";
        }else{
            nota = "B";
        }

        Console.WriteLine($"Aluno: {nome.Key} - Media: {media} - Nota: {nota}");
    }
}