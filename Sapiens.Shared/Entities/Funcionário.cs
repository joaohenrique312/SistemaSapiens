using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Funcionário
{
    [StringLength(100)]
    public required string Nome {  get; set; }
    public TipoFuncionario Tipo { get; set;}
    public double? RendaSalarial { get; set; }
}