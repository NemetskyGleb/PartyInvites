namespace PartyInvites.Models
{
    // Объект будет отвечать за хранение. проверку достоверности и подтверждение ответа на приглашение (RSVP).
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}