﻿using System;
using System.Windows;
using Game.CubeClash.ViewModels;

namespace Game.CubeClash.UserControls
{
    public partial class CubeUserControl
    {
        private CubeViewModel _viewModel
        {
            get { return (CubeViewModel) DataContext; }
            set { DataContext = value; }
        }

        public CubeUserControl()
        {
            InitializeComponent();
        }

        private void ConnectAnimationEffect_OnLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void MoveAnimation_OnCompleted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExplodeAnimation_OnCompleted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AttackAnimation_OnCompleted(object sender, EventArgs e)
        {
            _viewModel.IsAttackingAnimationCompleated = true;
        }

        private void ShadowMoveAnimation_OnCompleted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
}}
