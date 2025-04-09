
namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BenhVienService : BaseService<DM_BenhVien, IDM_BenhVienRepository>
    , IDM_BenhVienService
    {
        private readonly IDM_BenhVienRepository _DM_BenhVienRepository;
        public DM_BenhVienService(IDM_BenhVienRepository DM_BenhVienRepository) : base(DM_BenhVienRepository)
        {
            _DM_BenhVienRepository = DM_BenhVienRepository;
        }
        public override void Initialization(DM_BenhVien model)
        {
            BaseInitialization(model);
            if (string.IsNullOrEmpty(model.TenBenhVien_En))
            {
                model.TenBenhVien_En = model.MaBenhVien;
            }
            if (string.IsNullOrEmpty(model.TenBenhVien_Ru))
            {
                model.TenBenhVien_Ru = GlobalHelper.SetName(model.TenBenhVien);
            }
            if (model.TamNgung == null)
            {
                model.TamNgung = false;
            }
        }
        public override async Task<DM_BenhVien> SaveAsync(DM_BenhVien model)
        {
            if (model.BenhVien_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
        public override async Task<List<DM_BenhVien>> GetBySearchStringToListAsync(string searchString)
        {
            List<DM_BenhVien> result = new List<DM_BenhVien>();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
                result = await GetByCondition(item => item.MaBenhVien.Contains(searchString) || item.TenBenhVien.Contains(searchString)).ToListAsync();
            }
            else
            {
                result = await GetByCondition(item => 1 == 1).Take(19).ToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_BenhVien>();
            }
            return result;
        }
        public override async Task<List<DM_BenhVien>> GetBySearchStringAndEmptyToListAsync(string SearchString)
        {
            List<DM_BenhVien> result = new List<DM_BenhVien>();
            try
            {
                DM_BenhVien empty = new DM_BenhVien();
                result.Add(empty);
                List<DM_BenhVien> list = await GetBySearchStringToListAsync(SearchString);
                if (list.Count > 0)
                {
                    result.AddRange(list);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }
    }
}

