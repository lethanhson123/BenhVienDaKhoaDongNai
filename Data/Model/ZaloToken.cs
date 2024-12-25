namespace Data.Model
{
    public partial class ZaloToken : BaseModel
    {
        public DateTime? NgayGhiNhan { get; set; }
        public string? OAAccessToken { get; set; }
        public string? OARefreshToken { get; set; }
        public ZaloToken()
        {
        }
    }
}

