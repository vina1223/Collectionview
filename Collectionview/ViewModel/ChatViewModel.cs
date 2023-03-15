using Collectionview.Model;
using CommunityToolkit.Maui.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Collectionview.Model.ChatModel;

namespace Collectionview.ViewModel
{
    public class ChatViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Chat> _Chat;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection <Chat> MyChat
        {
            get { return _Chat; }
            set
            {
                _Chat = value;
                OnPropertyChanged();
            }
        }

        private ChatOption _SelectItem;
        public ChatOption SelectItem
        {
            get { return _SelectItem; }
            set
            {
                _SelectItem= value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ChatOption> ChatItems { get; set; }
        private ObservableCollection<Chat> NewChat { get; set; }

        public ICommand SelectCommand { get; private set; }
        public ICommand 
        public ChatViewModel() 
        {
            SelectCommand = new Command(MyMethod);
            ChatItems = new ObservableCollection<ChatOption> 
            {
                new ChatOption
                {
                   GroupName="Private",
                   GroupVal=3,
                   ChatCategory = ChatType.Private,
                },
                new ChatOption
                {
                   GroupName="Group",
                   GroupVal=1,
                   ChatCategory = ChatType.Group,
                },
            };
            SelectItem = ChatItems.FirstOrDefault();

            NewChat = new ObservableCollection<Chat>
            {
                new Chat
                {
                    ProfileImage="dotnet_bot",
                    Name="Tom Cruise",
                    Description= "Hey how are you?",
                    Time=12.00,
                    NoofChat=2,
                    DescriptionType= ChatType.Private,
                },
                new Chat
                {
                    ProfileImage="dotnet_bot",
                    Name="Tom Cruise",
                    Description= "Hey how are you?",
                    Time=12.00,
                    NoofChat=2,
                    DescriptionType= ChatType.Group,
                },
                new Chat
                {
                    ProfileImage="dotnet_bot",
                    Name="Tom Cruise",
                    Description= "Hey how are you?",
                    Time=12.00,
                    NoofChat=2,
                    DescriptionType= ChatType.Private,
                },
                 new Chat
                {
                    ProfileImage="dotnet_bot",
                    Name="Tom Cruise",
                    Description= "Hey how are you?",
                    Time=12.00,
                    NoofChat=2,
                    DescriptionType= ChatType.Private,
                },
            };

            var Details = NewChat.Where(x => x.DescriptionType.Equals(SelectItem.ChatCategory)).ToObservableCollection();
            MyChat = Details;
        }

        public void MyMethod()
        {
            var Details = NewChat.Where(x => x.DescriptionType.Equals(SelectItem.ChatCategory)).ToObservableCollection();
            MyChat = Details;
        }

        public void ChangeImageColor()
        {

        }

    }
}
