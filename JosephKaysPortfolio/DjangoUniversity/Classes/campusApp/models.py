from django.db import models

#create model of UniversityCampus

class UniversityCampus(models.Model):
    CampusName = models.CharField(max_length=60, default='', blank=True, null=False)
    State = models.CharField(max_length=2, default='', blank=True, null=False)
    CampusID = models.IntegerField(default='', blank=True, null=False)

#displays the object output values in the form of a string
    def __str__(self):
        #returns the input value of the Campus Name to display in the browser
        #instead of the default titles
        display_CampusName = '{0.CampusName}'
        return display_CampusName.format(self)

     # removes added 's' that Django adds to the model name in the browser display
    class Meta:
        verbose_name_plural = "University Campuses"