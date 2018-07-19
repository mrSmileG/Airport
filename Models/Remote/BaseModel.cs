using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Remote
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
    }
}
