namespace Data_eHospital_DongNai_A.Model
{
    public partial class cus_HDDT : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? VienPhiNoiTru_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? HinhThucThanhToan_id { get; set; }
public string? GiaTriHoaDon { get; set; }
public string? PhatSinh_Ngay { get; set; }
public DateTime? PhatSinh_ThoiGian { get; set; }
public int? PhatSinh_Noi_id { get; set; }
public string? ThuHD_BL { get; set; }
public bool? DaThanhToan { get; set; }
public bool? HuyHoaDon { get; set; }
public bool? HoanTra { get; set; }
public DateTime? NgayTao_trg { get; set; }

        public cus_HDDT()
        {
        }
    }
}

