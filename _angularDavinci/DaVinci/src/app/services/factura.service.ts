import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient, HttpParams } from "@angular/common/http";
import { environment } from "../../environments/environment";
import { FacturaModel } from "../Models/factura-model";

@Injectable({
  providedIn: "root",
})
export class FacturaService {
  public tituloPopop: string;
  uri: string = "https://localhost:44352/";

  constructor(private _httpClient: HttpClient) {}

  listar(): Observable<FacturaModel[]> {
    return this._httpClient.get<FacturaModel[]>(`${this.uri}${"Factura/All"}`);
    //.catch(this.handlerError);
  }

  private handlerError(response: Response) {
    return Observable.throw(response.json());
  }
}
