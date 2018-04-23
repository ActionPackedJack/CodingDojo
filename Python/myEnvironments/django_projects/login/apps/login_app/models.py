from __future__ import unicode_literals
from django.db import models
import re
import bcrypt
#from django.contrib.messages import constants as messages

class UserManager(models.Manager):
    def register_validate(self, post_data):
        registration_errors =[]
        for key in post_data.keys():
            print key
        if post_data['first_name'].isalpha()==False:
            registration_errors.append("Invalid character in first name.")
        if post_data['last_name'].isalpha()==False:
            registration_errors.append("Invalid character in last name.")
        if len(post_data['first_name'])<1:
            registration_errors.append("Please enter a first name.")
        if len(post_data['last_name'])<1:
            registration_errors.append("Please enter a last name.")
        if post_data['email_address'].find('@') ==-1:
            registration_errors.append("Please enter a valid email address.")
        elif post_data['email_address'].find('.') ==-1:
            registration_errors.append("Please enter a valid email address.")
        elif post_data['email_address'].find('@')> post_data['email_address'].find('.'):
            registration_errors.append("Please enter a valid email address.")
        if len(post_data['password'])<8:
            registration_errors.append("Passwords must be at least 8 characters.")
        if post_data['password']!= post_data['confirm_pw']:
            registration_errors.append("Password and confirmation must match.")
        if self.filter(email_address=post_data['email_address']).count()>0:
            registration_errors.append("That email address has already been registered.")
        return registration_errors
    def login_validate(self,post_data):
        login_errors=[]
        if not post_data['email_address']:
            print "NO EMAIL"
            login_errors.append('Please enter your email address.')
        elif self.filter(email_address=post_data['email_address']).count()<1:
            print "BAD EMAIL"
            login_errors.append('That email address does not have an account.')
        elif 'email_address' in post_data and 'password' in post_data:
            user= User.objects.get(email_address=post_data['email_address'])
        if not post_data['password']:
            login_errors.append('Please enter your password.')
        elif len(self.filter(email_address=post_data['email_address']))>0:
            if bcrypt.checkpw(post_data['password'].encode(), self.filter(email_address=post_data['email_address'])[0].password.encode())== False:
                login_errors.append("Invalid password.")
        return login_errors

class User(models.Model):
    first_name= models.CharField(max_length=255)
    last_name= models.CharField(max_length=255)
    email_address= models.CharField(max_length=255)
    password= models.CharField(max_length=255)
    created_at=models.DateTimeField(auto_now_add=True)
    updated_at=models.DateTimeField(auto_now=True)
    objects=UserManager()
