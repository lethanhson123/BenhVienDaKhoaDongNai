namespace Data_eHospital_DongNai_A.Model
{
    public partial class DMDuoc : BaseModel
    {
        [Key]
        public string? loaivattu { get; set; }
        public string? ma { get; set; }
        public string? tenduoc { get; set; }
        public float? ĐVT { get; set; }
        public string? hamluong { get; set; }
        public float? loaiduoc { get; set; }
        public string? phannhomduoc { get; set; }
        public float? hangsanxuat { get; set; }
        public string? nuocsanxuat { get; set; }
        public string? Hoatchat { get; set; }
        public float? BHYT { get; set; }
        public string? duongdung { get; set; }
        public float? giaban { get; set; }
        public int? quocgia_id { get; set; }
        public int? duongdung_id { get; set; }

        public DMDuoc()
        {
        }
    }
}

