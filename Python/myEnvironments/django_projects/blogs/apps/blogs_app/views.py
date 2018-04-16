from django.shortcuts import render, HttpResponse, redirect
  # the index function is called when root is visited
def index(request):
    response = "Placeholder to later display a list of all blogs."
    return HttpResponse(response)
def new(request):
    response= "Placeholder to display a new form to create a new blog."
    return HttpResponse(response)
def create(request):
    return redirect('/')
def edit(request, target):
    number=target
    response="Placeholder to edit blog {}".format(number)
    return HttpResponse(response)
def destroy(request, target):
    return redirect('/')