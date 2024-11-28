import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucBieuMau } from 'src/app/shared/DanhMucBieuMau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucBieuMauService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'Name', 'HeSo', 'SortOrder', 'Active', 'Save'];
    DisplayColumns002: string[] = ['STT', 'Name', 'HeSo', 'SortOrder', 'IsTamUng', 'Active', 'Save'];
    List: DanhMucBieuMau[] | undefined;
    ListFilter: DanhMucBieuMau[] | undefined;    
    FormData!: DanhMucBieuMau;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucBieuMau";
    }
}

