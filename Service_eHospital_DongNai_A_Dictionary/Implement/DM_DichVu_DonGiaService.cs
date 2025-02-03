namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DichVu_DonGiaService : BaseService<DM_DichVu_DonGia, IDM_DichVu_DonGiaRepository>
    , IDM_DichVu_DonGiaService
    {
        private readonly IDM_DichVu_DonGiaRepository _DM_DichVu_DonGiaRepository;
        public DM_DichVu_DonGiaService(IDM_DichVu_DonGiaRepository DM_DichVu_DonGiaRepository) : base(DM_DichVu_DonGiaRepository)
        {
            _DM_DichVu_DonGiaRepository = DM_DichVu_DonGiaRepository;
        }
        public virtual async Task<List<DM_DichVu_DonGia>> GetByBangGia_IdToListAsync(int BangGia_Id)
        {
            List<DM_DichVu_DonGia> result = new List<DM_DichVu_DonGia>();
            result = await GetByCondition(item => item.BangGia_Id == BangGia_Id).ToListAsync();
            if (result == null)
            {
                result = new List<DM_DichVu_DonGia>();
            }
            return result;
        }
        public virtual async Task<List<DM_DichVu_DonGia>> GetByBangGia_IdAndEmptyToListAsync(int BangGia_Id)
        {
            List<DM_DichVu_DonGia> result = new List<DM_DichVu_DonGia>();
            DM_DichVu_DonGia empty = new DM_DichVu_DonGia();
            result.Add(empty);
            List<DM_DichVu_DonGia> list = await GetByBangGia_IdToListAsync(BangGia_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

