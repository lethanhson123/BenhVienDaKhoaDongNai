namespace Data_eHospital_DongNai_A.Model
{
    public partial class XepLichMo_EKipMo : BaseModel
    {
        [Key]
        public int? XepLichMo_EKipMo_Id { get; set; }
public int? LichMo_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }
public int? Idx { get; set; }

        public XepLichMo_EKipMo()
        {
        }
    }
}

