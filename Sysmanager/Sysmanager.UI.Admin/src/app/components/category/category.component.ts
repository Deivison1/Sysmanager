import {Component, Input, OnInit} from '@angular/core';
import {FormBuilder, FormGroup} from '@angular/forms';
import {ActivatedRoute, Router} from '@angular/router';
import {CategoryFilter} from './models/category-filter'
import {CategoryService} from 'src/app/services/category-service'
import {NgxSpinnerService} from 'ngx-spinner';
import {PagerService} from 'src/app/services/page-service';

@Component({
selector:'app-category',
templateUrl:'./category.component.html'
})

export class CategoryComponent implements OnInit {
    returnUrl: string ='';
    @Input() bodyDetailTodelete = '';
    public deleteId = ''
    @Input() id: any ='';

    public modalVisible = false;
    public pager: any = {};
    pagedItems: any[]=[];
    firstPage = 1;
    itemsByPage = 10;

    constructor(private route: ActivatedRoute,
                private router: Router,
                private formbuilder: FormBuilder,
                private categoryService: CategoryService,
                private spinner: NgxSpinnerService,
                private pagerService: PagerService
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
        this.spinner.show();
        this.categoryService.delete(this.deleteId).subscribe(view => 
            {
                this.spinner.hide();
            }, error => {
                this.spinner.hide();
            });
    }

    canceldelete(){
        this.modalVisible = false;
    }

    handleChangeModal(event:any){

    }

    prepareDelete(id:string, name:string){
       this.deleteId = id;
       this.bodyDetailTodelete = 
       `Deseja realmente excluir o registro (${name})?`;
       this.modalVisible = true;
    }

    redirectUpdate(url:string, id:string){
        this.router.navigate([url, id]);
    }
    redirectTo(url:string){
     this.router.navigate([url]);
    }

    filterView(formvalue:CategoryFilter, page: number){

        let getFilter = new CategoryFilter(formvalue.name, formvalue.active, page, this.itemsByPage);
        this.spinner.show();
        this.categoryService.getByFilter(getFilter).subscribe(view => 
            {
                this.pagedItems = view.items;
                this.pager = this.pagerService.getPager(view._total, page, view._pageSize);
                this.spinner.hide();
            }, error => {
                this.spinner.hide();
            });
    }

}