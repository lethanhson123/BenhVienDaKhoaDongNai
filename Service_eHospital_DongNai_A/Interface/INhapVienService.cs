namespace Service_eHospital_DongNai_A.Interface
{
    public interface INhapVienService : IBaseService<NhapVien>
    {
        Task<List<NhapVien>> GetByListIDToListAsync(List<int?> ListID);
    }
}

