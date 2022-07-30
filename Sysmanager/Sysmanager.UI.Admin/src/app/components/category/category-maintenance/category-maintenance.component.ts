import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Guid } from 'guid-typescript';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { CategoryService } from 'src/app/services/category-service';
import { CategoryView } from '../models/category-view';

@Component({
selector:'app-category-maintenance',
templateUrl:'./category-maintenance.component.html'
})

export class CategoryMaintenanceComponent implements OnInit {
    returnUrl: string ='';
    @Input() bodyDetail = ''
    action = 'Inserir';
    @Input() id: any = '';
    idDefault = Guid.EMPTY;

    public modalVisible = false;
    category = new CategoryView();
    constructor(private route: ActivatedRoute,
                private router: Router,
                private formBuilder: FormBuilder,
                private activedRouter: ActivatedRoute,
                private spinner: NgxSpinnerService,
                private categoryService: CategoryService,
                private toastr: ToastrService
                ){}

    formCategory = new FormGroup({
                                   id: this.formBuilder.control(this.category.id),
                                   name: this.formBuilder.control(this.category.name),
                                   active: this.formBuilder.control(this.category.active)
                                 });
                
    ngOnInit(){
        this.id = this.activedRouter.snapshot.params['id'];
        if (this.id != undefined && this.id != this.idDefault && this.id != null) {
          this.action = 'Alterar';
          this.getById(this.id);
        } else {
          this.action = 'Inserir';
          this.category = new CategoryView();
          this.formCategory.patchValue(this.category);
        }
    }

    getById(id: string) {
        this.spinner.show();
        this.categoryService.getByID(id)
        .subscribe(view => {
          this.category = view;
          console.log('resposta do get...');
          console.log(JSON.stringify(this.category));
          this.updateForm(this.category);
          
          this.spinner.hide();
        }, error  => {
          this.toastr.error(this.defaultMessage(error), this.action); 
          this.spinner.hide();
        });
    }

    updateForm(category: CategoryView){
    this.formCategory = new FormGroup({
        id: this.formBuilder.control(category.id),
        name: this.formBuilder.control(category.name),
        active: this.formBuilder.control(category.active),});  
    }
    


    confirmdelete(){}
    canceldelete(){
        this.modalVisible = false;
    }
    prepareDelete(){}
    saveChanges(category:any){}

    defaultMessage(message: string): any {
        var string = message.replace('<div>','').
        replace('</div>','').
        replace('<p>','').
        replace('</p>','');
        return string;
      }
}