namespace Data_eHospital_DongNai_A.Model
{
    public partial class BENHANNGOAITRU_KHAMBENH : BaseModel
    {
        [Key]
        public int? KHAMBENH_ID { get; set; }
public int? BENHANNGOAITRU_ID { get; set; }
public int? LANKHAM { get; set; }
public DateTime? NGAYKHAM { get; set; }
public DateTime? THOIGIANKHAM { get; set; }
public int? BASSIKHAM_ID { get; set; }
public int? DIEUDUONG_ID { get; set; }
public string? DINHBENH { get; set; }
public string? DIENBIEN { get; set; }
public string? LOIDAN { get; set; }
public int? KHODUOC_ID { get; set; }
public DateTime? NGAYTAO { get; set; }
public int? NGUOITAO_ID { get; set; }
public DateTime? NGAYCAPNHAT { get; set; }
public int? NGUOICAPNHAT_ID { get; set; }
public int? DOITUONG_ID { get; set; }
public int? CAPHOLY_ID { get; set; }
public bool? RAVIEN { get; set; }
public DateTime? NGAYTAIKHAM { get; set; }
public int? SONGAYHENTAIKHAM { get; set; }
public int? CHUNGTUPHATTHUOC_ID { get; set; }
public string? ATTRIBUTE_1 { get; set; }
public string? ATTRIBUTE_2 { get; set; }
public int? ATTRIBUTE_3 { get; set; }
public int? ATTRIBUTE_4 { get; set; }
public DateTime? ATTRIBUTE_5 { get; set; }
public bool? ATTRIBUTE_6 { get; set; }
public string? LoaiToaThuoc { get; set; }
public int? NoiNhanThuoc_ID { get; set; }
public bool? ThuocDacTri { get; set; }
public bool? KhamNgoaiTru { get; set; }

        public BENHANNGOAITRU_KHAMBENH()
        {
        }
    }
}

