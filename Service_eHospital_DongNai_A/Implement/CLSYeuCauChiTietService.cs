namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCauChiTietService : BaseService<CLSYeuCauChiTiet, ICLSYeuCauChiTietRepository>
    , ICLSYeuCauChiTietService
    {
        private readonly ICLSYeuCauChiTietRepository _CLSYeuCauChiTietRepository;
        public CLSYeuCauChiTietService(ICLSYeuCauChiTietRepository CLSYeuCauChiTietRepository) : base(CLSYeuCauChiTietRepository)
        {
            _CLSYeuCauChiTietRepository = CLSYeuCauChiTietRepository;
        }
        public virtual async Task<List<CLSYeuCauChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSYeuCauChiTiet> result = new List<CLSYeuCauChiTiet>();
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
                result = new List<CLSYeuCauChiTiet>();
            }
            return result;
        }
    }
}

