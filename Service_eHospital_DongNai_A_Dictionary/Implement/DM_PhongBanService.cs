namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_PhongBanService : BaseService<DM_PhongBan, IDM_PhongBanRepository>
    , IDM_PhongBanService
    {
        private readonly IDM_PhongBanRepository _DM_PhongBanRepository;
        public DM_PhongBanService(IDM_PhongBanRepository DM_PhongBanRepository) : base(DM_PhongBanRepository)
        {
            _DM_PhongBanRepository = DM_PhongBanRepository;
        }
        public override async Task<DM_PhongBan> SaveAsync(DM_PhongBan model)
        {
            if (model.PhongBan_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
        public virtual async Task<DM_PhongBan> GetByPhongBan_IdAsync(int PhongBan_Id)
        {
            DM_PhongBan result = new DM_PhongBan();
            if (PhongBan_Id > 0)
            {
                result = await GetByCondition(item => item.PhongBan_Id == PhongBan_Id).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new DM_PhongBan();
            }
            return result;
        }
    }
}

