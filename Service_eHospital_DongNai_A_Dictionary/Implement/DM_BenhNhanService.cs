namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BenhNhanService : BaseService<DM_BenhNhan, IDM_BenhNhanRepository>
    , IDM_BenhNhanService
    {
        private readonly IDM_BenhNhanRepository _DM_BenhNhanRepository;
        public DM_BenhNhanService(IDM_BenhNhanRepository DM_BenhNhanRepository) : base(DM_BenhNhanRepository)
        {
            _DM_BenhNhanRepository = DM_BenhNhanRepository;
        }
        public override async Task<DM_BenhNhan> SaveAsync(DM_BenhNhan model)
        {
            if (model.BenhNhan_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
    }
}

