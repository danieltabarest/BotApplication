using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Bot_Application.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            // return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");
            await context.PostAsync(ChatBot(activity.Text.ToUpper()));

            context.Wait(MessageReceivedAsync);
        }

        private string ChatBot(string text)
        {
            string result = "";
            if (text.Contains("Holaa"))
            {
                return "Un saludo, En que podemos colaborarle?";
            }
            result += "\n Podemos colaborale en algo más?";
            return result;
        }
    }
}