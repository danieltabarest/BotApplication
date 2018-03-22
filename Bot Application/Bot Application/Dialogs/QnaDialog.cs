using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Bot_Application.Dialogs
{
    [Serializable]
    [QnAMaker("a87340e011fb431585d0853441d34226", "2d3b75a3-ff65-4841-b6cf-2f635678ac0b", "Frase estandar cuando no satisface el indice mínimo de confiabilidad de respuesta",0.5,1)]
    public class QnaDialog : QnAMakerDialog
    {
    }
}