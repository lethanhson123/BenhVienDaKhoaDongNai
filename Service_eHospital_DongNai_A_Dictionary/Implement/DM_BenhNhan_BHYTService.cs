namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BenhNhan_BHYTService : BaseService<DM_BenhNhan_BHYT, IDM_BenhNhan_BHYTRepository>
    , IDM_BenhNhan_BHYTService
    {
        private readonly IDM_BenhNhan_BHYTRepository _DM_BenhNhan_BHYTRepository;
        public DM_BenhNhan_BHYTService(IDM_BenhNhan_BHYTRepository DM_BenhNhan_BHYTRepository) : base(DM_BenhNhan_BHYTRepository)
        {
            _DM_BenhNhan_BHYTRepository = DM_BenhNhan_BHYTRepository;
        }
        public override async Task<DM_BenhNhan_BHYT> SaveAsync(DM_BenhNhan_BHYT model)
        {
            if (model.BenhNhan_BHYT_Id > 0)
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

