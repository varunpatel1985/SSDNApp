namespace API.Entities
{
    public class SevaAllocation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SevaId { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    
    }
}