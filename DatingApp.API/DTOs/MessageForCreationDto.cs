using System;

namespace DatingApp.API.DTOs
{
    public class MessageForCreationDto
    {
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public string Content { get; set; }
        public DateTime MessageSent { get; set; }
        public MessageForCreationDto()
        {
            MessageSent = DateTime.Now;
        }
    }
}