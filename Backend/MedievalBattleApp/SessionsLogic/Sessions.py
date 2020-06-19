import MedievalBattleApp.models as models
import MedievalBattleApp.serializers as serializers
from rest_framework.response import Response
from rest_framework.views import APIView


class Session(APIView):
    def get(self, request, pk):
        queryset = models.SessionMedievalBattle.objects.get(pk=pk)
        serializer = serializers.SessionMedievalBattleSerializer(queryset, many=False)
        return Response(serializer.data)

    def put(self, request):
        query = models.SessionMedievalBattle.objects.create()

