namespace Service_eHospital_DongNai_A.Interface
{
    public interface IHoaDonService : IBaseService<HoaDon>
    {
        Task<List<HoaDon>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day);
    }
}

