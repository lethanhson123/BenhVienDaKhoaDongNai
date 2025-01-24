namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChiPhiChiTiet_DoiTuong : BaseModel
    {
        [Key]
        public int? ChiPhiChiTiet_DoiTuong_Id { get; set; }
public int? IDRef { get; set; }
public string? Loai_IDRef { get; set; }
public int? TiepNhan_DoiTuongThayDoi_Id { get; set; }
public int? DoiTuong_Id { get; set; }
public int? YeuCauChiTiet_Id { get; set; }
public int? ToaThuoc_Id { get; set; }
public int? ToaThuocTra_Id { get; set; }
public int? BenhAnPhauThuat_VTYT_ID { get; set; }
public int? ChungTuXuatBN_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }

        public ChiPhiChiTiet_DoiTuong()
        {
        }
    }
}

