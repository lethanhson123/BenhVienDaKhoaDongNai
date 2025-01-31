namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DichVuService : BaseService<DM_DichVu, IDM_DichVuRepository>
    , IDM_DichVuService
    {
        private readonly IDM_DichVuRepository _DM_DichVuRepository;
        public DM_DichVuService(IDM_DichVuRepository DM_DichVuRepository) : base(DM_DichVuRepository)
        {
            _DM_DichVuRepository = DM_DichVuRepository;
        }
        public virtual async Task<List<DM_DichVu>> GetByNhomDichVu_IdToListAsync(int NhomDichVu_Id)
        {
            List<DM_DichVu> result = new List<DM_DichVu>();
            if (NhomDichVu_Id > 0)
            {
                result = await GetByCondition(item => item.NhomDichVu_Id == NhomDichVu_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_DichVu>();
            }
            return result;
        }
        public virtual async Task<List<DM_DichVu>> GetByNhomDichVu_IdAndEmptyToListAsync(int NhomDichVu_Id)
        {
            List<DM_DichVu> result = new List<DM_DichVu>();
            DM_DichVu empty = new DM_DichVu();
            result.Add(empty);
            List<DM_DichVu> list = await GetByNhomDichVu_IdToListAsync(NhomDichVu_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

