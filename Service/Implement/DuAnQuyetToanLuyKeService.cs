namespace Service.Implement
{
    public class DuAnQuyetToanLuyKeService : BaseService<DuAnQuyetToanLuyKe, IDuAnQuyetToanLuyKeRepository>
    , IDuAnQuyetToanLuyKeService
    {
        private readonly IDuAnQuyetToanLuyKeRepository _DuAnQuyetToanLuyKeRepository;
        public DuAnQuyetToanLuyKeService(IDuAnQuyetToanLuyKeRepository DuAnQuyetToanLuyKeRepository) : base(DuAnQuyetToanLuyKeRepository)
        {
            _DuAnQuyetToanLuyKeRepository = DuAnQuyetToanLuyKeRepository;
        }
        public virtual async Task<List<DuAnQuyetToanLuyKe>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh)
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
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

