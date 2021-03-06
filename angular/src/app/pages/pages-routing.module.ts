import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';


const routes: Routes = [
  { path: '', component: DashboardComponent, canActivate: [AppRouteGuard] },
  { path: 'snippets', loadChildren: () => import('./snippet/snippet.module').then(m => m.SnippetModule) },
  { path: 'users', loadChildren: () => import('./users/users.module').then(m => m.UsersModule) },
  { path: 'topics', loadChildren: () => import('./topics/topics.module').then(m => m.TopicsModule) },
  { path: 'categories', loadChildren: () => import('./categories/categories.module').then(m => m.CategoriesModule) },

  { path: 'snippet', loadChildren: () => import('./snippets/snippets.module').then(m => m.SnippetsModule) },
  { path: 'ui', loadChildren: () => import('./ui/ui.module').then(m => m.UiModule) },
  { path: 'apps', loadChildren: () => import('./apps/apps.module').then(m => m.AppsModule) },
  { path: 'other', loadChildren: () => import('./other/other.module').then(m => m.OtherModule) },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule { }
