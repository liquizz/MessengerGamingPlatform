from django.shortcuts import render
from rest_framework import mixins
from rest_framework import generics
from rest_framework.views import APIView
from rest_framework.response import Response
import MedievalBattleApp.models as models
import MedievalBattleApp.serializers as serializers


# Create your views here.


class ShowUnitClasses(mixins.ListModelMixin,
                      generics.GenericAPIView):
    queryset = models.UnitClasses.objects.all()
    serializer = serializers.UnitClassesSerializer

