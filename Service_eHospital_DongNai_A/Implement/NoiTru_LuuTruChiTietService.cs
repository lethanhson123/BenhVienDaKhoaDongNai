namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_LuuTruChiTietService : BaseService<NoiTru_LuuTruChiTiet, INoiTru_LuuTruChiTietRepository>
    , INoiTru_LuuTruChiTietService
    {
        private readonly INoiTru_LuuTruChiTietRepository _NoiTru_LuuTruChiTietRepository;
        public NoiTru_LuuTruChiTietService(INoiTru_LuuTruChiTietRepository NoiTru_LuuTruChiTietRepository) : base(NoiTru_LuuTruChiTietRepository)
        {
            _NoiTru_LuuTruChiTietRepository = NoiTru_LuuTruChiTietRepository;
        }
        public virtual async Task<List<NoiTru_LuuTruChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_LuuTruChiTiet> result = new List<NoiTru_LuuTruChiTiet>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.LuuTru_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_LuuTruChiTiet>();
            }
            return result;
        }
    }
}

