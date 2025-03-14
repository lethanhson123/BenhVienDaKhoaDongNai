import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChiPhiKCBNgoaiTru_BHYT } from './ChiPhiKCBNgoaiTru_BHYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChiPhiKCBNgoaiTru_BHYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'TiepNhan_Id', 'KhamBenh_Id', 'BenhAn_Id', 'BenhNhan_Id', 'DoiTuong_Id', 'SoBHYT', 'NgayVao', 'NgayRa', 'NgayKham', 'Loai_IDRef', 'IDRef', 'NoiDung_Id', 'NoiDung', 'SoLuong', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'SoLuong_New', 'DonGiaHoTroChiTra_New', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Loai'];

    List: ChiPhiKCBNgoaiTru_BHYT[] | undefined;
    ListFilter: ChiPhiKCBNgoaiTru_BHYT[] | undefined;
    FormData!: ChiPhiKCBNgoaiTru_BHYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChiPhiKCBNgoaiTru_BHYT";
    }
}

