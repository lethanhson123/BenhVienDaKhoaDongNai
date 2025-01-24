import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BHYT_Export_His } from './BHYT_Export_His.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BHYT_Export_HisService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id_BHYT_His', 'MaFile', 'IsDelete', 'IsUpdate', 'NgayXuat', 'NgayXoa', 'NgayUpdate'];

    List: BHYT_Export_His[] | undefined;
    ListFilter: BHYT_Export_His[] | undefined;
    FormData!: BHYT_Export_His;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BHYT_Export_His";
    }
}

