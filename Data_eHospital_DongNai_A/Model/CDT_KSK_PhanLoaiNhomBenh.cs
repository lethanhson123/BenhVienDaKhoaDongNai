namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KSK_PhanLoaiNhomBenh : BaseModel
    {
        [Key]
        public int? KSK_PhanLoaiNhomBenh_Id { get; set; }
public int? KSK_NgoaiVien_Id { get; set; }
public int? NhomBenh_Id { get; set; }
public int? SoCa { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CDT_KSK_PhanLoaiNhomBenh()
        {
        }
    }
}

