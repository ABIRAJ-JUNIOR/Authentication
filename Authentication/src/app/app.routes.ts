import { Routes } from '@angular/router';
import { RegisterComponentComponent } from './Components/register-component/register-component.component';
import { LoginComponentComponent } from './Components/login-component/login-component.component';

export const routes: Routes = [
    {path:'' , component:LoginComponentComponent},
    {path:'register' , component:RegisterComponentComponent},

];
