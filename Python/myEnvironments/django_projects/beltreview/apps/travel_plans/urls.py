from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.main),
    url(r'^travels$', views.travels),
    url(r'^travels/destination/?P<id>[0-9]+$', views.destination),
    url(r'^travels/add$', views.add)
]