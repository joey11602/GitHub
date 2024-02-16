from django.db import models


DIFFICULTY_CHOICES = {
    ('easy', 'Easy'),
    ('medium', 'Medium'),
    ('hard', 'Hard'),
}


class Recipe(models.Model):
    # Fields for recipe details
    title = models.CharField(max_length=255, unique=True)
    ingredients = models.TextField()
    instructions = models.TextField()

    # Additional details
    image_link = models.CharField(max_length=255, default='', blank=True, null=False)
    preparation_time = models.CharField(max_length=60, default='', null=False)
    publication_date = models.DateField(auto_now_add=True)
    # Auto added time stamp for when this recipe was added

    # Difficulty field
    difficulty = models.CharField(max_length=10, choices=DIFFICULTY_CHOICES, default='easy')

    objects = models.Manager()

    def __str__(self):
        return self.title

