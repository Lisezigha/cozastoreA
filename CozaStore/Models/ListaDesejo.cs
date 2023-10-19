using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ListaDesejo")]

public class ListaDesejo
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

     [Key, Column(Order = 2)]
    [Display(Name = "Cliente")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data do Cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;

}
