namespace Service.Interface
{
    public interface IThongKeService : IBaseService<ThongKe>
    {
        Task<ThongKe> GetByParentID_Year_Month_DayAsync(long ParentID, int Year, int Month, int Day);
        Task<ThongKe> GetByParentID_Year_MonthAsync(long ParentID, int Year, int Month);
    }
}

