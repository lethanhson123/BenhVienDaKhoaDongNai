import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BHYT_KiemTra } from './BHYT_KiemTra.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BHYT_KiemTraService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ma_the', 'ho_ten', 'ngay_vao', 'ngay_ra'];

    List: BHYT_KiemTra[] | undefined;
    ListFilter: BHYT_KiemTra[] | undefined;
    FormData!: BHYT_KiemTra;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BHYT_KiemTra";
    }
}

