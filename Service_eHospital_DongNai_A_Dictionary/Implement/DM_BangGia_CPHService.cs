namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BangGia_CPHService : BaseService<DM_BangGia_CPH, IDM_BangGia_CPHRepository>
    , IDM_BangGia_CPHService
    {
        private readonly IDM_BangGia_CPHRepository _DM_BangGia_CPHRepository;
        public DM_BangGia_CPHService(IDM_BangGia_CPHRepository DM_BangGia_CPHRepository) : base(DM_BangGia_CPHRepository)
        {
            _DM_BangGia_CPHRepository = DM_BangGia_CPHRepository;
        }
        public virtual async Task<DM_BangGia_CPH> GetByBangGia_CPH_IdAsync(int BangGia_CPH_Id)
        {
            DM_BangGia_CPH result = new DM_BangGia_CPH();
            result = await GetByCondition(item => item.BangGia_CPH_Id == BangGia_CPH_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new DM_BangGia_CPH();
            }
            return result;
        }
    }
}

