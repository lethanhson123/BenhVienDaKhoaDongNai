namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_DienCoService : BaseService<CLSKetQua_DienCo, ICLSKetQua_DienCoRepository>
    , ICLSKetQua_DienCoService
    {
        private readonly ICLSKetQua_DienCoRepository _CLSKetQua_DienCoRepository;
        public CLSKetQua_DienCoService(ICLSKetQua_DienCoRepository CLSKetQua_DienCoRepository) : base(CLSKetQua_DienCoRepository)
        {
            _CLSKetQua_DienCoRepository = CLSKetQua_DienCoRepository;
        }
        public virtual async Task<List<CLSKetQua_DienCo>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQua_DienCo> result = new List<CLSKetQua_DienCo>();
            try
            {
                if (ListID.Count > 0)
                {
                    result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSKetQua_Id.Value)).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new List<CLSKetQua_DienCo>();
            }
            return result;
        }
    }
}

