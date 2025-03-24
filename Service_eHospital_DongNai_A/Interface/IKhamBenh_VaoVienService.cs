namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenh_VaoVienService : IBaseService<KhamBenh_VaoVien>
    {
        Task<KhamBenh_VaoVien> GetByKhamBenhVaoVien_IdAsync(int KhamBenhVaoVien_Id);
        Task<List<KhamBenh_VaoVien>> GetByNgayKham_SearchStringToListAsync(DateTime NgayKham, string SearchString);
        Task<List<KhamBenh_VaoVien>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
        Task<List<KhamBenh_VaoVien>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day);
    }
}

