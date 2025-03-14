import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { cus_HDDT } from './cus_HDDT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class cus_HDDTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'VienPhiNoiTru_Id', 'BenhAn_Id', 'HinhThucThanhToan_id', 'GiaTriHoaDon', 'PhatSinh_Ngay', 'PhatSinh_ThoiGian', 'PhatSinh_Noi_id', 'ThuHD_BL', 'DaThanhToan', 'HuyHoaDon', 'HoanTra', 'NgayTao_trg'];

    List: cus_HDDT[] | undefined;
    ListFilter: cus_HDDT[] | undefined;
    FormData!: cus_HDDT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "cus_HDDT";
    }
}

