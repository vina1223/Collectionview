using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionview.Model
{
    public class ChatModel
    {
        public class ChatOption
        {
            public string GroupName { get; set; }
            public int GroupVal { get; set; }
            public ChatType ChatCategory { get; set; }

        }

        public class Chat
        {
            public ImageSource ProfileImage { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Time { get; set; }
            public int NoofChat { get; set; }
            public ChatType DescriptionType { get; set; }
            


        }

        public enum ChatType
        {
            Private,
            Group,
        }
    }
}
