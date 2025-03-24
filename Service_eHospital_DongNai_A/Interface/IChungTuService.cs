namespace Service_eHospital_DongNai_A.Interface
{
    public interface IChungTuService : IBaseService<ChungTu>
    {
        Task<ChungTu> GetByChungTu_IdAsync(int ChungTu_Id);
        Task<List<ChungTu>> GetByNgayChungTu_SearchStringToListAsync(DateTime NgayChungTu, string SearchString);
        Task<List<ChungTu>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
        Task<List<ChungTu>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day);
    }
}

