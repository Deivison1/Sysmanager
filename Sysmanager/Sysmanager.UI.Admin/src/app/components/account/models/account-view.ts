export class AccountView{
    username: string= '';
    email: string='';
    password: string='';
    
    constructor( _email:string, _username:string, _password:string){

        this.username = _username;
        this.email = _email;
        this.password = _password
        
    }
}