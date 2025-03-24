namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_LuuTru_TraceService : IBaseService<NoiTru_LuuTru_Trace>
    {
        Task<List<NoiTru_LuuTru_Trace>> GetByListIDToListAsync(List<int?> ListID);
    }
}

