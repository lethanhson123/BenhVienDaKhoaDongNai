namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_LuuTruService : IBaseService<NoiTru_LuuTru>
    {
        Task<List<NoiTru_LuuTru>> GetByListIDToListAsync(List<int?> ListID);
    }
}

