from django.conf.urls import url, include
from . import views          
urlpatterns = [
    url(r'^$', views.index),
    url(r'^new', views.new),
    url(r'^create', views.create),
    url(r'^(?P<target>\d+)/edit', views.edit),
    url(r'^(?P<target>\d+)/delete', views.destroy),
  ]