namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChungTuPhanBoChiPhi : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? ChungTuChiPhi_ID { get; set; }
public int? Duoc_ID { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public string? GiaTri { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public string? SoChungTuKeToan { get; set; }

        public ChungTuPhanBoChiPhi()
        {
        }
    }
}

