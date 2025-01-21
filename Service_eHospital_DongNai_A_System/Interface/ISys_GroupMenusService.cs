namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_GroupMenusService : IBaseService<Sys_GroupMenus>
    {
        Task<List<Sys_GroupMenus>> GetByGroup_IdAndEmptyToListAsync(int Group_Id);
    }
}

