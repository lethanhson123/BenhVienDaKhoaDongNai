import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zTemp_NV_excel } from './zTemp_NV_excel.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zTemp_NV_excelService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaPhongBan', 'HoTen', 'GioiTinh', 'NgaySinh', 'F5', 'F6', 'F7', 'NgayVaoLam', 'F9', 'F10', 'QueQuan', 'MaPhongBan1', 'ChucVu', 'DangVien', 'F15', 'NgayVaoDang', 'MaTrinhDo', 'F18', 'ChuyenMon', 'MaTrinhDoChinhTri', 'F21', 'TrinhDoNgoaiNgu', 'MaTrinhDoQuanLyNN', 'ChungChiTinHoc', 'MaNgach', 'Bac', 'NgayNangLuong', 'HeSo', 'phucapchucvu', 'dochai', 'Tr_nh', 'H_vatmuc', 'HienVatMuc', 'HienVatMuc1', 'UuDai', 'HeSoUuDai', 'PhuCapVK', 'HeSoVK', 'Cong'];

    List: zTemp_NV_excel[] | undefined;
    ListFilter: zTemp_NV_excel[] | undefined;
    FormData!: zTemp_NV_excel;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zTemp_NV_excel";
    }
}

