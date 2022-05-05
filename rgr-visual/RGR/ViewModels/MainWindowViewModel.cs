using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using RGR.Models;

namespace RGR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateGrid();
            CreateRequests();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }

        ObservableCollection<Tab> tabs;
        public ObservableCollection<Tab> Tabs
        {
            get { return tabs; }
            set { this.RaiseAndSetIfChanged(ref tabs, value); }
        }
        private void CreateTabs()
        {
            Tabs = new ObservableCollection<Tab>();
            Tabs.Add(new Tab("Players"));
            Tabs.Add(new Tab("Teams"));
            Tabs.Add(new Tab("Countries"));
            Tabs.Add(new Tab("Seasons"));
            Tabs.Add(new Tab("League"));
            Tabs.Add(new Tab("Winners"));
            Tabs.Add(new Tab("1Request"));
            Tabs.Add(new Tab("2Request"));

        }

        ObservableCollection<Tab> request;
        public ObservableCollection<Tab> Request
        {
            get { return request; }
            set { this.RaiseAndSetIfChanged(ref request, value); }
        }

        private void CreateRequests()
        {
            Request = new ObservableCollection<Tab>();
            Request.Add(new Tab("Request 1"));
            Request.Add(new Tab("Request 2"));
       
        }

        ObservableCollection<Grid> grids;
        public ObservableCollection<Grid> Grids
        {
            get { return grids; }
            set { this.RaiseAndSetIfChanged(ref grids, value); }
        }
        private void CreateGrid()
        {
            Grids = new ObservableCollection<Grid>();
            Grids.Add(new Grid("Cam Thomas", "20", "Japan"));
            Grids.Add(new Grid("Kiki Vandeweghe", "63", "Germany"));
            Grids.Add(new Grid("Mike Wilks", "42", "USA"));
            Grids.Add(new Grid("Melvin Frazier", "40", "USA"));
            Grids.Add(new Grid("Omer Yurtseven", "23", "Turkey"));
        }
    }
}
