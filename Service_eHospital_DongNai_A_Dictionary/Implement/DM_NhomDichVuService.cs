namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_NhomDichVuService : BaseService<DM_NhomDichVu, IDM_NhomDichVuRepository>
    , IDM_NhomDichVuService
    {
        private readonly IDM_NhomDichVuRepository _DM_NhomDichVuRepository;
        public DM_NhomDichVuService(IDM_NhomDichVuRepository DM_NhomDichVuRepository) : base(DM_NhomDichVuRepository)
        {
            _DM_NhomDichVuRepository = DM_NhomDichVuRepository;
        }
        public virtual async Task<List<DM_NhomDichVu>> GetByLoaiDichVu_IdToListAsync(int LoaiDichVu_Id)
        {
            List<DM_NhomDichVu> result = new List<DM_NhomDichVu>();
            if (LoaiDichVu_Id > 0)
            {
                result = await GetByCondition(item => item.LoaiDichVu_Id == LoaiDichVu_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_NhomDichVu>();
            }
            return result;
        }
        public virtual async Task<List<DM_NhomDichVu>> GetByLoaiDichVu_IdAndEmptyToListAsync(int LoaiDichVu_Id)
        {
            List<DM_NhomDichVu> result = new List<DM_NhomDichVu>();
            DM_NhomDichVu empty = new DM_NhomDichVu();
            result.Add(empty);
            List<DM_NhomDichVu> list = await GetByLoaiDichVu_IdToListAsync(LoaiDichVu_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

