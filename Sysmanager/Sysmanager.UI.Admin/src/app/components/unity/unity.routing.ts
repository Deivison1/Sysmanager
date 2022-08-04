import {Routes} from '@angular/router'
import {UnityViewComponent} from './models/unity-view-component'
import {UnityComponent} from './unity.component'
import {UnityMaintenanceComponent} from './unity-maintenance/unity-maintenance.component'

export const UnityRoutes: Routes = [
  {
    path: '',
    component: UnityViewComponent,
    children: [
            {
                path: 'unity',
                component: UnityComponent,
                data: {name: 'Pesquisar Unidade de medida', title:'Pesquisar Unidade de medida'}
            },
            {
                path: 'maintenance',
                component: UnityMaintenanceComponent,
                data: {name: 'Inserir Unidade de medida', title:'Inserir Unidade de medida'}
            },
            {
                path: 'maintenance/:id',
                component: UnityMaintenanceComponent,
                data: {name: 'Alterar Unidade de medida', title:'Alterar Unidade de medida'}
            },                           
        ]
    }
];