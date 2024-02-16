from django.forms import ModelForm
from .models import Recipe


class RecipeForm(ModelForm):
    class Meta:
        model = Recipe
        fields = ['title', 'ingredients', 'instructions', 'image_link', 'preparation_time', 'difficulty']

        labels = {
            'title': 'Title',
            'ingredients': 'Ingredients',
            'instructions': 'Instructions',
            'preparation_time': 'Prep Time',
            'difficulty': 'Difficulty'

        }
