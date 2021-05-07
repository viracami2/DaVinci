import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ListarFacturasComponent } from "./components/factura/listar-facturas/listar-facturas.component";
import { CrearProductosComponent } from "./components/producto/crear-productos/crear-productos.component";
import { ListarProductosComponent } from "./components/producto/listar-productos/listar-productos.component";

const routes: Routes = [
  { path: "ListarProductos", component: ListarProductosComponent },
  { path: "CrearProductos", component: CrearProductosComponent },

  {
    path: "ListarFacturas",
    component: ListarFacturasComponent,
  },

  //{ path: 'heroes', component: HeroesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
