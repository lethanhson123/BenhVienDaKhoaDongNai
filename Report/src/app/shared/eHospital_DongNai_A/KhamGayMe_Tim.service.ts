import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamGayMe_Tim } from './KhamGayMe_Tim.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamGayMe_TimService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamGayMe_Tim_Id', 'SoPhieuGayMe', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'CLSYeuCau_Id', 'NgayThucHien', 'ThoiGianThuchien', 'BacSiGayMe_Id', 'ChieuCao', 'CanNang', 'K', 'BH_HT', 'PT', 'Crea', 'aPTT', 'ChanDoan', 'ChupMachVanh', 'TimMach', 'Phoi', 'ThucQuan', 'DaDay', 'TaTrang', 'ThanKinh', 'TietNieu', 'DaiDuong', 'ThuocLa', 'Ruou', 'MaTuy', 'DiUng', 'SAQuaNguc', 'SAQuaThucQuan', 'HepCanh', 'ALĐMPsyst', 'ASA', 'NYHA', 'DieuTriTruocMo', 'Nghe', 'XQPhoi', 'TestAllenPhai', 'TestAllenTrai', 'DienTim', 'TienMe', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TieuCau'];

    List: KhamGayMe_Tim[] | undefined;
    ListFilter: KhamGayMe_Tim[] | undefined;
    FormData!: KhamGayMe_Tim;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamGayMe_Tim";
    }
}

