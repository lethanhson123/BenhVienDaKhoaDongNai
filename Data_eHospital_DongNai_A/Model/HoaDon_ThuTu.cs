namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoaDon_ThuTu : BaseModel
    {
        [Key]
        public int? BenhNhan_Id { get; set; }
public DateTime? STT { get; set; }
public DateTime? NgayTao { get; set; }
public int? PhongBan_Id { get; set; }

        public HoaDon_ThuTu()
        {
        }
    }
}

