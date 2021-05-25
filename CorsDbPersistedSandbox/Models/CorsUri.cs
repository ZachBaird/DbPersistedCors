namespace CorsDbPersistedSandbox.Models
{
    public sealed class CorsUri
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool IsWhitelisted { get; set; }
    }
}
