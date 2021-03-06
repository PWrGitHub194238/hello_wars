﻿using System.Windows;
using Elimination.TournamentLadder.ViewModels;

namespace Elimination.TournamentLadder.UserControls
{
    /// <summary>
    /// Interaction logic for UserViewControl.xaml
    /// </summary>
    /// []
    public partial class BotUserControl 
    {
        public int Id;
        public int PairWithId;
        public int NextStageTargetId;
        public Point BotHeadPoint;
        public Point BotTailPoint;

        public BotViewModel ViewModel
        {
            get { return (BotViewModel)DataContext; }
            set { DataContext = value; }
        }

        public BotUserControl(BotViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
