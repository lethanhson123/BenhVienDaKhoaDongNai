import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_KeyOffline } from './Sync_KeyOffline.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_KeyOfflineService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'IsUpdate', 'TableName', 'UpdatedDate'];

    List: Sync_KeyOffline[] | undefined;
    ListFilter: Sync_KeyOffline[] | undefined;
    FormData!: Sync_KeyOffline;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_KeyOffline";
    }
}

