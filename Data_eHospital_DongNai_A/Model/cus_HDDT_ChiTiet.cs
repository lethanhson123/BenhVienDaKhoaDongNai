namespace Data_eHospital_DongNai_A.Model
{
    public partial class cus_HDDT_ChiTiet : BaseModel
    {
        [Key]
        public int? IDCT { get; set; }
public int? VienPhiNoiTruChiTiet_Id { get; set; }
public int? VienPhiNoiTru_Id { get; set; }
public DateTime? NgayTao_trg { get; set; }

        public cus_HDDT_ChiTiet()
        {
        }
    }
}

