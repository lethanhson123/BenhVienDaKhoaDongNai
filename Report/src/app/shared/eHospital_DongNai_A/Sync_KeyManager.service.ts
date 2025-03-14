import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_KeyManager } from './Sync_KeyManager.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_KeyManagerService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TableName', 'StartValue', 'CurrentValue', 'UpdatedDate'];

    List: Sync_KeyManager[] | undefined;
    ListFilter: Sync_KeyManager[] | undefined;
    FormData!: Sync_KeyManager;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_KeyManager";
    }
}

