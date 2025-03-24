namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCau_QMSService : BaseService<CLSYeuCau_QMS, ICLSYeuCau_QMSRepository>
    , ICLSYeuCau_QMSService
    {
        private readonly ICLSYeuCau_QMSRepository _CLSYeuCau_QMSRepository;
        public CLSYeuCau_QMSService(ICLSYeuCau_QMSRepository CLSYeuCau_QMSRepository) : base(CLSYeuCau_QMSRepository)
        {
            _CLSYeuCau_QMSRepository = CLSYeuCau_QMSRepository;
        }
        public virtual async Task<List<CLSYeuCau_QMS>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSYeuCau_QMS> result = new List<CLSYeuCau_QMS>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSYeuCau_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<CLSYeuCau_QMS>();
            }
            return result;
        }
    }
}

