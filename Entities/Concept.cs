using System.ComponentModel.DataAnnotations.Schema;

namespace InternTask.Entities
{
    public class Concept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Composition { get; set; }
    }
}
