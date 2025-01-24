import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuGhiNhanUngThu } from './PhieuGhiNhanUngThu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuGhiNhanUngThuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuGhiNhanUngThu_Id', 'SoPhieu', 'BenhAn_Id', 'ThoiGianCuTru', 'TinhTrangGiaDinh_Id', 'PARA', 'KinhDau', 'LayChong', 'SanhConDau', 'ManKinh', 'SoLanLapGiaDinh', 'ViTriUngThu', 'GiaiPhauBenhLy', 'Grad', 'GiaiDoanLamSang', 'XepHangLamSang', 'T', 'N', 'M', 'CoSoChanDoan_Id', 'UngThuNguyenPhat', 'NguonThongTin', 'DieuTriDacHieu_Id', 'NgayTheoDoi', 'TinhTrangHienTai_Id', 'NgayTuVong', 'NguyenNhanTuVong_Id', 'KetQuaTuThiet_Id', 'NoiTuVong', 'ICD_O_ID', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NgayThucHien'];

    List: PhieuGhiNhanUngThu[] | undefined;
    ListFilter: PhieuGhiNhanUngThu[] | undefined;
    FormData!: PhieuGhiNhanUngThu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuGhiNhanUngThu";
    }
}

