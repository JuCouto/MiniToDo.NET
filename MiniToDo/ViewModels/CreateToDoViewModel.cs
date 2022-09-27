using Flunt.Notifications;
using Flunt.Validations;
using MiniToDo.Models;
using System.Diagnostics.Contracts;

namespace MiniToDo.ViewModels
{
    public class CreateToDoViewModel : Notifiable<Notification>
    {
        public string Title { get; set; }

        //criou o método para poder salvar o createtodo no banco utilizando Flunt
        public ToDo MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNull(Title, "Informe o Título da tarefa")
                .IsGreaterThan(Title, 5, "O Título de conter mais de 5 caracteres");

            AddNotifications(contract);
            return new ToDo(Guid.NewGuid(), Title, false);
        }

    }
}
