namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_Duoc_CanhBao : BaseModel
    {
        [Key]
        public int? Duoc_CanhBao_ID { get; set; }
public int? Duoc_Id { get; set; }
public string? TuThang { get; set; }
public string? DenThang { get; set; }
public string? TuNamSinh { get; set; }
public string? DenNamSinh { get; set; }
public DateTime? TuNgaySinh { get; set; }
public DateTime? DenNgaySinh { get; set; }
public string? CanNangTu { get; set; }
public string? CanNangDen { get; set; }
public string? SoLuong_NgayTu { get; set; }
public string? SoLuong_NgayDen { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Vien { get; set; }

        public DM_Duoc_CanhBao()
        {
        }
    }
}

