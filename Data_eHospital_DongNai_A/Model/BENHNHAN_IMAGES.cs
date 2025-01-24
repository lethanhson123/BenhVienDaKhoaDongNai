namespace Data_eHospital_DongNai_A.Model
{
    public partial class BENHNHAN_IMAGES : BaseModel
    {
        [Key]
        public int? BenhNhan_Images_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? File_Name_Origin { get; set; }
public string? File_Name { get; set; }
public int? NhomDichVu_Id { get; set; }
public string? TenHinh { get; set; }
public string? MoTa { get; set; }
public DateTime? NgayGhiNhanKetQua { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? LoaiHinhAnh_Id { get; set; }
public string? Folder { get; set; }
public string? NgayFolder { get; set; }

        public BENHNHAN_IMAGES()
        {
        }
    }
}

