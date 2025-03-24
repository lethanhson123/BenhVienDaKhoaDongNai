namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaService : BaseService<CLSKetQua, ICLSKetQuaRepository>
    , ICLSKetQuaService
    {
        private readonly ICLSKetQuaRepository _CLSKetQuaRepository;
        public CLSKetQuaService(ICLSKetQuaRepository CLSKetQuaRepository) : base(CLSKetQuaRepository)
        {
            _CLSKetQuaRepository = CLSKetQuaRepository;
        }
        public virtual async Task<List<CLSKetQua>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQua> result = new List<CLSKetQua>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSYeuCau_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<CLSKetQua>();
            }
            return result;
        }
    }
}

