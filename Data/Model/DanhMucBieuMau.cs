namespace Data.Model
{
    public partial class DanhMucBieuMau : BaseModel
    {

        public int? HeSo { get; set; }
        public bool? IsTamUng { get; set; }

        public DanhMucBieuMau()
        {
            HeSo = 1;
        }
    }
}

