import { Component, OnInit } from "@angular/core";
import { MatDialog, MatTableDataSource } from "@angular/material";
import { ProductoService } from "src/app/services/producto.service";
import { CrearProductosComponent } from "../crear-productos/crear-productos.component";

@Component({
  selector: "app-listar-productos",
  templateUrl: "./listar-productos.component.html",
  styleUrls: ["./listar-productos.component.css"],
})
export class ListarProductosComponent implements OnInit {
  displayedColumns: string[] = [
    "Id",
    "Referencia",
    "Nombre",
    "Descripcion",
    "Valor",
  ];
  public dataSource = new MatTableDataSource();

  constructor(public dialog: MatDialog, public serviceER: ProductoService) {}

  ngOnInit() {
    this.serviceER.listar().subscribe((data) => {
      this.dataSource = new MatTableDataSource(data);
    });
  }

  OpenDialogTicket(data: any): void {
    const dialogRef = this.dialog.open(CrearProductosComponent, {
      data: { datx: data, nombre: data.name },
      width: "400px",
    });
  }
}
