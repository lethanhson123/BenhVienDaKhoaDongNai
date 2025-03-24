namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCau_PACSService : BaseService<CLSYeuCau_PACS, ICLSYeuCau_PACSRepository>
    , ICLSYeuCau_PACSService
    {
        private readonly ICLSYeuCau_PACSRepository _CLSYeuCau_PACSRepository;
        public CLSYeuCau_PACSService(ICLSYeuCau_PACSRepository CLSYeuCau_PACSRepository) : base(CLSYeuCau_PACSRepository)
        {
            _CLSYeuCau_PACSRepository = CLSYeuCau_PACSRepository;
        }
        public virtual async Task<List<CLSYeuCau_PACS>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSYeuCau_PACS> result = new List<CLSYeuCau_PACS>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSYeuCau_ID.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<CLSYeuCau_PACS>();
            }
            return result;
        }
    }
}

