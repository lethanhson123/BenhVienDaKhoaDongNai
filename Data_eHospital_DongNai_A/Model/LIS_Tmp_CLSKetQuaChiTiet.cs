namespace Data_eHospital_DongNai_A.Model
{
    public partial class LIS_Tmp_CLSKetQuaChiTiet : BaseModel
    {
        [Key]
        public int? CLSYeuCau_Id { get; set; }
public int? DichVu_Id { get; set; }
public string? KetQua { get; set; }
public bool? BatThuong { get; set; }
public DateTime? ThoiGian { get; set; }

        public LIS_Tmp_CLSKetQuaChiTiet()
        {
        }
    }
}

