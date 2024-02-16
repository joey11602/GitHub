from django.shortcuts import render, redirect, get_object_or_404
from .models import Recipe
from .forms import RecipeForm


def MyRecipes_home(request):
    return render(request, 'MyRecipes/MyRecipes_home.html')


def MyRecipes_create(request):
    form = RecipeForm(data=request.POST or None)
    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('MyRecipes_recipes')
    content = {'form': form}
    return render(request, 'MyRecipes/MyRecipes_create.html', content)


def MyRecipes_delete(request, pk):
    recipe = get_object_or_404(Recipe, pk=pk)
    if request.method == 'POST':
        recipe.delete()
        return redirect("MyRecipes_recipes")
    content = {'recipe': recipe}
    return render(request, "MyRecipes/MyRecipes_delete.html", content)


def MyRecipes_update(request, pk):
    recipe = get_object_or_404(Recipe, pk=pk)
    form = RecipeForm(data=request.POST or None, instance=recipe)
    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('MyRecipes_recipes')
    content = {'form': form, 'recipe': recipe}
    return render(request, "MyRecipes/MyRecipes_update.html", content)


def MyRecipes_details(request, pk):
    recipe = get_object_or_404(Recipe, pk=pk)
    content = {'recipe': recipe}
    return render(request, 'MyRecipes/MyRecipes_details.html', content)


def MyRecipes_recipes(request):
    all_titles = Recipe.objects.all()
    content = {'all_titles': all_titles}
    return render(request, 'MyRecipes/MyRecipes_recipes.html', content)
