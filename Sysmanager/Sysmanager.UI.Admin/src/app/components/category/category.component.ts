import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import {CategoryFilter} from './models/category-filter';
import {CategoryService} from 'src/app/services/category-service'
import { NgxSpinner, NgxSpinnerService } from 'ngx-spinner';

@Component({
selector:'app-category',
templateUrl:'./category.component.html'
})

export class CategoryComponent implements OnInit {

    returnUrl: string ='';
    @Input() bodyDetailTodelete = '';
    public modalVisible = false;
    public pager: any = {};
    pagedItems: any[]=[];
    firstPage = 1;

    constructor(private route: ActivatedRoute,
                private router: Router,
                private formbuilder: FormBuilder,
                private categoryService: CategoryService,
                private spinner: NgxSpinnerService
               
                ){

            }

    formFilter = new FormGroup({
        name: this.formbuilder.control(''),
        active: this.formbuilder.control('todos'),
        itemsByPage: this.formbuilder.control('10'),
    });

    ngOnInit(){

    }

    confirmdelete(){

    }

    canceldelete(){

    }
    handleChangeModal(event:any){

    }
    prepareDelete(id:string, name:string){

    }

    redirectUpdate(url:string, id:string){

    }
    redirectTo(url:string){
        this.router.navigate([url]);
    }

    filterView(filter:CategoryFilter, page: number){

        this.spinner.show();
        this.categoryService.getByFilter(filter).subscribe(view =>
        {
           this.pagedItems = view.items;
           this.spinner.hide();

        }, 
        error => {
            this.spinner.hide();
        });
    }
}    