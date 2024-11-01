using Service.Interface;

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
        public override async Task<DuAnQuyetToanLuyKe> SaveAsync(DuAnQuyetToanLuyKe model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model.ID > 0)
            {
                result = await UpdateAsync(model);
            }
            else
            {
                result = await AddAsync(model);
            }
            if (result > 0)
            {
                await Sync(model);
            }
            return model;
        }
        private async Task<int> Sync(DuAnQuyetToanLuyKe model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model != null)
            {
                if (model.ID > 0)
                {                    

                    string ResultSync = await _DuAnQuyetToanLuyKeRepository.SyncSQLByIDAsync(model.ID);
                }
            }
            return result;
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

