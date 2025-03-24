namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_KhamBenhService : BaseService<NoiTru_KhamBenh, INoiTru_KhamBenhRepository>
    , INoiTru_KhamBenhService
    {
        private readonly INoiTru_KhamBenhRepository _NoiTru_KhamBenhRepository;
        public NoiTru_KhamBenhService(INoiTru_KhamBenhRepository NoiTru_KhamBenhRepository) : base(NoiTru_KhamBenhRepository)
        {
            _NoiTru_KhamBenhRepository = NoiTru_KhamBenhRepository;
        }
        public virtual async Task<List<NoiTru_KhamBenh>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_KhamBenh> result = new List<NoiTru_KhamBenh>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.BenhAn_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_KhamBenh>();
            }
            return result;
        }
    }
}

