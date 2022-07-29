import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
selector:'app-category-maintenance',
templateUrl:'./category-maintenance.component.html'
})

export class CategoryMaintenanceComponent implements OnInit {

    returnUrl: string ='';

    constructor(private route: ActivatedRoute,
                private router: Router,
               
                ){}
                
    ngOnInit(){

    }
}