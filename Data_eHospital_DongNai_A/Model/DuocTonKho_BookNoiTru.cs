namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonKho_BookNoiTru : BaseModel
    {
        [Key]
        public int? DuocTonKho_BookNoiTru_Id { get; set; }
public int? PhieuLinhDuoc_Id { get; set; }
public int? PhieuLinhDuocChiTiet_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public int? SoLuong { get; set; }
public int? NguonHang_Id { get; set; }
public int? KhamBenh_ID { get; set; }
public int? KhamBenh_VTYT_ID { get; set; }
public int? CLSYeuCau_ID { get; set; }
public int? CLSGhiNhanHoaChat_VTYT_ID { get; set; }
public int? BenhAnPhauThuat_ID { get; set; }
public int? BenhAnPhauThuat_VTYT_ID { get; set; }
public int? NoiTru_KhamBenh_ID { get; set; }
public int? NoiTru_ToaThuoc_ID { get; set; }
public bool? HuyBook { get; set; }

        public DuocTonKho_BookNoiTru()
        {
        }
    }
}

