﻿namespace Service.Implement
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
        public virtual async Task<List<DuAnQuyetToanLuyKe>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
            if (ParentID>0)
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ParentID",ParentID),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnQuyetToanLuyKeSelectItemsByParentID", parameters);
            }
            return result;
        }
        public virtual async Task<List<DuAnQuyetToanLuyKe>> GetSQLBySoQuyetDinhToListAsync(string SoQuyetDinh)
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
            if (!string.IsNullOrEmpty(SoQuyetDinh))
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@SoQuyetDinh",SoQuyetDinh),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnQuyetToanLuyKeSelectItemsBySoQuyetDinh", parameters);
            }
            return result;
        }
        public virtual async Task<List<DuAnQuyetToanLuyKe>> GetSQLByDuAnQuyetDinhIDToListAsync(long DuAnQuyetDinhID)
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
            if (DuAnQuyetDinhID>0)
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@DuAnQuyetDinhID",DuAnQuyetDinhID),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnQuyetToanLuyKeSelectItemsByDuAnQuyetDinhID", parameters);
            }
            return result;
        }
    }
}

