import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SectionHealthComponent } from './sections/section-health/section-health.component';
import { SectionOrdersComponent } from './sections/section-orders/section-orders.component';
import { SectionSalesComponent } from './sections/section-sales/section-sales.component';

const routes: Routes = [
  {path: '', redirectTo: '/sales', pathMatch: 'full'},
  {path: 'sales', component: SectionSalesComponent},
  {path: 'orders', component: SectionOrdersComponent},
  {path: 'health', component: SectionHealthComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
