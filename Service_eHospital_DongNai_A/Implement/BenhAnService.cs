
using System.Collections.Generic;

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
        public override async Task<List<BenhAn>> GetBySearchStringToListAsync(string searchString)
        {
            List<BenhAn> result = new List<BenhAn>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.SoBenhAn.Contains(searchString)).ToListAsync();
                    //if (result.Count == GlobalHelper.InitializationNumber)
                    //{
                    //    result = await GetByCondition(item => item.SoLuuTru.Contains(searchString)).ToListAsync();
                    //}
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        List<DM_BenhNhan> ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.MaYTe.Contains(searchString)).ToListAsync();
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.CMND.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.SoDienThoai.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.SoBHXH.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.TenBenhNhan.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count > 0)
                        {
                            List<int> ListDM_BenhNhanID = ListDM_BenhNhan.Select(item => item.BenhNhan_Id).ToList();
                            foreach (var ID in ListDM_BenhNhanID)
                            {
                                try
                                {
                                    BenhAn BenhAn = await GetByCondition(item => item.BenhNhan_Id == ID).FirstOrDefaultAsync();
                                    if (BenhAn.BenhAn_Id != null)
                                    {
                                        if (BenhAn.BenhAn_Id > 0)
                                        {
                                            result.Add(BenhAn);
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
    }
}

