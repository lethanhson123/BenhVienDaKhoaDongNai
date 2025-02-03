namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_BangGia_CPH : BaseModel
    {
        [Key]
        public int? BangGia_CPH_Id { get; set; }
public string? LoaiBangGia { get; set; }
public int? LoaiGia_Id { get; set; }
public string? TienTe_Id { get; set; }
public DateTime? NgayBanHanh { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public DateTime? NgayHetHieuLuc { get; set; }
public string? TrangThai { get; set; }
public bool? TamNgung { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_BangGia_CPH()
        {
        }
    }
}

