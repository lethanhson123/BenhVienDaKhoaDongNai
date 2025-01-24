namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChanXaTri : BaseModel
    {
        [Key]
        public int? HoiChanXaTri_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhAn_Id { get; set; }
public int? BacSiChuNhiem_Id { get; set; }
public int? BacSiDieuTri_Id { get; set; }
public string? ChanDoanLamSang { get; set; }
public string? GiaiPhauBenhLy { get; set; }
public string? DieuTriTruoc { get; set; }
public string? LamSang { get; set; }
public string? CanLamSang { get; set; }
public string? ViTriChieuXa { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayTao { get; set; }

        public HoiChanXaTri()
        {
        }
    }
}

