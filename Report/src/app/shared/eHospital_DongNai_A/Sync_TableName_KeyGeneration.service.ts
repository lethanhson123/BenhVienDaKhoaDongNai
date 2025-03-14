import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_TableName_KeyGeneration } from './Sync_TableName_KeyGeneration.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_TableName_KeyGenerationService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TableName', 'KeyManage', 'CodeManage'];

    List: Sync_TableName_KeyGeneration[] | undefined;
    ListFilter: Sync_TableName_KeyGeneration[] | undefined;
    FormData!: Sync_TableName_KeyGeneration;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_TableName_KeyGeneration";
    }
}

