import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './authentication/login/login.component';
import { SideNavBarComponent } from './side-nav-bar/side-nav-bar.component'
const routes: Routes = [
{  path: '' , component :  LoginComponent },

{ path: 'Dot', component: SideNavBarComponent, children: [
  {path: 'HR',
  loadChildren: () => import('./input/input.module').then(m => m.InputModule)
}
]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
