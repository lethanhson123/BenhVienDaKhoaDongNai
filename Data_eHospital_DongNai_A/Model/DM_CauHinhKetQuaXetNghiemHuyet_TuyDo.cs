namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_CauHinhKetQuaXetNghiemHuyet_TuyDo : BaseModel
    {
        [Key]
        public int? CauHinhKetQua_Id { get; set; }
public int? GiaTriChuan_Id { get; set; }
public int? KetQuaCheckList_Id { get; set; }

        public DM_CauHinhKetQuaXetNghiemHuyet_TuyDo()
        {
        }
    }
}

