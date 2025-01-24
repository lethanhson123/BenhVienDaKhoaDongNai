import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sync_TransactionData_KeyGeneration } from './Sync_TransactionData_KeyGeneration.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sync_TransactionData_KeyGenerationService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'SiteCode', 'TableName', 'UpdatedDate'];

    List: Sync_TransactionData_KeyGeneration[] | undefined;
    ListFilter: Sync_TransactionData_KeyGeneration[] | undefined;
    FormData!: Sync_TransactionData_KeyGeneration;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sync_TransactionData_KeyGeneration";
    }
}

