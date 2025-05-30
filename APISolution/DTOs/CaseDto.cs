namespace APISolution.DTOs
{
    public class CaseDto
    {
        public int Id { get; set; }
        // Exclude Customer to prevent cycle
    }
}
