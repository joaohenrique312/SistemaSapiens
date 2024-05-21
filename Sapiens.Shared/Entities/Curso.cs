using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Curso
{
    [StringLength(100)]
    public required string Nome { get; set; }
    public int? CargaHoraria { get; set; }
    public TipoCurso Tipo { get; set; }
}
