import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { test } from './test.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class testService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Setting_Id', 'Code', 'Language_Id', 'Value', 'Description', 'Locked', 'SystemEditOnly', 'CreationDate', 'CreatedBy', 'LastUpdateDate', 'LastUpdatedBy'];

    List: test[] | undefined;
    ListFilter: test[] | undefined;
    FormData!: test;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "test";
    }
}

