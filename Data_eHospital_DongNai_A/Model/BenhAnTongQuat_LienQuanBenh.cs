namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnTongQuat_LienQuanBenh : BaseModel
    {
        [Key]
        public long? BenhAnTongQuat_LienQuanBenh_Id { get; set; }
public int? BenhAnTongQuat_Id { get; set; }
public int? NoiDung_Id { get; set; }
public bool? KyHieu { get; set; }
public decimal? ThoiGian { get; set; }

        public BenhAnTongQuat_LienQuanBenh()
        {
        }
    }
}

