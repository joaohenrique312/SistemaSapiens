using Sapiens.Shared.Enums;

namespace Sapiens.Shared.Entities;

public class Aluno
{
    public required string Nome { get; set; }
    public required int RegistroAcademico { get; set; }
    public TipoMatricula Tipo { get; set; }
    public int? NumeroFaltas { get; set; }
    public float? Frequencia { get; set; }
    public int? NumeroTelefone { get; set; }
    public string? Email { get; set; }
    public string? CPF { get; set; }
}
