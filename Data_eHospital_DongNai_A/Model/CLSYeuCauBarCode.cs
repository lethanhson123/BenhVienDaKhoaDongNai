namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSYeuCauBarCode : BaseModel
    {
        [Key]
        public int? CLSYeuCauBarCode_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }
public string? BarCodeID { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CLSYeuCauBarCode()
        {
        }
    }
}

