namespace Service_eHospital_DongNai_A.Interface
{
    public interface ITiepNhanService : IBaseService<TiepNhan>
    {
        Task<TiepNhan> GetByTiepNhan_IdAsync(int TiepNhan_Id);
        Task<List<TiepNhan>> GetByNgayTiepNhan_SearchStringToListAsync(DateTime NgayTiepNhan, string SearchString);
        Task<List<TiepNhan>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
        Task<List<TiepNhan>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day);
    }
}

