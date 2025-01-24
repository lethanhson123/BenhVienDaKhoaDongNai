namespace Data_eHospital_DongNai_A.Model
{
    public partial class MauTinSMS : BaseModel
    {
        [Key]
        public int? MauTin_Id { get; set; }
public string? TenMauTin { get; set; }
public string? NoiDung { get; set; }
public string? TinSMS_LoaiTinId { get; set; }
public string? MaMauTin { get; set; }
public int? LoaiLichHen_Id { get; set; }

        public MauTinSMS()
        {
        }
    }
}

