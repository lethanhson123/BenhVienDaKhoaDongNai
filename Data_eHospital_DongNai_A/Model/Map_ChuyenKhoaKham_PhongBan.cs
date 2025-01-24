namespace Data_eHospital_DongNai_A.Model
{
    public partial class Map_ChuyenKhoaKham_PhongBan : BaseModel
    {
        [Key]
        public int? Map_ID { get; set; }
public int? ChuyenKhoaKham_ID { get; set; }
public int? PhongBan_ID { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_ID { get; set; }

        public Map_ChuyenKhoaKham_PhongBan()
        {
        }
    }
}

