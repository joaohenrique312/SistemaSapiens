namespace Sapiens.Shared.Entities;

public class Professor : Funcionario
{
    public required int CodigoAcademico { get; set; }
    public string? MetodologiaEnsino { get; set; }
    public string? FormacaoAcademica { get; set; }
}
