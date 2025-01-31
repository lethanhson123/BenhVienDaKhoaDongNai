namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_KhoDuocService : BaseService<DM_KhoDuoc, IDM_KhoDuocRepository>
    , IDM_KhoDuocService
    {
        private readonly IDM_KhoDuocRepository _DM_KhoDuocRepository;
        public DM_KhoDuocService(IDM_KhoDuocRepository DM_KhoDuocRepository) : base(DM_KhoDuocRepository)
        {
            _DM_KhoDuocRepository = DM_KhoDuocRepository;
        }
        public virtual async Task<List<DM_KhoDuoc>> GetByPhongBan_IdToListAsync(int PhongBan_Id)
        {
            List<DM_KhoDuoc> result = new List<DM_KhoDuoc>();
            if (PhongBan_Id > 0)
            {
                result = await GetByCondition(item => item.PhongBan_Id == PhongBan_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_KhoDuoc>();
            }
            return result;
        }
        public virtual async Task<List<DM_KhoDuoc>> GetByPhongBan_IdAndEmptyToListAsync(int PhongBan_Id)
        {
            List<DM_KhoDuoc> result = new List<DM_KhoDuoc>();
            DM_KhoDuoc empty = new DM_KhoDuoc();
            result.Add(empty);
            List<DM_KhoDuoc> list = await GetByPhongBan_IdToListAsync(PhongBan_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

