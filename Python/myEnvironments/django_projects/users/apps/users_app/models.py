from __future__ import unicode_literals
from django.db import models
class User(models.Model):
      first_name = models.CharField(max_length=255)
      last_name = models.CharField(max_length=255)
      email_address = models.CharField(max_length=255)
      age = models.IntegerField()
      created_at = models.DateTimeField(auto_now_add = True)
      updated_at = models.DateTimeField(auto_now = True)

@classmethod
def create(cls, first_name, last_name, email_address, age, created_at, updated_at):
    user = cls(first_name=first_name, last_name=last_name, email_address=email_address, age=age, created_at=models.DateTimeField(auto_now_add=True), updated_at=models.DateTimeField(auto_now=True))
    return user
# Create your models here.
