namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_NhapVienService : IBaseService<NoiTru_NhapVien>
    {
        Task<List<NoiTru_NhapVien>> GetByListIDToListAsync(List<int?> ListID);
    }
}

