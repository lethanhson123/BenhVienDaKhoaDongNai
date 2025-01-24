namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocGiaVon : BaseModel
    {
        [Key]
        public int? DuocGiaVon_Id { get; set; }
public int? DuocKyTonKho_Id { get; set; }
public int? Duoc_Id { get; set; }
public float? DonGiaVon { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public string? NguoiCapNhat_Id { get; set; }

        public DuocGiaVon()
        {
        }
    }
}

