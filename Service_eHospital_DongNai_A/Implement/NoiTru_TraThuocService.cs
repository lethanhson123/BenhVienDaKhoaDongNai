namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_TraThuocService : BaseService<NoiTru_TraThuoc, INoiTru_TraThuocRepository>
    , INoiTru_TraThuocService
    {
        private readonly INoiTru_TraThuocRepository _NoiTru_TraThuocRepository;
        public NoiTru_TraThuocService(INoiTru_TraThuocRepository NoiTru_TraThuocRepository) : base(NoiTru_TraThuocRepository)
        {
            _NoiTru_TraThuocRepository = NoiTru_TraThuocRepository;
        }
        public virtual async Task<List<NoiTru_TraThuoc>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_TraThuoc> result = new List<NoiTru_TraThuoc>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.LuuTru_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_TraThuoc>();
            }
            return result;
        }
    }
}

