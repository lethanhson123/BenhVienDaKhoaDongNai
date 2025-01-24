namespace Data_eHospital_DongNai_A.Model
{
    public partial class Transfer : BaseModel
    {
        [Key]
        public int? Transfer_Id { get; set; }
public string? Transfer_Code { get; set; }
public string? Transfer_Type { get; set; }
public DateTime? Transfer_Date { get; set; }
public DateTime? Transfer_TuNgay { get; set; }
public DateTime? Transfer_DenNgay { get; set; }
public string? TrangThai { get; set; }
public string? GhiChu { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public Transfer()
        {
        }
    }
}

