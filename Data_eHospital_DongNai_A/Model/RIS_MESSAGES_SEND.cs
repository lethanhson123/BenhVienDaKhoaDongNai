namespace Data_eHospital_DongNai_A.Model
{
    public partial class RIS_MESSAGES_SEND : BaseModel
    {
        [Key]
        public int? Messages_Id { get; set; }
public string? Messages_Control_Id { get; set; }
public string? Messages_Type { get; set; }
public string? Messages_Type_Code { get; set; }
public string? Messages_Name { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? YeuCauChiTiet_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public RIS_MESSAGES_SEND()
        {
        }
    }
}

