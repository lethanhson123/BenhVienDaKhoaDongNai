import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_DM_BenhNhan_KeyGeneration_Backup_040317 } from './Sync_DM_BenhNhan_KeyGeneration_Backup_040317.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_DM_BenhNhan_KeyGeneration_Backup_040317Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'SiteCode', 'TableName', 'UpdatedDate'];

    List: Sync_DM_BenhNhan_KeyGeneration_Backup_040317[] | undefined;
    ListFilter: Sync_DM_BenhNhan_KeyGeneration_Backup_040317[] | undefined;
    FormData!: Sync_DM_BenhNhan_KeyGeneration_Backup_040317;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_DM_BenhNhan_KeyGeneration_Backup_040317";
    }
}

