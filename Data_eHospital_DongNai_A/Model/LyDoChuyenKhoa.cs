namespace Data_eHospital_DongNai_A.Model
{
    public partial class LyDoChuyenKhoa : BaseModel
    {
        [Key]
        public int? LyDoChuyenKhoa_Id { get; set; }
public string? LyDoChuyenKhoa_DienGiai { get; set; }

        public LyDoChuyenKhoa()
        {
        }
    }
}

