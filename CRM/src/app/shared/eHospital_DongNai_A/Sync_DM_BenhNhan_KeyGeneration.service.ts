import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_DM_BenhNhan_KeyGeneration } from './Sync_DM_BenhNhan_KeyGeneration.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_DM_BenhNhan_KeyGenerationService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'SiteCode', 'TableName', 'UpdatedDate'];

    List: Sync_DM_BenhNhan_KeyGeneration[] | undefined;
    ListFilter: Sync_DM_BenhNhan_KeyGeneration[] | undefined;
    FormData!: Sync_DM_BenhNhan_KeyGeneration;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_DM_BenhNhan_KeyGeneration";
    }
}

