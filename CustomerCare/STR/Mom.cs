namespace CustomerCare
{
    public class Mom : People
    {
        public string Rec_Date { get; set; }
        public string Tel { get; set; }
        public string Tel_2 { get; set; } = null;
        public string Call_Date { get; set; }
        public string Frm_Source { get; set; }
        public string Ept_Date { get; set; }
        public int Pro_Id { get; set; }
        public string FB { get; set; } = null;
        public string Email { get; set; } = null;
        public string Location { get; set; }
        public int Kid_Id { get; set; }
        public int Staff_Id { get; set; }
        public int Hcp_Id { get; set; }
    }
}