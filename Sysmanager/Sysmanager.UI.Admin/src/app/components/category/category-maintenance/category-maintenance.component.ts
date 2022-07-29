import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { CategoryService } from 'src/app/services/category-service';
import { CategoryView } from '../models/category-view';

@Component({
selector:'app-category-maintenance',
templateUrl:'./category-maintenance.component.html'
})

export class CategoryMaintenanceComponent implements OnInit {
    returnUrl: string ='';

    @Input() bodyDetail = ''
    @Input() id: any = '';
    action = 'Inserir';
    public modalVisible = false;
    category = new CategoryView();

    constructor(private route: ActivatedRoute,
                private router: Router,
                private formbuilder: FormBuilder,
                private activedRouter: ActivatedRoute,
                private categoryService: CategoryService,
                private spinner: NgxSpinnerService,
                ){}

    formCategory = new FormGroup({
                    name: this.formbuilder.control(this.category.id),
                    active: this.formbuilder.control(this.category.name),
                    itemsByPage: this.formbuilder.control(this.category.active),
                });            
                
    ngOnInit(){
        this.id = this.activedRouter.snapshot.params['id'];
    }
    confirmdelete(){}

    canceldelete(){}

    prepareDelete(){}

    updateform(){}
    
    saveChanges(category:any){}
}