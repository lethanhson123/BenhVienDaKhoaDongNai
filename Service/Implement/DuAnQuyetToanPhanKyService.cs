using Data.Model;

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
        public override async Task<DuAnQuyetToanPhanKy> SaveAsync(DuAnQuyetToanPhanKy model)
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
        private async Task<int> Sync(DuAnQuyetToanPhanKy model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model != null)
            {
                if (model.ID > 0)
                {

                    string ResultSync = await _DuAnQuyetToanPhanKyRepository.SyncSQLByIDAsync(model.ID);
                }
            }
            return result;
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
        public virtual async Task<List<DuAnQuyetToanPhanKy>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            if (ParentID>0)
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ParentID",ParentID),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnQuyetToanPhanKySelectItemsByParentID", parameters);
            }
            return result;
        }
        public virtual async Task<List<DuAnQuyetToanPhanKy>> GetSQLBySoQuyetDinhToListAsync(string SoQuyetDinh)
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            if (!string.IsNullOrEmpty(SoQuyetDinh))
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@SoQuyetDinh",SoQuyetDinh),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnQuyetToanPhanKySelectItemsBySoQuyetDinh", parameters);
            }
            return result;
        }
        public virtual async Task<List<DuAnQuyetToanPhanKy>> GetSQLByDuAnQuyetDinhIDToListAsync(long DuAnQuyetDinhID)
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            if (DuAnQuyetDinhID>0)
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@DuAnQuyetDinhID",DuAnQuyetDinhID),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnQuyetToanPhanKySelectItemsByDuAnQuyetDinhID", parameters);
            }
            return result;
        }
    }
}

