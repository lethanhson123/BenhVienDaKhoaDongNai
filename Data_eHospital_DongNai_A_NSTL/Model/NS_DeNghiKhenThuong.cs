namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DeNghiKhenThuong : BaseModel
    {
        [Key]
        public int? Thang { get; set; }
public int? Nam { get; set; }
public string? MaNhanVien { get; set; }
public string? GhiChu { get; set; }

        public NS_DeNghiKhenThuong()
        {
        }
    }
}

