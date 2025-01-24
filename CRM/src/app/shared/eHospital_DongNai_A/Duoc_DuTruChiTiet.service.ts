import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_DuTruChiTiet } from './Duoc_DuTruChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_DuTruChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuTruChiTiet_Id', 'DuTru_Id', 'Duoc_Id', 'DonViTinh_Id', 'NhaCungCap_Id', 'HeSoNhanHang', 'SoLuongTon', 'SLHangCho', 'UuTien', 'SLXuat1', 'SLXuat2', 'SLXuat3', 'SLXuat4', 'SLTrungBinhXuat', 'SLLyThuyet', 'SLDongGoi', 'SLTron', 'TienTe_Id', 'TyGia', 'DonGia', 'NguyenTe', 'ThanhTien', 'DaPhatSinhPhieuDatHang', 'GhiChuChiTiet'];

    List: Duoc_DuTruChiTiet[] | undefined;
    ListFilter: Duoc_DuTruChiTiet[] | undefined;
    FormData!: Duoc_DuTruChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_DuTruChiTiet";
    }
}

