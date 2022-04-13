import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';


const routes: Routes = [
  {path:'',redirectTo:'login',pathMatch:'full'},
  { path: 'login', loadChildren: () => import('./pages/user-management/login/login.module').then(m => m.LoginModule)}, 
  { path: 'register', loadChildren: () => import('./pages/user-management/register/register.module').then(m => m.RegisterModule) },
  { path: 'forgotpassword', loadChildren: () => import('./pages/user-management/forgot-password/forgot-password.module').then(m => m.ForgotPasswordModule) },
  { path: 'resetpassword', loadChildren: () => import('./pages/user-management/reset-password/reset-password.module').then(m => m.ResetPasswordModule) },
  { path: 'dashboardlayout', loadChildren: () => import('./pages/dashboard/dashboard-layout/dashboard-layout.module').then(m => m.DashboardLayoutModule) ,canActivate : [AuthGuard] },
  { path: 'assetlist', loadChildren: () => import('./pages/dashboard/asset-list/asset-list.module').then(m => m.AssetListModule) }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
