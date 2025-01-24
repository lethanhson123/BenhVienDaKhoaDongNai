namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_ThuocTiemChung : BaseModel
    {
        [Key]
        public int? ThuocTiemChung_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? NhomTiemChung_Id { get; set; }

        public DM_ThuocTiemChung()
        {
        }
    }
}

