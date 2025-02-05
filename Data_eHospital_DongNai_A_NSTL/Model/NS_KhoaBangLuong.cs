namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_KhoaBangLuong : BaseModel
    {
        [Key]
        public int? NS_KhoaBangLuong_Id { get; set; }
public string? MaPhongBan { get; set; }
public int? Thang { get; set; }
public int? Nam { get; set; }
public bool? Khoa { get; set; }

        public NS_KhoaBangLuong()
        {
        }
    }
}

