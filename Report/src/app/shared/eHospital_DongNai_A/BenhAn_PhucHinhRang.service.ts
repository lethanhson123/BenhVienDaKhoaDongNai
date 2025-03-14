import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_PhucHinhRang } from './BenhAn_PhucHinhRang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_PhucHinhRangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_PhucHinhRang_Id', 'BenhAnNgoaiTru_Id', 'TieuPhau_Id', 'DieuTriRang_Id', 'XQuang_Id', 'HuongPhucHinh'];

    List: BenhAn_PhucHinhRang[] | undefined;
    ListFilter: BenhAn_PhucHinhRang[] | undefined;
    FormData!: BenhAn_PhucHinhRang;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_PhucHinhRang";
    }
}

