namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_XQService : BaseService<CLSKetQua_XQ, ICLSKetQua_XQRepository>
    , ICLSKetQua_XQService
    {
        private readonly ICLSKetQua_XQRepository _CLSKetQua_XQRepository;
        public CLSKetQua_XQService(ICLSKetQua_XQRepository CLSKetQua_XQRepository) : base(CLSKetQua_XQRepository)
        {
            _CLSKetQua_XQRepository = CLSKetQua_XQRepository;
        }
        public virtual async Task<List<CLSKetQua_XQ>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQua_XQ> result = new List<CLSKetQua_XQ>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSYeuCau_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<CLSKetQua_XQ>();
            }
            return result;
        }
    }
}

