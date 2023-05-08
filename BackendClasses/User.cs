using System.Formats.Asn1;

namespace BackendClasses
{
    public class User
    {
        int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime Birthday { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public List<string> Photos { get; set; } //пути к фоткам, фотки будут лежать в облаке
        public List<string>? Tags { get; set; }
    }
}