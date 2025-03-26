namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaChiTietService : BaseService<CLSKetQuaChiTiet, ICLSKetQuaChiTietRepository>
    , ICLSKetQuaChiTietService
    {
        private readonly ICLSKetQuaChiTietRepository _CLSKetQuaChiTietRepository;
        public CLSKetQuaChiTietService(ICLSKetQuaChiTietRepository CLSKetQuaChiTietRepository) : base(CLSKetQuaChiTietRepository)
        {
            _CLSKetQuaChiTietRepository = CLSKetQuaChiTietRepository;
        }
        public virtual async Task<List<CLSKetQuaChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQuaChiTiet> result = new List<CLSKetQuaChiTiet>();
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
                result = new List<CLSKetQuaChiTiet>();
            }
            return result;
        }
    }
}

