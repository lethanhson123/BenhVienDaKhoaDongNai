namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuChiTietService : BaseService<ChungTuChiTiet, IChungTuChiTietRepository>
    , IChungTuChiTietService
    {
        private readonly IChungTuChiTietRepository _ChungTuChiTietRepository;
        public ChungTuChiTietService(IChungTuChiTietRepository ChungTuChiTietRepository) : base(ChungTuChiTietRepository)
        {
            _ChungTuChiTietRepository = ChungTuChiTietRepository;
        }
        public virtual async Task<List<ChungTuChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<ChungTuChiTiet> result = new List<ChungTuChiTiet>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.ChungTu_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<ChungTuChiTiet>();
            }
            return result;
        }
    }
}

