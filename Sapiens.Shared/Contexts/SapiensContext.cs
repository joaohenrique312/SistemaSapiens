﻿using Sapiens.Shared.Entities;

namespace Sapiens.Shared.Contexts;

public class SapiensContext
{
    public required List<Curso> Cursos { get; set; }
    public required List<Disciplina> Disciplinas { get; set; }
    public required List<Funcionario> Funcionarios { get; set; }
    public required List<Professor> Professores { get; set; }
    public required List<Coordenador> Coordenadores { get; set; }
    public required List<Aluno> Alunos { get; set; }

    public SapiensContext()
    {
        Cursos = new();
        Disciplinas = new();
        Funcionarios = new();
        Professores = new();
        Coordenadores = new();
        Alunos = new();
    }
}
