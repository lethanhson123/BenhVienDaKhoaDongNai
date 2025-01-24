namespace Data_eHospital_DongNai_A.Model
{
    public partial class NoiTru_ChamSocDichTruyen : BaseModel
    {
        [Key]
        public int? NoiTru_ChamSocDichTruyen_Id { get; set; }
public int? NoiTru_ChamSoc_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? SoLuong { get; set; }
public string? SoMLChayNguoc { get; set; }
public string? SoMLGiaoLai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public NoiTru_ChamSocDichTruyen()
        {
        }
    }
}

