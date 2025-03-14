import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NoiTru_ChamSoc } from './NoiTru_ChamSoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NoiTru_ChamSocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NoiTru_ChamSoc_Id', 'BenhAn_Id', 'LuuTru_Id', 'NgayThucHien', 'ThoiGianThucHien', 'NguoiThucHien_Id', 'Mach', 'NhietDo', 'HuyetApThap', 'HuyetApCao', 'CanNang', 'NhipTho', 'NuocTieu', 'Phan', 'DienBenh', 'YLenhChamSoc', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Uong', 'An', 'TiemTruyen', 'TruyenMau', 'Non', 'DanLuu', 'DoiTuong_Id', 'DichDanLuu1', 'DichDanLuu2', 'GhiChu'];

    List: NoiTru_ChamSoc[] | undefined;
    ListFilter: NoiTru_ChamSoc[] | undefined;
    FormData!: NoiTru_ChamSoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NoiTru_ChamSoc";
    }
}

