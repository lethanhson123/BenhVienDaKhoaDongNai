
using System.Collections.Generic;
using System.Linq;

namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnService : BaseService<BenhAn, IBenhAnRepository>
    , IBenhAnService
    {
        private readonly IBenhAnRepository _BenhAnRepository;
        private readonly IDM_BenhNhanService _DM_BenhNhanService;
        public BenhAnService(IBenhAnRepository BenhAnRepository

            , IDM_BenhNhanService dM_BenhNhanService

        ) : base(BenhAnRepository)
        {
            _BenhAnRepository = BenhAnRepository;
            _DM_BenhNhanService = dM_BenhNhanService;
        }
        public virtual async Task<BenhAn> GetByBenhAn_IdAsync(int BenhAn_Id)
        {
            BenhAn result = new BenhAn();
            result = await GetByCondition(item => item.BenhAn_Id == BenhAn_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new BenhAn();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByBenhAn_IdToListAsync(int BenhAn_Id)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.BenhAn_Id == BenhAn_Id).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<BenhAn> GetBySearchStringAsync(string SearchString)
        {
            BenhAn result = new BenhAn();
            if (!string.IsNullOrEmpty(SearchString))
            {
                SearchString = SearchString.Trim();
                result = await GetByCondition(item => item.SoBenhAn.Trim() == SearchString).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = await GetByCondition(item => item.SoLuuTru.Trim() == SearchString).FirstOrDefaultAsync();
                }
            }
            if (result == null)
            {
                result = new BenhAn();
            }
            return result;
        }
        public override async Task<List<BenhAn>> GetBySearchStringToListAsync(string searchString)
        {
            List<BenhAn> result = new List<BenhAn>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.BenhAn_Id.Value.ToString() == searchString).ToListAsync();
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.SoBenhAn.Trim().Contains(searchString)).ToListAsync();
                    }
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.SoLuuTru.Trim() == searchString).ToListAsync();
                    }
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
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByNgayVaoVienToListAsync(DateTime NgayVaoVien)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.NgayVaoVien.Value.Year == NgayVaoVien.Year && item.NgayVaoVien.Value.Month == NgayVaoVien.Month && item.NgayVaoVien.Value.Day == NgayVaoVien.Day).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByKhoaVao_IdToListAsync(int PhongBan_Id)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.KhoaVao_Id == PhongBan_Id).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByNgayVaoVien_SearchStringToListAsync(DateTime NgayVaoVien, string SearchString)
        {
            List<BenhAn> result = new List<BenhAn>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByNgayVaoVienToListAsync(NgayVaoVien);
            }
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.NgayVaoVien.Value.Year == Year && item.NgayVaoVien.Value.Month == Month && item.NgayVaoVien.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString)
        {
            List<BenhAn> result = new List<BenhAn>();
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
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.BenhNhan_Id == BenhNhan_Id && item.NgayVaoVien.Value.Year == Year && item.NgayVaoVien.Value.Month == Month && item.NgayVaoVien.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
    }
}

