from __future__ import unicode_literals
from django.shortcuts import render, redirect
from django.contrib import messages
from django.db.models import Count
from django.contrib.auth.views import logout
from models import User

def show(request,id):
    travel= Travel.objects.get(id= id)
    context = {"travel": travel}
    return render(request, "travels_app/show.html", context)

def add(request, id):
    errors= Travel.objects.validate_creation(request.POST)
    if len(errors) > 0:
        for error in errors:
            messages.error(request, error)
        return redirect ("/travels/{}/edit".format(id))
    else:
        travel = Travel.objects.get(id=id)
        travel.destination = request.POST['destination']
        travel.description = request.POST['description']
        travel.travel_from= request.POST['travel_from']
        travel.travel_to= request.POST['travel_to']
        travel.creator= current_user=User.objects.get(id=request.session[“id”])
    
