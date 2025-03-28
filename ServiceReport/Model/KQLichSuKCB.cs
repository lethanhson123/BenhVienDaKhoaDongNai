namespace ServiceReport.Model
{
	public class KQLichSuKCB : ServiceReport.Model.BaseModel
    {
        public string? maKetQua { get; set; }

        public string? ghiChu { get; set; }

        public string? maThe { get; set; }

        public string? hoTen { get; set; }

        public string? ngaySinh { get; set; }

        public string? gioiTinh { get; set; }

        public string? diaChi { get; set; }

        public string? maDKBD { get; set; }

        public string? cqBHXH { get; set; }

        public string? gtTheTu { get; set; }

        public string? gtTheDen { get; set; }

        public string? maKV { get; set; }

        public string? ngayDu5Nam { get; set; }

        public string? maSoBHXH { get; set; }

        public string? maTheCu { get; set; }

        public string? maTheMoi { get; set; }

        public string? gtTheTuMoi { get; set; }

        public string? gtTheDenMoi { get; set; }

        public string? maDKBDMoi { get; set; }

        public string? tenDKBDMoi { get; set; }

        public List<LichSuKhamChuaBenh>? dsLichSuKCB2018 { get; set; }

        public List<LichSuKT2018>? dsLichSuKT2018 { get; set; }

        public KQLichSuKCB()
		{              
        }
	}
}
