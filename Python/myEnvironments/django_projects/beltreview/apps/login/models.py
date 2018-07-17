from __future__ import unicode_literals
from django.db import models
import re
import bcrypt
from datetime import date, datetime
from time import strptime
Name_Regex = re.compile(r'^[A-Za-z ]+$')
Email_Regex = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')


# Create your models here.

class userManager(models.Manager):
    def validate(self, postData):
        errors = []
        if len(User.objects.filter(email=postData['email'])) > 0:
            errors.append("Username already exists")
        if postData['password'] != postData['confirm_password']:
            errors.append("Your passwords don't match")
        if len(postData['first_name']) < 2:
            errors.append("First name needs to be more than 1 letter")
        elif not Name_Regex.match(postData['first_name']):
            errors.append("First name can only be letters")
        if len(postData['last_name']) < 2:
            errors.append("Last name needs to be more than 1 letter")
        elif not Name_Regex.match(postData['last_name']):
            errors.append("Last name can only be letters")
        if len(postData['email']) < 1:
            errors.append('Email address can not be empty')
        elif not Email_Regex.match(postData['email']):
            errors.append('Invalid email address')
        if len(postData['password']) < 8:
            errors.append("Password needs to be more than 8 letters")
        if len(errors) == 0:
            #create the user
            newuser = User.objects.create(email=postData['email'], first_name=postData['first_name'], last_name=postData['last_name'], password=bcrypt.hashpw(
                postData['password'].encode(), bcrypt.gensalt()))
            return (True, newuser)
        else:
            return (False, errors)

    def login(self, postData):
        errors = []
        if 'email' in postData and 'password' in postData:
            try:
                # userManage acceses the database using .get (finds that one user's object)
                user = User.objects.get(email=postData['email'])
            # if the user doesnt exist from the .get(.get returns nothin, this 'except' prevents an error message)
            except User.DoesNotExist:
                print 50*('4')
                errors.append("Email Address or Password is incorrect.")
                return (False, errors)
        #password field/check
        pw_match = bcrypt.hashpw(
            postData['password'].encode(), user.password.encode())
        print 10*"3", user.password
        if pw_match == user.password:
            return (True, user)
        else:
            errors.append("Sorry, please try again.")
            return (False, errors)


class User(models.Model):
    first_name = models.CharField(max_length=45)
    last_name = models.CharField(max_length=100)
    email = models.CharField(max_length=255)
    password = models.CharField(max_length=100)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = userManager()

