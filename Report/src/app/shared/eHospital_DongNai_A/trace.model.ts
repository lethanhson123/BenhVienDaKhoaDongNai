import { Base } from "./Base.model";

export class trace extends Base{
RowNumber?: number;
EventClass?: number;
TextData?: string;
ApplicationName?: string;
NTUserName?: string;
LoginName?: string;
CPU?: number;
Reads?: number;
Writes?: number;
Duration?: number;
ClientProcessID?: number;
SPID?: number;
StartTime?: Date;
EndTime?: Date;
BinaryData?: string;

}


