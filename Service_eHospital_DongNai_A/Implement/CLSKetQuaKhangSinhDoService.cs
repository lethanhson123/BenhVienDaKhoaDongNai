namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaKhangSinhDoService : BaseService<CLSKetQuaKhangSinhDo, ICLSKetQuaKhangSinhDoRepository>
    , ICLSKetQuaKhangSinhDoService
    {
        private readonly ICLSKetQuaKhangSinhDoRepository _CLSKetQuaKhangSinhDoRepository;
        public CLSKetQuaKhangSinhDoService(ICLSKetQuaKhangSinhDoRepository CLSKetQuaKhangSinhDoRepository) : base(CLSKetQuaKhangSinhDoRepository)
        {
            _CLSKetQuaKhangSinhDoRepository = CLSKetQuaKhangSinhDoRepository;
        }
        public virtual async Task<List<CLSKetQuaKhangSinhDo>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQuaKhangSinhDo> result = new List<CLSKetQuaKhangSinhDo>();
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
                result = new List<CLSKetQuaKhangSinhDo>();
            }
            return result;
        }
    }
}

