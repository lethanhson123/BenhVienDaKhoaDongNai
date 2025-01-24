import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_KeyOffline_Backup_040317 } from './Sync_KeyOffline_Backup_040317.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_KeyOffline_Backup_040317Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'IsUpdate', 'TableName', 'UpdatedDate'];

    List: Sync_KeyOffline_Backup_040317[] | undefined;
    ListFilter: Sync_KeyOffline_Backup_040317[] | undefined;
    FormData!: Sync_KeyOffline_Backup_040317;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_KeyOffline_Backup_040317";
    }
}

