namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BangGiaService : BaseService<DM_BangGia, IDM_BangGiaRepository>
    , IDM_BangGiaService
    {
        private readonly IDM_BangGiaRepository _DM_BangGiaRepository;
        public DM_BangGiaService(IDM_BangGiaRepository DM_BangGiaRepository) : base(DM_BangGiaRepository)
        {
            _DM_BangGiaRepository = DM_BangGiaRepository;
        }
        public virtual async Task<DM_BangGia> GetByBangGia_IdAsync(int BangGia_Id)
        {
            DM_BangGia result = new DM_BangGia();
            result = await GetByCondition(item => item.BangGia_Id == BangGia_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new DM_BangGia();
            }
            return result;
        }
    }
}

