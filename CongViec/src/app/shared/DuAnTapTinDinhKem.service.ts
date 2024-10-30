import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnTapTinDinhKem } from 'src/app/shared/DuAnTapTinDinhKem.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnTapTinDinhKemService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'Name', 'FileName', 'Save'];
    List: DuAnTapTinDinhKem[] | undefined;
    ListFilter: DuAnTapTinDinhKem[] | undefined;
    FormData!: DuAnTapTinDinhKem;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnTapTinDinhKem";
    }
}

