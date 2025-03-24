namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_ToaThuocService : BaseService<NoiTru_ToaThuoc, INoiTru_ToaThuocRepository>
    , INoiTru_ToaThuocService
    {
        private readonly INoiTru_ToaThuocRepository _NoiTru_ToaThuocRepository;
        public NoiTru_ToaThuocService(INoiTru_ToaThuocRepository NoiTru_ToaThuocRepository) : base(NoiTru_ToaThuocRepository)
        {
            _NoiTru_ToaThuocRepository = NoiTru_ToaThuocRepository;
        }
        public virtual async Task<List<NoiTru_ToaThuoc>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_ToaThuoc> result = new List<NoiTru_ToaThuoc>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.KhamBenh_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_ToaThuoc>();
            }
            return result;
        }
    }
}

