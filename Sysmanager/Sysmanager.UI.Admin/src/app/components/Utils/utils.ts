import {ToastrService} from 'ngx-toastr';
import { Router } from '@angular/router';

export class Utils{

    constructor(private router: Router, private toastr: ToastrService){}

    ShowErrorMessage(messages:any, action: string) {
        var listItems = messages.split('</br>');

        for (let index = 0; index < listItems.length; index++) {
            const element = listItems[index];
            if (element != '' && element != undefined)
                this.toastr.error(element, action);
            }
        }
    navigateTo(url:string, param:string){

        if(param != '' && param != undefined && param != null){
            this.router.navigate([url, param]);
        }    
        else{
            this.router.navigate([url]);
        }
    }
    
}