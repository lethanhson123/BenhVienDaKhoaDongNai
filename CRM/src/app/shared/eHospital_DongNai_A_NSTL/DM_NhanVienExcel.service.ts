import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_NhanVienExcel } from './DM_NhanVienExcel.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_NhanVienExcelService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MaNV', 'MaCC', 'HoTen', 'NamSinh', 'GioiTinh', 'QueQuan', 'DanToc', 'TonGiao', 'CMND', 'NgayCapCMND', 'TDVH', 'TDNN', 'TDTH', 'TDVH1', 'NgayVaoDoan', 'NgayVaoLam', 'TDCM', 'Ngach', 'Bac', 'PCTN', 'Cha', 'NSCha', 'Me', 'NSMe', 'TenVoChong', 'NSVoChong', 'DienThoai', 'F29', 'F30', 'F31', 'F32', 'F33', 'F34', 'F35', 'F36', 'F37', 'F38', 'F39', 'F40', 'F41', 'F42', 'F43', 'F44', 'F45', 'F46', 'F47', 'F48', 'F49', 'F50', 'F51', 'F52', 'F53', 'F54', 'F55', 'F56', 'F57', 'F58', 'F59', 'F60', 'F61', 'F62', 'F63', 'F64', 'F65', 'F66', 'F67', 'F68', 'F69', 'F70', 'F71', 'F72', 'F73', 'F74', 'F75', 'F76', 'F77', 'F78', 'F79', 'F80', 'F81', 'F82', 'F83', 'F84', 'F85', 'F86', 'F87', 'F88', 'F89', 'F90', 'F91', 'F92', 'F93', 'F94', 'F95', 'F96', 'F97', 'F98', 'F99', 'F100', 'F101', 'F102', 'F103'];

    List: DM_NhanVienExcel[] | undefined;
    ListFilter: DM_NhanVienExcel[] | undefined;
    FormData!: DM_NhanVienExcel;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_NhanVienExcel";
    }
}

