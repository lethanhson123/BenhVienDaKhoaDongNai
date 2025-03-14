import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_LYDOVANGMAT } from './NS_DM_LYDOVANGMAT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_LYDOVANGMATService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaLyDoVangMat', 'TenLyDoVangMat', 'TruPhep', 'TenTat', 'CoHuongLuong', 'NghiDaiHan', 'BHXHTra', 'SoGio', 'SoNgayNghiToiDa', 'Truc', 'CoPhep', 'LamThem'];

    List: NS_DM_LYDOVANGMAT[] | undefined;
    ListFilter: NS_DM_LYDOVANGMAT[] | undefined;
    FormData!: NS_DM_LYDOVANGMAT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_LYDOVANGMAT";
    }
}

