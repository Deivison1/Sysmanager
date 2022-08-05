import { CustomPaginationModule } from './../pagination/custom-pagination.module';
import { PagerService } from './../../services/page-service';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ProductTypeComponent } from '../productType/product-type.component';
import { ProductTypeRoutes } from './product-type.routing';
import { ProductTypeViewComponent } from './models/product-type-view.component';
import { ProductTypeService } from 'src/app/services/product-type.service';
import { ProductTypeMaintenanceComponent } from './productType-maintenance/product-type-maintenance.component';


import {
    ButtonGroupModule,
    ButtonModule,
    CardModule,
    DropdownModule,
    FormModule,
    GridModule,
    ListGroupModule,
    PaginationModule,
    SharedModule,
    TableModule,
    ModalModule,
    ToastModule,
  } from '@coreui/angular';
  import { IconModule } from '@coreui/icons-angular';
  import { NgxSpinnerModule } from 'ngx-spinner';

@NgModule({
    imports: [
        RouterModule.forChild(ProductTypeRoutes),
        CommonModule,
        FormModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        ButtonGroupModule,
        ButtonModule,
        SharedModule,
        CardModule,
        GridModule,
        ListGroupModule,
        DropdownModule,
        IconModule,
        TableModule,
        NgxSpinnerModule,
        PaginationModule,
        ModalModule,
        ToastModule,
        CustomPaginationModule
    ],
    providers: [
        ProductTypeService,
        PagerService,
    ],
    declarations: [
        ProductTypeComponent,
        ProductTypeMaintenanceComponent,
        ProductTypeViewComponent,
    ],
})
export class ProductTypeModule {
}