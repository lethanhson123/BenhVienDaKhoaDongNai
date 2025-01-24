namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChayThanNhanTao_ChiTiet : BaseModel
    {
        [Key]
        public long? BenhAnTongQuat_LienQuanBenh_Id { get; set; }
public int? BenhAnTongQuat_Id { get; set; }
public string? Gio { get; set; }
public string? MHA { get; set; }
public int? VTMAU { get; set; }
public int? ALTM { get; set; }
public int? UFTHUC { get; set; }
public string? XUTRI { get; set; }
public string? TENDD { get; set; }

        public ChayThanNhanTao_ChiTiet()
        {
        }
    }
}

