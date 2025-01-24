namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_LichCongTac : BaseModel
    {
        [Key]
        public int? CDT_LichCongTac_Id { get; set; }
public int? CDT_Loai_Id { get; set; }
public string? NoiDungCongViec { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public string? ThanhPhanThamGiaDuKien { get; set; }
public decimal? KinhPhiDuKien { get; set; }
public int? NguoiLap_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CDT_LichCongTac()
        {
        }
    }
}

