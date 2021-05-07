import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient, HttpParams } from "@angular/common/http";
import { environment } from "../../environments/environment";
import { ProductoModel } from "../Models/producto-model";

@Injectable({
  providedIn: "root",
})
export class ProductoService {
  public tituloPopop: string;
  uri: string = "https://localhost:44352/";

  // add(dataToSend: ProductoModel): Observable<string> {
  //   this._loadingService.load(true);
  //   var url = environment.url;
  //   return this._httpClient.post<string>(url + "", dataToSend).pipe(
  //     finalize(() => this._loadingService.load(false)),
  //     map(() => {
  //       this._alertService.success("Registro creado correctamente");
  //       return "";
  //     })
  //   );
  // }

  // update(dataToSend: CentroDeCostoModel): Observable<string> {
  //   this._loadingService.load(true);
  //   var url = environment.url;
  //   return this._httpClient
  //     .post<string>(url + constantes.UpdateCentroDeCosto, dataToSend)
  //     .pipe(
  //       finalize(() => this._loadingService.load(false)),
  //       map(() => {
  //         this._alertService.success("Registro actualizado correctamente");
  //         return "";
  //       })
  //     );
  // }

  // delete(producto: ProductoModel): Observable<string> {
  //   this._loadingService.load(true);
  //   var url = environment.url;
  //   return this._httpClient
  //     .post<string>(url + constantes.DeleteCentroDeCosto, producto)
  //     .pipe(
  //       finalize(() => this._loadingService.load(false)),
  //       map(() => {
  //         this._alertService.success("Registro eliminado correctamente");
  //         return "";
  //       })
  //     );
  // }

  constructor(private _httpClient: HttpClient) {}

  listar(): Observable<ProductoModel[]> {
    return this._httpClient.get<ProductoModel[]>(
      `${this.uri}${"Producto/Todos"}`
    );
    //.catch(this.handlerError);
  }

  private handlerError(response: Response) {
    return Observable.throw(response.json());
  }

  // listar(filter: any): Observable<ProductoModel> {
  //   let parametros: HttpParams = mapParams(filter);

  //   //parametros = parametros.set("OrderDirection", String(orderDir));
  //   //parametros = parametros.set("OrderField", String(orderField));
  //   var url = environment.url;

  //   return this._httpClient
  //     .get<MatTablePageList<CentroDeCostoModel>>(
  //       url + constantes.getCentroDeCosto,

  //       { params: parametros }
  //     )
  //     .pipe(
  //       finalize(() => this._loadingService.load(false)),
  //       map((data) => {
  //         // this._alertService.success("Datos listados exitosamente");
  //         return data;
  //       })
  //     );
  // }
}
