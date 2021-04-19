﻿using System.Windows.Controls;
using TextBlockTriggerSample.ViewModels;

namespace TextBlockTriggerSample.Views
{
	/// <summary>
	/// MainView.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainView : UserControl
	{
		public MainView()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}
	}
}