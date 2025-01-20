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
        public override void Initialization(DM_BenhNhan_BHYT model)
        {
            BaseInitialization(model);
            if (model.NgayCapNhat == null)
            {
                model.NgayCapNhat = GlobalHelper.InitializationDateTime;
            }
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
        public virtual async Task<List<DM_BenhNhan_BHYT>> GetByBenhNhan_IdToListAsync(int BenhNhan_Id)
        {
            List<DM_BenhNhan_BHYT> result = new List<DM_BenhNhan_BHYT>();
            if (BenhNhan_Id > 0)
            {
                result = await GetByCondition(item => item.BenhNhan_Id == BenhNhan_Id).ToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_BenhNhan_BHYT>();
            }
            return result;
        }
        public virtual async Task<List<DM_BenhNhan_BHYT>> GetByBenhNhan_IdAndEmptyToListAsync(int BenhNhan_Id)
        {
            List<DM_BenhNhan_BHYT> result = new List<DM_BenhNhan_BHYT>();
            DM_BenhNhan_BHYT empty = new DM_BenhNhan_BHYT();
            result.Add(empty);
            List<DM_BenhNhan_BHYT> list = await GetByBenhNhan_IdToListAsync(BenhNhan_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

