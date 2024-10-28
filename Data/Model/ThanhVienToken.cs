namespace Data.Model
{
    public partial class ThanhVienToken : BaseModel
    {
        public string? Token { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public ThanhVienToken()
        {
        }
    }
}

