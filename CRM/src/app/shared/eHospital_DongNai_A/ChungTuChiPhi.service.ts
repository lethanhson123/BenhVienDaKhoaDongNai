import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTuChiPhi } from './ChungTuChiPhi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTuChiPhiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChungTuChiPhi_Id', 'ChungTu_Id', 'LoaiPhi_Id', 'NgayHoaDon', 'SoSeri', 'SoHoaDon', 'Tyle', 'GiaTri', 'TienTe_Id', 'TyGia', 'GiaTriVND', 'GhiChu', 'KhachHang_Id', 'TyLeVAT', 'GiaTriVAT', 'GiaTriSauVAT'];

    List: ChungTuChiPhi[] | undefined;
    ListFilter: ChungTuChiPhi[] | undefined;
    FormData!: ChungTuChiPhi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTuChiPhi";
    }

    
}

