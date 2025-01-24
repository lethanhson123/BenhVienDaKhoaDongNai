namespace Data_eHospital_DongNai_A.Model
{
    public partial class TiepNhan_ThuocUngThu : BaseModel
    {
        [Key]
        public int? TiepNhan_ThuocUngThu_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public bool? DuocPhepSuDung { get; set; }
public string? GiayChungNhan { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public TiepNhan_ThuocUngThu()
        {
        }
    }
}

