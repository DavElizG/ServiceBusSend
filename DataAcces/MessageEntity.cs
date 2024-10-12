using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class MessageEntity
    {
        public string Content { get; set; }

        public MessageEntity(string content)
        {
            Content = content;
        }
    }
}