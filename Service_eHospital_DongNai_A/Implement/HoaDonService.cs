namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDonService : BaseService<HoaDon, IHoaDonRepository>
    , IHoaDonService
    {
        private readonly IHoaDonRepository _HoaDonRepository;
        public HoaDonService(IHoaDonRepository HoaDonRepository) : base(HoaDonRepository)
        {
            _HoaDonRepository = HoaDonRepository;
        }
        public virtual async Task<List<HoaDon>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day)
        {
            List<HoaDon> result = new List<HoaDon>();
            result = await GetByCondition(item => item.BenhNhan_Id == BenhNhan_Id && item.NgayHoaDon.Value.Year == Year && item.NgayHoaDon.Value.Month == Month && item.NgayHoaDon.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<HoaDon>();
            }
            return result;
        }
    }
}

