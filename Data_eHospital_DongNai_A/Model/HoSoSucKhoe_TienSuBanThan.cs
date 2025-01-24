namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoSucKhoe_TienSuBanThan : BaseModel
    {
        [Key]
        public int? TienSuBanThan_Id { get; set; }
public int? HoSoSucKhoe_Id { get; set; }
public int? ICD_ID { get; set; }
public string? Benh { get; set; }
public int? NhomBenh_Id { get; set; }
public DateTime? NgayXacDinh { get; set; }
public int? NamMacBenh { get; set; }
public string? GhiChu { get; set; }

        public HoSoSucKhoe_TienSuBanThan()
        {
        }
    }
}

