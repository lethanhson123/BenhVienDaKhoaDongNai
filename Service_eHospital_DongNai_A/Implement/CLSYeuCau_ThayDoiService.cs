namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCau_ThayDoiService : BaseService<CLSYeuCau_ThayDoi, ICLSYeuCau_ThayDoiRepository>
    , ICLSYeuCau_ThayDoiService
    {
        private readonly ICLSYeuCau_ThayDoiRepository _CLSYeuCau_ThayDoiRepository;
        public CLSYeuCau_ThayDoiService(ICLSYeuCau_ThayDoiRepository CLSYeuCau_ThayDoiRepository) : base(CLSYeuCau_ThayDoiRepository)
        {
            _CLSYeuCau_ThayDoiRepository = CLSYeuCau_ThayDoiRepository;
        }
        public virtual async Task<List<CLSYeuCau_ThayDoi>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSYeuCau_ThayDoi> result = new List<CLSYeuCau_ThayDoi>();
            try
            {
                if (ListID.Count > 0)
                {
                    result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSYeuCau_Id.Value)).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }            
            if (result == null)
            {
                result = new List<CLSYeuCau_ThayDoi>();
            }
            return result;
        }
    }
}

