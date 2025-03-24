namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenhService : IBaseService<KhamBenh>
    {
        Task<KhamBenh> GetByKhamBenh_IdAsync(int KhamBenh_Id);
        Task<List<KhamBenh>> GetByNgayKham_SearchStringToListAsync(DateTime NgayKham, string SearchString);
        Task<List<KhamBenh>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
        Task<List<KhamBenh>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day);
    }
}

