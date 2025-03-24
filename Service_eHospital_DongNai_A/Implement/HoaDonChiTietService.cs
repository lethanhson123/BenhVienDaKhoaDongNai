namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDonChiTietService : BaseService<HoaDonChiTiet, IHoaDonChiTietRepository>
    , IHoaDonChiTietService
    {
        private readonly IHoaDonChiTietRepository _HoaDonChiTietRepository;
        public HoaDonChiTietService(IHoaDonChiTietRepository HoaDonChiTietRepository) : base(HoaDonChiTietRepository)
        {
            _HoaDonChiTietRepository = HoaDonChiTietRepository;
        }
        public virtual async Task<List<HoaDonChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<HoaDonChiTiet> result = new List<HoaDonChiTiet>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.HoaDon_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<HoaDonChiTiet>();
            }
            return result;
        }
    }
}

