from django.urls import path
from . import views


urlpatterns = [
    path('', views.MyRecipes_home, name='MyRecipes_home'),
    path('MyRecipes_create/', views.MyRecipes_create, name='MyRecipes_create'),
    path('<int:pk>/details/', views.MyRecipes_details, name='MyRecipes_details'),
    path('MyRecipes_recipes/', views.MyRecipes_recipes, name='MyRecipes_recipes'),
    path('MyRecipes_update/<int:pk>/', views.MyRecipes_update, name='MyRecipes_update'),
    path('<int:pk>/delete/', views.MyRecipes_delete, name='MyRecipes_delete'),
]
