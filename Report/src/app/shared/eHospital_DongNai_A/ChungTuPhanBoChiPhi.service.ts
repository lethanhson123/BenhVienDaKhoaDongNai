import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTuPhanBoChiPhi } from './ChungTuPhanBoChiPhi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTuPhanBoChiPhiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ChungTuChiPhi_ID', 'Duoc_ID', 'TienTe_Id', 'TyGia', 'GiaTri', 'TyLeVAT', 'GiaTriVAT', 'SoChungTuKeToan'];

    List: ChungTuPhanBoChiPhi[] | undefined;
    ListFilter: ChungTuPhanBoChiPhi[] | undefined;
    FormData!: ChungTuPhanBoChiPhi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTuPhanBoChiPhi";
    }
}

