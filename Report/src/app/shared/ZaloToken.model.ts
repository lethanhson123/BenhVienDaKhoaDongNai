import { Base } from "./Base.model";

export class ZaloToken extends Base{

    NgayGhiNhan?: Date;    
    OAAccessToken?: string;
    OARefreshToken?: string;
    AppID?: string;
    SecretKey?: string;
    URL?: string;

}


