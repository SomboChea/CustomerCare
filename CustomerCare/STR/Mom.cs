namespace CustomerCare
{
    public class Mom : People
    {
        public string Tel_1 { get; set; }
        public string Tel_2 { get; set; } = null;
        public string Ept_Date { get; set; }
        public string FB { get; set; } = null;
        public string Email { get; set; } = null;
        public string Location_Id { get; set; }
        public int Logger_Id { get; set; }
        public string Refer_Id { get; set; }
        public string Other { get; set; }
    }
}