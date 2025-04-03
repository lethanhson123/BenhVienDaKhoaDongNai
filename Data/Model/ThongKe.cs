namespace Data.Model
{
    public partial class ThongKe : BaseModel
    {
        public DateTime? BatDau { get; set; }
        public DateTime? KetThuc { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public int? Hour { get; set; }
        public int? Week { get; set; }
        public int? Quarter { get; set; }

        public ThongKe()
        {
        }
    }
}

