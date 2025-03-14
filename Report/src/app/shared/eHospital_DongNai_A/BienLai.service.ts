import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BienLai } from './BienLai.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BienLaiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BienLai_Id', 'LoaiBienLai_Id', 'LoaiBienLai', 'NgayPhatHanh', 'ThoiGianPhatHanh', 'KyHieu', 'Series', 'Min_Number', 'Max_Number', 'NguoiTao_Id', 'NgayTao', 'Machine_Name'];

    List: BienLai[] | undefined;
    ListFilter: BienLai[] | undefined;
    FormData!: BienLai;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BienLai";
    }
}

