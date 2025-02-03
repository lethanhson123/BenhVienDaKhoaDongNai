namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_BangGia_CPHService : IBaseService<DM_BangGia_CPH>
    {
        Task<DM_BangGia_CPH> GetByBangGia_CPH_IdAsync(int BangGia_Id);
    }
}

