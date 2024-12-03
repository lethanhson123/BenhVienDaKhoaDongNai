namespace Service.Implement
{
    public class DanhMucDichVuService : BaseService<DanhMucDichVu, IDanhMucDichVuRepository>
    , IDanhMucDichVuService
    {
        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;
        public DanhMucDichVuService(IDanhMucDichVuRepository DanhMucDichVuRepository) : base(DanhMucDichVuRepository)
        {
            _DanhMucDichVuRepository = DanhMucDichVuRepository;
        }
        public virtual async Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync(bool IsBHYT)
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                result = await GetByCondition(item => item.IsBHYT == IsBHYT).ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new List<DanhMucDichVu>();
            }
            return result;
        }
    }
}

