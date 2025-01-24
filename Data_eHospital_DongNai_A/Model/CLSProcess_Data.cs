namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSProcess_Data : BaseModel
    {
        [Key]
        public int? SPID { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }

        public CLSProcess_Data()
        {
        }
    }
}

