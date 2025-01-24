namespace Data_eHospital_DongNai_A.Model
{
    public partial class Cust_SyncHDDT_Temp : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? Fkey { get; set; }
public bool? IsNoiTru { get; set; }
public int? Status { get; set; }
public bool? Synchronized { get; set; }
public DateTime? SyncCreateDate { get; set; }
public string? SoChungTu { get; set; }
public string? LoaiChungTu { get; set; }
public int? BenhAn_id { get; set; }
public int? PhatSinh_Noi_id { get; set; }
public int? PhatSinh_Nguoi_id { get; set; }
public DateTime? PhatSinh_ThoiGian { get; set; }
public int? NguoiTao { get; set; }

        public Cust_SyncHDDT_Temp()
        {
        }
    }
}

