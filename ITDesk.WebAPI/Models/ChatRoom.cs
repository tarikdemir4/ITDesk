namespace ITDesk.WebAPI.Models;

public sealed class ChatRoom
{
    public ChatRoom()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }

}
