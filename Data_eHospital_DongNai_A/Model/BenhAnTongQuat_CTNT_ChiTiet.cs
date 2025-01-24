namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnTongQuat_CTNT_ChiTiet : BaseModel
    {
        [Key]
        public int? BenhAnTongQuat_ChiTiet_Id { get; set; }
public int? BenhAnTongQuat_Id { get; set; }
public DateTime? Gio { get; set; }
public int? Mach { get; set; }
public int? HuyenApCao { get; set; }
public int? HuyenApThap { get; set; }
public int? VTMau { get; set; }
public int? ALTM { get; set; }
public int? UFThuc { get; set; }
public string? XuTri { get; set; }
public string? TenDD { get; set; }

        public BenhAnTongQuat_CTNT_ChiTiet()
        {
        }
    }
}

