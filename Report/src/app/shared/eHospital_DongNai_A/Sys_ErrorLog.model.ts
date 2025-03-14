import { Base } from "./Base.model";

export class Sys_ErrorLog extends Base{
ErrorLogID?: number;
ErrorTime?: Date;
UserName?: string;
ErrorNumber?: number;
ErrorSeverity?: number;
ErrorState?: number;
ErrorProcedure?: string;
ErrorLine?: number;
ErrorMessage?: string;

}


