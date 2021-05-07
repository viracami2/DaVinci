import { Component, OnInit } from "@angular/core";
import { MatTableDataSource, MatDialog } from "@angular/material";
import { FacturaService } from "src/app/services/factura.service";
import { ProductoService } from "src/app/services/producto.service";

@Component({
  selector: "app-listar-facturas",
  templateUrl: "./listar-facturas.component.html",
  styleUrls: ["./listar-facturas.component.css"],
})
export class ListarFacturasComponent implements OnInit {
  displayedColumns: string[] = [
    "Id",
    "nit",
    "numeroFactura",
    "valorBruto",
    "iva",
    "valorTotal",
    "observacion",
  ];
  public dataSource = new MatTableDataSource();

  constructor(public dialog: MatDialog, public serviceER: FacturaService) {}

  ngOnInit() {
    this.serviceER.listar().subscribe((data) => {
      this.dataSource = new MatTableDataSource(data);
    });
  }
}
