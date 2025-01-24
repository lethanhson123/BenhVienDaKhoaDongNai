namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_DM_NhomDoiTuong_DichVu : BaseModel
    {
        [Key]
        public int? NhomDoiTuong_DichVu_Id { get; set; }
public int? NhomDoiTuong_Id { get; set; }
public int? DichVu_Id { get; set; }

        public KSK_DM_NhomDoiTuong_DichVu()
        {
        }
    }
}

