﻿namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_DM_BenhNhan_KeyGenerationRepository : BaseRepository<Sync_DM_BenhNhan_KeyGeneration>
    , ISync_DM_BenhNhan_KeyGenerationRepository
    {
    private readonly Context _context;
    public Sync_DM_BenhNhan_KeyGenerationRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

