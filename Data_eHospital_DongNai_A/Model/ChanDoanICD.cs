namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChanDoanICD : BaseModel
    {
        [Key]
        public int? ChanDoanIDC_Id { get; set; }
public int? ICD_Id { get; set; }
public bool? ICD_Main { get; set; }
public int? IDRef { get; set; }
public string? LoaiIDRef { get; set; }
public int? NoiTru_NhapVien_Id { get; set; }
public int? LuuTru_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? NoiTru_KhamBenh_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? BENHANNGOAITRU_KHAMBENH_Id { get; set; }

        public ChanDoanICD()
        {
        }
    }
}

