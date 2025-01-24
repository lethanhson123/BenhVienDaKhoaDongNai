namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQua_XetNghiem : BaseModel
    {
        [Key]
        public int? CLSKetQua_XetNghiem_Id { get; set; }
public int? CLSKetQua_ID { get; set; }
public string? SoPhieu { get; set; }
public int? CLSYeuCau_ID { get; set; }
public string? GhiChu { get; set; }
public int? CLSYeuCauChiTiet_ID { get; set; }

        public CLSKetQua_XetNghiem()
        {
        }
    }
}

