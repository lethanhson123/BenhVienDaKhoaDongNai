using System.Collections.Generic;

namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ToaThuocService : BaseService<KhamBenh_ToaThuoc, IKhamBenh_ToaThuocRepository>
    , IKhamBenh_ToaThuocService
    {
        private readonly IKhamBenh_ToaThuocRepository _KhamBenh_ToaThuocRepository;

        private readonly IKhamBenhService _KhamBenhService;
        public KhamBenh_ToaThuocService(IKhamBenh_ToaThuocRepository KhamBenh_ToaThuocRepository, IKhamBenhService KhamBenhService) : base(KhamBenh_ToaThuocRepository)
        {
            _KhamBenh_ToaThuocRepository = KhamBenh_ToaThuocRepository;
            _KhamBenhService = KhamBenhService;
        }
        public virtual async Task<KhamBenh_ToaThuoc> GetByKhamBenh_ToaThuoc_IdAsync(int KhamBenh_ToaThuoc_Id)
        {
            KhamBenh_ToaThuoc result = new KhamBenh_ToaThuoc();
            result = await GetByCondition(item => item.KhamBenh_ToaThuoc_Id == KhamBenh_ToaThuoc_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new KhamBenh_ToaThuoc();
            }
            return result;
        }
        public override async Task<List<KhamBenh_ToaThuoc>> GetBySearchStringToListAsync(string searchString)
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.KhamBenh_ToaThuoc_Id.Value.ToString() == searchString).ToListAsync();
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.SoThuTuToa.Trim().Contains(searchString)).ToListAsync();
                    }
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        List<KhamBenh> ListKhamBenh = await _KhamBenhService.GetBySearchStringToListAsync(searchString);
                        List<int?> ListID = ListKhamBenh.Select(item => item.KhamBenh_Id).ToList();
                        result = await GetByCondition(item => EF.Constant(ListID).Contains(item.KhamBenh_Id.Value)).ToListAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<KhamBenh_ToaThuoc>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_ToaThuoc>> GetByNgayToaThuocToListAsync(DateTime NgayToaThuoc)
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
            result = await GetByCondition(item => item.NgayToaThuoc.Value.Year == NgayToaThuoc.Year && item.NgayToaThuoc.Value.Month == NgayToaThuoc.Month && item.NgayToaThuoc.Value.Day == NgayToaThuoc.Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh_ToaThuoc>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_ToaThuoc>> GetByNgayToaThuoc_SearchStringToListAsync(DateTime NgayToaThuoc, string SearchString)
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByNgayToaThuocToListAsync(NgayToaThuoc);
            }
            if (result == null)
            {
                result = new List<KhamBenh_ToaThuoc>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_ToaThuoc>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day)
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
            result = await GetByCondition(item => item.NgayToaThuoc.Value.Year == Year && item.NgayToaThuoc.Value.Month == Month && item.NgayToaThuoc.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<KhamBenh_ToaThuoc>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_ToaThuoc>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString)
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
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
                result = new List<KhamBenh_ToaThuoc>();
            }
            return result;
        }
        public virtual async Task<List<KhamBenh_ToaThuoc>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.KhamBenh_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<KhamBenh_ToaThuoc>();
            }
            return result;
        }
    }
}

