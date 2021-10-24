namespace ByMail.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using ByMail.Models;
    using ReactiveUI;

#nullable disable

    /// <summary>
    /// Interaction logic for MainWindow.axaml
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<MenuItem> menuItems;
        private ObservableCollection<Folder> folders;

        public ObservableCollection<Folder> Folders
        {
            get => this.folders;
            set => this.RaiseAndSetIfChanged(ref this.folders, value);
        }
        public ObservableCollection<MenuItem> MenuItems
        {
            get => this.menuItems;
            set => this.RaiseAndSetIfChanged(ref this.menuItems, value);
        }

        public MainWindowViewModel()
        {
            LoadSideBarData();
        }

        protected void LoadSideBarData()
        {
            MenuItems = new ObservableCollection<MenuItem>()
            {
                new MenuItem
                {
                    Title="Inbox",
                    Count="12",
                    Path = "InboxPagePath",
                    Icon="PutAvaloniaIconForMenu"
                },
                new MenuItem
                {
                    Title="Starred",
                    Path="StarredPagePath",
                    Icon="IconForStarred"
                },
                new MenuItem
                {
                    Title="Sent",
                    Path="SentMailsPath",
                    Icon="IconForSent"
                },
                new MenuItem
                {
                    Title="Drafts",
                    Path="DraftsPagePath",
                    Icon="IconForDraft"
                },
                new MenuItem
                {
                    Title="Deleted",
                    Path="DeletedPagePath",
                    Icon="IconForDeleted"
                },
                new MenuItem
                {
                    Title="Spam",
                    Path="SpamPagePath",
                    Icon="IconForSpam"
                }
            };

            Folders = new ObservableCollection<Folder>()
            {
                new Folder
                {
                    Name="Work folder",
                    Path=@"C:"
                }
            };
        }
    }
}
