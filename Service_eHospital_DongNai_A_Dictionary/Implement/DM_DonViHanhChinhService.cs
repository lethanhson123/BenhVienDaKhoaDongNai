namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DonViHanhChinhService : BaseService<DM_DonViHanhChinh, IDM_DonViHanhChinhRepository>
    , IDM_DonViHanhChinhService
    {
        private readonly IDM_DonViHanhChinhRepository _DM_DonViHanhChinhRepository;
        public DM_DonViHanhChinhService(IDM_DonViHanhChinhRepository DM_DonViHanhChinhRepository) : base(DM_DonViHanhChinhRepository)
        {
            _DM_DonViHanhChinhRepository = DM_DonViHanhChinhRepository;
        }
        public override async Task<DM_DonViHanhChinh> SaveAsync(DM_DonViHanhChinh model)
        {
            if (model.DonViHanhChinh_Id > 0)
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

