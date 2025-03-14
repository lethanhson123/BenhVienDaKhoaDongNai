import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_DieuTri } from './BenhAn_DieuTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_DieuTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_DieuTri_Id', 'BenhAnNgoaiTru_Id', 'NgayDieuTri', 'BacSi_1', 'BacSi_2', 'NoiDung', 'GhiChu'];

    List: BenhAn_DieuTri[] | undefined;
    ListFilter: BenhAn_DieuTri[] | undefined;
    FormData!: BenhAn_DieuTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_DieuTri";
    }
}

