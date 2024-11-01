namespace Service.Implement
{
    public class DuAnQuyetToanPhanKyService : BaseService<DuAnQuyetToanPhanKy, IDuAnQuyetToanPhanKyRepository>
    , IDuAnQuyetToanPhanKyService
    {
        private readonly IDuAnQuyetToanPhanKyRepository _DuAnQuyetToanPhanKyRepository;
        public DuAnQuyetToanPhanKyService(IDuAnQuyetToanPhanKyRepository DuAnQuyetToanPhanKyRepository) : base(DuAnQuyetToanPhanKyRepository)
        {
            _DuAnQuyetToanPhanKyRepository = DuAnQuyetToanPhanKyRepository;
        }
        public virtual async Task<List<DuAnQuyetToanPhanKy>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh)
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            try
            {
                if (!string.IsNullOrEmpty(SoQuyetDinh))
                {
                    result = await GetByCondition(item => item.DuAnQuyetDinhSoQuyetDinh == SoQuyetDinh).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

