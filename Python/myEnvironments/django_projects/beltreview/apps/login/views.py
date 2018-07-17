# -*- coding: utf-8 -*-
from __future__ import unicode_literals
from django.shortcuts import render, redirect
from django.contrib import messages
from django.db.models import Count
from django.contrib.auth.views import logout
from models import User

# Create your views here.
def index(request):
    return render(request, 'login/index.html')

def register(request):
    if request.method == 'GET':
        return redirect('/')
    newuser = User.objects.validate(request.POST)
    if newuser[0] == False:
        for each in newuser[1]:
            messages.error(request, each)
        return redirect('/')
    if newuser[0] == True:
        request.session['id'] = newuser[1].id
        return redirect('/success')

def login(request):
    if 'id' in request.session:
        return redirect('/success')
    if request.method == 'GET':
        return redirect('/')
    else:
        user = User.objects.login(request.POST)
        if user[0] == False:
            for each in user[1]:
                messages.add_message(request, messages.INFO, each)
            return redirect('/')
        if user[0] == True:
            request.session['id'] = user[1].id
            return redirect('/success')

def success(request):
    if 'id' not in request.session:
        return redirect('/')
    context = {
        "user": User.objects.get(id=request.session['id']),
    }
    return render(request, 'login/success.html', context)

def logout(request):
    return redirect('/')

 