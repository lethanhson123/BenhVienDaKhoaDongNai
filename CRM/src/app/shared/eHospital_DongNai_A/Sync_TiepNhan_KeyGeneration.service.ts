import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_TiepNhan_KeyGeneration } from './Sync_TiepNhan_KeyGeneration.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_TiepNhan_KeyGenerationService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'SiteCode', 'TableName', 'UpdatedDate'];

    List: Sync_TiepNhan_KeyGeneration[] | undefined;
    ListFilter: Sync_TiepNhan_KeyGeneration[] | undefined;
    FormData!: Sync_TiepNhan_KeyGeneration;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_TiepNhan_KeyGeneration";
    }
}

