namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQuaYeuCau : BaseModel
    {
        [Key]
        public int? CLSKetQua_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }

        public CLSKetQuaYeuCau()
        {
        }
    }
}

