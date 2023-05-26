using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineers name can't be empty.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "The engineers license can't be empty.")]
    public string License { get; set; }
    public List <EngineerMachine> JoinEntities { get; }

  }
}