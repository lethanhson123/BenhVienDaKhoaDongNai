namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnChiTietService : BaseService<BenhAnChiTiet, IBenhAnChiTietRepository>
    , IBenhAnChiTietService
    {
        private readonly IBenhAnChiTietRepository _BenhAnChiTietRepository;
        public BenhAnChiTietService(IBenhAnChiTietRepository BenhAnChiTietRepository) : base(BenhAnChiTietRepository)
        {
            _BenhAnChiTietRepository = BenhAnChiTietRepository;
        }
        public virtual async Task<List<BenhAnChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<BenhAnChiTiet> result = new List<BenhAnChiTiet>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.BenhAn_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<BenhAnChiTiet>();
            }
            return result;
        }
    }
}

