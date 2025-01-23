namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_GroupCommandsService : IBaseService<Sys_GroupCommands>
    {
        Task<List<Sys_GroupCommands>> GetByGroup_IdAndEmptyToListAsync(int Group_Id);
    }
}

