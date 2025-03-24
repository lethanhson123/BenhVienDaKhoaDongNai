namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_LuuTruChiTietService : IBaseService<NoiTru_LuuTruChiTiet>
    {
        Task<List<NoiTru_LuuTruChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

