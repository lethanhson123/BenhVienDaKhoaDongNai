namespace Data_eHospital_DongNai_A.Model
{
    public partial class HangDoi_Details_20231109 : BaseModel
    {
        [Key]
        public int? Idx { get; set; }
public int? HangDoi_Idx { get; set; }
public int? SoTT { get; set; }
public int? TinhTrang { get; set; }
public DateTime? Ngay { get; set; }
public DateTime? NgayTao { get; set; }
public bool? App { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? GioiTinh { get; set; }
public int? NamSinh { get; set; }
public string? TenBenhNhan { get; set; }
public string? MaYte { get; set; }

        public HangDoi_Details_20231109()
        {
        }
    }
}

