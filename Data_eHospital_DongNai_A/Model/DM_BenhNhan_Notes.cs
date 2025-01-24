namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_BenhNhan_Notes : BaseModel
    {
        [Key]
        public int? BenhNhan_Notes_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? TieuDe { get; set; }
public string? NoiDung { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public int? Status_Id { get; set; }
public bool? Reminder { get; set; }
public string? Reminder_Position { get; set; }
public int? NguoiLap_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_BenhNhan_Notes()
        {
        }
    }
}

