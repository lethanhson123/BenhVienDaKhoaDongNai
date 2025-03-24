namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_LuuTruService : BaseService<NoiTru_LuuTru, INoiTru_LuuTruRepository>
    , INoiTru_LuuTruService
    {
        private readonly INoiTru_LuuTruRepository _NoiTru_LuuTruRepository;
        public NoiTru_LuuTruService(INoiTru_LuuTruRepository NoiTru_LuuTruRepository) : base(NoiTru_LuuTruRepository)
        {
            _NoiTru_LuuTruRepository = NoiTru_LuuTruRepository;
        }
        public virtual async Task<List<NoiTru_LuuTru>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_LuuTru> result = new List<NoiTru_LuuTru>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.BenhAn_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_LuuTru>();
            }
            return result;
        }
    }
}

