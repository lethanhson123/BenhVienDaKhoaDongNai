namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICDService : BaseService<DM_ICD, IDM_ICDRepository>
    , IDM_ICDService
    {
        private readonly IDM_ICDRepository _DM_ICDRepository;
        public DM_ICDService(IDM_ICDRepository DM_ICDRepository) : base(DM_ICDRepository)
        {
            _DM_ICDRepository = DM_ICDRepository;
        }
        public override async Task<List<DM_ICD>> GetBySearchStringToListAsync(string searchString)
        {
            List<DM_ICD> result = new List<DM_ICD>();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
                result = await GetByCondition(item => item.MaICD.Contains(searchString)).ToListAsync();
                if (result == null)
                {
                    result = await GetByCondition(item => item.TenICD.Contains(searchString)).ToListAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.TenICD_En.Contains(searchString)).ToListAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.MucICD.Contains(searchString)).ToListAsync();
                }
            }
            else
            {
                result = await GetByCondition(item => 1 == 1).Take(19).ToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_ICD>();
            }
            return result;
        }
        public virtual async Task<List<DM_ICD>> GetByICD_Nhom_IdToListAsync(int ICD_Nhom_Id)
        {
            List<DM_ICD> result = new List<DM_ICD>();
            if (ICD_Nhom_Id > 0)
            {
                result = await GetByCondition(item => item.ICD_Nhom_Id == ICD_Nhom_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_ICD>();
            }
            return result;
        }
        public virtual async Task<List<DM_ICD>> GetByICD_Nhom_IdAndEmptyToListAsync(int ICD_Nhom_Id)
        {
            List<DM_ICD> result = new List<DM_ICD>();
            DM_ICD empty = new DM_ICD();
            result.Add(empty);
            List<DM_ICD> list = await GetByICD_Nhom_IdToListAsync(ICD_Nhom_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
        public virtual async Task<List<DM_ICD>> GetByICD_Nhom_Id_SearchStringAndEmptyToListAsync(int ICD_Nhom_Id, string SearchString)
        {
            List<DM_ICD> result = new List<DM_ICD>();
            DM_ICD empty = new DM_ICD();
            result.Add(empty);
            List<DM_ICD> list = new List<DM_ICD>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                list = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                list = await GetByICD_Nhom_IdToListAsync(ICD_Nhom_Id);
            }
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

