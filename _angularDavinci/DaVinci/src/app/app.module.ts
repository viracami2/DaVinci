import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { HomeComponent } from "./components/home/home.component";
import { LayoutModule } from "@angular/cdk/layout";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatButtonModule } from "@angular/material/button";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatIconModule } from "@angular/material/icon";
import { MatListModule } from "@angular/material/list";
import { ListarProductosComponent } from "./components/producto/listar-productos/listar-productos.component";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import {
  MatDialogModule,
  MatMenuModule,
  MatCardModule,
  MatSelectModule,
  MatInputModule,
  MatFormFieldModule,
  MatTabsModule,
  MatTableModule,
} from "@angular/material";
import { ListarFacturasComponent } from "./components/factura/listar-facturas/listar-facturas.component";
import { CrearProductosComponent } from "./components/producto/crear-productos/crear-productos.component";
//import {MatTableModule} from '@angular/material/table';
import { FlexLayoutModule } from "@angular/flex-layout";

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ListarProductosComponent,
    ListarFacturasComponent,
    CrearProductosComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,

    HttpClientModule,
    FormsModule,
    MatDialogModule,

    MatMenuModule,
    MatTableModule,
    MatCardModule,
    MatSelectModule,

    MatInputModule,
    MatFormFieldModule,

    MatTabsModule,
    FlexLayoutModule,

    ReactiveFormsModule,
  ],
  providers: [],
  entryComponents: [CrearProductosComponent],
  bootstrap: [AppComponent],
})
export class AppModule {}
