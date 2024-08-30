namespace Biscoitinhos.domain.Entidades
{
  public class EntidadeBase
  {
    public Guid Id { get; set; }
    public EntidadeBase()
    {
      this.Id = Guid.NewGuid();
    }
  }
}
