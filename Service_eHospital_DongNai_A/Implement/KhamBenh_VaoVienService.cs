namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_VaoVienService : BaseService<KhamBenh_VaoVien, IKhamBenh_VaoVienRepository>
    , IKhamBenh_VaoVienService
    {
        private readonly IKhamBenh_VaoVienRepository _KhamBenh_VaoVienRepository;
        private readonly IDM_BenhNhanService _DM_BenhNhanService;
        public KhamBenh_VaoVienService(IKhamBenh_VaoVienRepository KhamBenh_VaoVienRepository, IDM_BenhNhanService dM_BenhNhanService) : base(KhamBenh_VaoVienRepository)
        {
            _KhamBenh_VaoVienRepository = KhamBenh_VaoVienRepository;
            _DM_BenhNhanService = dM_BenhNhanService;
        }
        public virtual async Task<KhamBenh_VaoVien> GetByKhamBenhVaoVien_IdAsync(int KhamBenhVaoVien_Id)
        {
            KhamBenh_VaoVien result = new KhamBenh_VaoVien();
            result = await GetByCondition(item => item.KhamBenhVaoVien_Id == KhamBenhVaoVien_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new KhamBenh_VaoVien();
            }
            return result;
        }
        public override async Task<List<KhamBenh_VaoVien>> GetBySearchStringToListAsync(string searchString)
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.KhamBenh_Id.Value.ToString() == searchString).ToListAsync();
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        List<DM_BenhNhan> ListDM_BenhNhan = await _DM_BenhNhanService.GetBySearchStringToListAsync(searchString);
                        if (ListDM_BenhNhan.Count > 0)
                        {
                            List<int> ListDM_BenhNhanID = ListDM_BenhNhan.Select(item => item.BenhNhan_Id).ToList();
                            foreach (var ID in ListDM_BenhNhanID)
                            {
                                try
                                {
                                    List<KhamBenh_VaoVien> List = await GetByCondition(item => item.BenhNhan_Id == ID).ToListAsync();
                                    if (List != null)
                                    {
                                        if (List.Count > 0)
                                        {
                                            result.AddRange(List);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    string message = ex.Message;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<KhamBenh_VaoVien>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_VaoVien>> GetByNgayKhamToListAsync(DateTime NgayKham)
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            result = await GetByCondition(item => item.NgayKham.Value.Year == NgayKham.Year && item.NgayKham.Value.Month == NgayKham.Month && item.NgayKham.Value.Day == NgayKham.Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh_VaoVien>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_VaoVien>> GetByNgayKham_SearchStringToListAsync(DateTime NgayKham, string SearchString)
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByNgayKhamToListAsync(NgayKham);
            }
            if (result == null)
            {
                result = new List<KhamBenh_VaoVien>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_VaoVien>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day)
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            result = await GetByCondition(item => item.NgayKham.Value.Year == Year && item.NgayKham.Value.Month == Month && item.NgayKham.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh_VaoVien>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_VaoVien>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString)
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByYear_Month_DayToListAsync(Year, Month, Day);
            }
            if (result == null)
            {
                result = new List<KhamBenh_VaoVien>();
            }
            return result;
        }
    }
}

