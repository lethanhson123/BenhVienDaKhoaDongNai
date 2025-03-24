namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_SieuAmTimService : BaseService<CLSKetQua_SieuAmTim, ICLSKetQua_SieuAmTimRepository>
    , ICLSKetQua_SieuAmTimService
    {
        private readonly ICLSKetQua_SieuAmTimRepository _CLSKetQua_SieuAmTimRepository;
        public CLSKetQua_SieuAmTimService(ICLSKetQua_SieuAmTimRepository CLSKetQua_SieuAmTimRepository) : base(CLSKetQua_SieuAmTimRepository)
        {
            _CLSKetQua_SieuAmTimRepository = CLSKetQua_SieuAmTimRepository;
        }
        public virtual async Task<List<CLSKetQua_SieuAmTim>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQua_SieuAmTim> result = new List<CLSKetQua_SieuAmTim>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSKetQua_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<CLSKetQua_SieuAmTim>();
            }
            return result;
        }
    }
}

