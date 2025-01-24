namespace Data_eHospital_DongNai_A.Model
{
    public partial class His_ScheduleDetail : BaseModel
    {
        [Key]
        public int? ScheduleDetail_His_Id { get; set; }
public int? Schedule_His_Id { get; set; }
public int? ScheduleDetail_Id { get; set; }
public int? Schedule_Id { get; set; }
public int? Schedule_Value { get; set; }
public DateTime? StartTime { get; set; }
public DateTime? EndTime { get; set; }
public DateTime? BreakStart { get; set; }
public DateTime? BreakEnd { get; set; }
public decimal? TotalHours { get; set; }
public decimal? CPI { get; set; }
public decimal? Constant { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? Idx { get; set; }
public int? NumOfGroup { get; set; }
public int? Department_Id { get; set; }
public int? Block { get; set; }
public decimal? PercentOfBlock { get; set; }
public string? LyDoDoi { get; set; }
public int? Schedule_Type_Id { get; set; }

        public His_ScheduleDetail()
        {
        }
    }
}

