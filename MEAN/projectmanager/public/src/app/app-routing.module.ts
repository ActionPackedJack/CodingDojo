import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  // { path: 'products', component: ProductComponent, children: [
  //     { path: 'details/:id', component: ProductDetailComponent },
  //     { path: 'brand/:brand', component: BrandComponent },
  //     { path: 'category/:cat', component: CategoryComponent }]
  // },
  // { path: 'reviews', component: ReviewComponent, children: [
  //     { path: 'details/:id', component: ReviewDetailComponent },
  //     { path: 'author/:id', component: AuthorComponent },
  //     { path: 'all/:id', component: AllreviewsComponent }]
  // }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
