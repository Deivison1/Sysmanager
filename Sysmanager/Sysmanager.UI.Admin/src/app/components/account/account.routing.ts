import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import {RecoveryComponent} from './recovery/recovery.component'

export const AccountRoutes: Routes = [
    {
      path: 'login',
      component: LoginComponent,
    },
    {
      path: 'register',
      component: RegisterComponent,
    },
    {
      path: 'recovery',
      component: RegisterComponent
    }
];