import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_DieuTriRang } from './BenhAn_DieuTriRang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_DieuTriRangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_DieuTriRang_Id', 'BenhAnNgoaiTru_Id', 'NiemMacMieng', 'Loi_Id', 'Loi', 'CaoRang', 'TuiNhaChu', 'XQuang', 'XetNghiem', 'DinhBenh_Id'];

    List: BenhAn_DieuTriRang[] | undefined;
    ListFilter: BenhAn_DieuTriRang[] | undefined;
    FormData!: BenhAn_DieuTriRang;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_DieuTriRang";
    }
}

