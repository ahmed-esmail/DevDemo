using Domain.Common;

namespace Domain
{
  public class Product : BaseEntity
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string ImageThumbnailUrl { get; set; }
    public bool IsPreferredProduct { get; set; }
    public bool InStock { get; set; }
    public Guid CategoryId { get; set; }
    

  }
}