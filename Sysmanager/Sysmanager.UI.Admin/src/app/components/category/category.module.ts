import {CommonModule} from '@angular/common';
import {FormsModule, ReactiveFormsModule } from '@angular/forms';
import {NgModule} from '@angular/core';
import {RouterModule} from '@angular/router';

import { CustomPaginationModule } from './../pagination/custom-pagination.module';
import {PagerService} from 'src/app/services/page-service'
import {CategoryComponent} from './category.component';
import {CategoryRoutes} from './category.routing';
import {CategoryViewComponent} from './models/category-view-component';
import {CategoryMaintenanceComponent} from './category-maintenance/category-maintenance.component';


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

import {IconModule} from '@coreui/icons-angular';
//import { BarNavigatorModule } from '../bar-navigator/bar-navigator.module';
import {NgxSpinnerModule} from 'ngx-spinner';
import { CategoryService } from 'src/app/services/category-service';


@NgModule({
    imports:[
        RouterModule.forChild(CategoryRoutes),
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
        CustomPaginationModule,
        //BarNavigatorModule,
        ModalModule,
        ToastModule        
    ],
    providers:[
        CategoryService,
        PagerService,
        
    ],
    declarations:[
        CategoryComponent,
        CategoryMaintenanceComponent,
        CategoryViewComponent
    ],
})
export class CategoryModule {
}