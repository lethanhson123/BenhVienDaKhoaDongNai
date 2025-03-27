namespace ServiceReport.Model
{
	public class ThongTinBenhNhan : ServiceReport.Model.BaseModel
    {
       
        public string? maThe { get; set; }
        public string? hoTen { get; set; }
        public string? ngaySinh { get; set; }
        public string? hoTenCb { get; set; }
        public string? cccdCb { get; set; }

        public ThongTinBenhNhan()
		{              
        }
	}
}
