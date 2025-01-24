namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQuaMau : BaseModel
    {
        [Key]
        public int? KetQuaMau_Id { get; set; }
public int? CLSKetQua_Id { get; set; }
public int? NhomDVHuyetHoc_Id { get; set; }
public int? SoLanCoThai { get; set; }
public int? SoLanTruyenMau { get; set; }
public int? NguoiGiaoMau_Id { get; set; }
public int? NguoiNhanMau_Id { get; set; }
public DateTime? NgayNhan { get; set; }
public string? GhiChu { get; set; }
public string? KetLuan { get; set; }

        public CLSKetQuaMau()
        {
        }
    }
}

