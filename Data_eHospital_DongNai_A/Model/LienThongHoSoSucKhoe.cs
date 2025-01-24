namespace Data_eHospital_DongNai_A.Model
{
    public partial class LienThongHoSoSucKhoe : BaseModel
    {
        [Key]
        public int? LienThongHoSoSucKhoe_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? KhamSucKhoe_Id { get; set; }
public int? HoSo_Id { get; set; }
public string? SoHoSo { get; set; }
public string? LoaiHoSo { get; set; }
public string? UUID { get; set; }
public string? HoSoContent { get; set; }
public string? HoSoContentXML { get; set; }
public string? KetQuaContent { get; set; }
public bool? DaGui { get; set; }
public int? NguoiGui_Id { get; set; }
public DateTime? NgayGui { get; set; }
public DateTime? ThoiGianGui { get; set; }
public bool? ThuHoi { get; set; }
public int? NguoiThuHoi_Id { get; set; }
public DateTime? NgayThuHoi { get; set; }
public DateTime? ThoiGianThuHoi { get; set; }
public int? NguoiCapNhat_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }
public DateTime? ThoiGianCapNhat { get; set; }

        public LienThongHoSoSucKhoe()
        {
        }
    }
}

