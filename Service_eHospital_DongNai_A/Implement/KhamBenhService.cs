﻿namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenhService : BaseService<KhamBenh, IKhamBenhRepository>
    , IKhamBenhService
    {
        private readonly IKhamBenhRepository _KhamBenhRepository;
        private readonly IDM_BenhNhanService _DM_BenhNhanService;
        public KhamBenhService(IKhamBenhRepository KhamBenhRepository, IDM_BenhNhanService dM_BenhNhanService) : base(KhamBenhRepository)
        {
            _KhamBenhRepository = KhamBenhRepository;
            _DM_BenhNhanService = dM_BenhNhanService;
        }
        public virtual async Task<KhamBenh> GetByKhamBenh_IdAsync(int KhamBenh_Id)
        {
            KhamBenh result = new KhamBenh();
            result = await GetByCondition(item => item.KhamBenh_Id == KhamBenh_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new KhamBenh();
            }
            return result;
        }
        public override async Task<List<KhamBenh>> GetBySearchStringToListAsync(string searchString)
        {
            List<KhamBenh> result = new List<KhamBenh>();
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
                            result = await GetByCondition(item => EF.Constant(ListDM_BenhNhanID).Contains(item.BenhNhan_Id.Value)).ToListAsync();                           
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
                result = new List<KhamBenh>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh>> GetByNgayKhamToListAsync(DateTime NgayKham)
        {
            List<KhamBenh> result = new List<KhamBenh>();
            result = await GetByCondition(item => item.NgayKham.Value.Year == NgayKham.Year && item.NgayKham.Value.Month == NgayKham.Month && item.NgayKham.Value.Day == NgayKham.Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh>> GetByNgayKham_SearchStringToListAsync(DateTime NgayKham, string SearchString)
        {
            List<KhamBenh> result = new List<KhamBenh>();
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
                result = new List<KhamBenh>();
            }
            return result;
        }

        public virtual async Task<List<KhamBenh>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day)
        {
            List<KhamBenh> result = new List<KhamBenh>();
            result = await GetByCondition(item => item.NgayKham.Value.Year == Year && item.NgayKham.Value.Month == Month && item.NgayKham.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString)
        {
            List<KhamBenh> result = new List<KhamBenh>();
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
                result = new List<KhamBenh>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day)
        {
            List<KhamBenh> result = new List<KhamBenh>();
            result = await GetByCondition(item => item.BenhNhan_Id == BenhNhan_Id && item.NgayKham.Value.Year == Year && item.NgayKham.Value.Month == Month && item.NgayKham.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh>();
            }
            return result;
        }
    }
}

