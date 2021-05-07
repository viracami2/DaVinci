import { Component, Inject, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material";
import { ProductoService } from "src/app/services/producto.service";

@Component({
  selector: "app-crear-productos",
  templateUrl: "./crear-productos.component.html",
  styleUrls: ["./crear-productos.component.css"],
})
export class CrearProductosComponent implements OnInit {
  titulo: any;
  public tipoForm: FormGroup;

  constructor(
    public _serviceCentroCosto: ProductoService,

    //public dialogRef: MatDialogRef<CrearProductosComponent>,
    private formBuilder: FormBuilder //    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  ngOnInit() {
    this.tipoForm = this.formBuilder.group({
      numeroFactura: ["", Validators.required],
      nit: [""],
      valorBruto: [""],
      iva: [""],
      valorTotal: [""],
      observaciones: [""],
    });
  }

  guardar() {}
}
