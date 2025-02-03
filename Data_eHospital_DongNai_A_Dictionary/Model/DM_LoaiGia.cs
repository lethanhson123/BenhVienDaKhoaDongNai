namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_LoaiGia : BaseModel
    {
        [Key]
        public int? LoaiGia_Id { get; set; }
public string? MaLoaiGia { get; set; }
public string? TenLoaiGia { get; set; }
public int? NhomGia_Id { get; set; }
public int? CapTren_Id { get; set; }
public string? GhiChu { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Idx { get; set; }

        public DM_LoaiGia()
        {
        }
    }
}

