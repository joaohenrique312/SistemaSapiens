using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Funcionario
{
    [StringLength(100)]
    public required string Nome {  get; set; }
    public string? CPF { get; set; }
    public TipoFuncionario Tipo { get; set; }
    public double? RendaSalarial { get; set; }
    public int? TempoServico { get; set; }
    public string? Email { get; set; }
    public int? Numero { get; set; }
}