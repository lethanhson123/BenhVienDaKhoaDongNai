namespace Data_eHospital_DongNai_A.Model
{
    public partial class XacNhanChiPhi_DEL : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? Ma_File { get; set; }
public string? Ma_Lk { get; set; }
public int? XacNhanChiPhi_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? SoBHYT { get; set; }
public string? Loai { get; set; }
public DateTime? NgayVao { get; set; }
public DateTime? NgayRa { get; set; }
public DateTime? NgayDel { get; set; }
public int? isExport { get; set; }

        public XacNhanChiPhi_DEL()
        {
        }
    }
}

