namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhNhan_HinhAnh : BaseModel
    {
        [Key]
        public int? BenhNhan_HinhAnh_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? HinhAnh { get; set; }
public string? ChuKy { get; set; }

        public BenhNhan_HinhAnh()
        {
        }
    }
}

