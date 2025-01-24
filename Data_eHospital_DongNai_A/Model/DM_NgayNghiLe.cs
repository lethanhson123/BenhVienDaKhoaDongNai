namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_NgayNghiLe : BaseModel
    {
        [Key]
        public int? NgayLe_Id { get; set; }
public int? Nam { get; set; }
public DateTime? NgayNghi { get; set; }
public string? GhiChu { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_NgayNghiLe()
        {
        }
    }
}

