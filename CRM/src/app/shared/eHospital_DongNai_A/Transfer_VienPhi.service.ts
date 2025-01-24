import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Transfer_VienPhi } from './Transfer_VienPhi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Transfer_VienPhiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Transfer_VienPhi_Id', 'IDSession', 'Status', 'NguonBenhNhan', 'BenhNhan_Id', 'MaYTe', 'TenBenhNhan', 'DiaChi', 'NgayChungTu', 'TrangThai', 'SoHoaDon', 'SoSeri', 'TongTien', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'SoChungtuKeToan'];

    List: Transfer_VienPhi[] | undefined;
    ListFilter: Transfer_VienPhi[] | undefined;
    FormData!: Transfer_VienPhi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Transfer_VienPhi";
    }
}

