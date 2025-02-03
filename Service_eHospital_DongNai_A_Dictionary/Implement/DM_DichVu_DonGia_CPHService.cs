namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DichVu_DonGia_CPHService : BaseService<DM_DichVu_DonGia_CPH, IDM_DichVu_DonGia_CPHRepository>
    , IDM_DichVu_DonGia_CPHService
    {
        private readonly IDM_DichVu_DonGia_CPHRepository _DM_DichVu_DonGia_CPHRepository;
        public DM_DichVu_DonGia_CPHService(IDM_DichVu_DonGia_CPHRepository DM_DichVu_DonGia_CPHRepository) : base(DM_DichVu_DonGia_CPHRepository)
        {
            _DM_DichVu_DonGia_CPHRepository = DM_DichVu_DonGia_CPHRepository;
        }
        public virtual async Task<List<DM_DichVu_DonGia_CPH>> GetByBangGia_CPH_IdToListAsync(int BangGia_CPH_Id)
        {
            List<DM_DichVu_DonGia_CPH> result = new List<DM_DichVu_DonGia_CPH>();
            result = await GetByCondition(item => item.BangGia_CPH_Id == BangGia_CPH_Id).ToListAsync();
            if (result == null)
            {
                result = new List<DM_DichVu_DonGia_CPH>();
            }
            return result;
        }
        public virtual async Task<List<DM_DichVu_DonGia_CPH>> GetByBangGia_CPH_IdAndEmptyToListAsync(int BangGia_CPH_Id)
        {
            List<DM_DichVu_DonGia_CPH> result = new List<DM_DichVu_DonGia_CPH>();
            DM_DichVu_DonGia_CPH empty = new DM_DichVu_DonGia_CPH();
            result.Add(empty);
            List<DM_DichVu_DonGia_CPH> list = await GetByBangGia_CPH_IdToListAsync(BangGia_CPH_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

