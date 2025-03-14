import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GiaiPhauBenhSinhThiet_KetQua } from './GiaiPhauBenhSinhThiet_KetQua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GiaiPhauBenhSinhThiet_KetQuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GiaiPhauBenhSinhThiet_KetQua_Id', 'GiaiPhauBenhSinhThiet_Id', 'NguoiPhaBenhPham_Id', 'PhaNgay', 'SoManh', 'PhuongPhapNhuom', 'NgayLamXongTieuBan', 'NguoiLamTieuBan_Id', 'NhanXetDaiThe', 'NhanXetViThe', 'ChanDoanGiaiPhauBenh', 'SuPhuHopVoiChanDoanLS', 'BacSiDocKetQua_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'MaLam', 'BacSiCatLoc_Id', 'NgayCatLoc', 'KTVPhu_Id'];

    List: GiaiPhauBenhSinhThiet_KetQua[] | undefined;
    ListFilter: GiaiPhauBenhSinhThiet_KetQua[] | undefined;
    FormData!: GiaiPhauBenhSinhThiet_KetQua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GiaiPhauBenhSinhThiet_KetQua";
    }
}

