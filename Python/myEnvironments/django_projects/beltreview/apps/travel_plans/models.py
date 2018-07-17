from __future__ import unicode_literals
from django.db import models
import re
import bcrypt
from datetime import date, datetime
from time import strptime
from ..login.models import User
# Create your models here.

class userManager(models.Manager):
    def validate(self, postData):
        errors = []
    if len(postData['destination'])<1:
        errors.append("Please enter a destination.")
    if len(postData['description'])<1:
        errors.append("Please enter a description.")
    if not postData['travel_from']:
        errors.append("Please specify a departure date.")
    if not postData['travel_to']:
        errors.append("Please specify a return date.")
    if datetime.now() >= postData['travel_from']:
        errors.append("Fourth-dimensional travel is not currently supported.  Please depart after today.")
    if postData['travel_from']> postData['travel_to']:
        errors.append("Assume a linear progression of time.  Please return after your departure.")
    if len(errors) == 0:
        newtravel = Travel.objects.create(destination=postData['destination'], description= postData['description'], travel_from=postData['travel_from'], travel_to=postData['travel_to'], planned_by=postData['creator']
class Travel(models.Model):
    destination = models.CharField(max_length=45)
    description = models.CharField(max_length=100)
    travel_from = models.DateTimeField()
    travel_to = models.DateTimeField()
    creator=models.ForeignKey(User, related_name=travels_created”)
    objects = travelManager()