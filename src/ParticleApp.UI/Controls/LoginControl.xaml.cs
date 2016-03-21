﻿/*
   Copyright 2016 ParticleNET

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

	   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using ParticleApp.Business.Pages;
using ParticleApp.Business.ViewModel;
using System;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ParticleApp.UI.Controls
{
	public sealed partial class LoginControl : UserControl
	{
		public LoginControl()
		{
			this.InitializeComponent();
			if (!String.IsNullOrWhiteSpace(AppSettings.Current.Username))
			{
				LoginFrame.Navigate(typeof(LoginPage), true);
			}
			else
			{
				LoginFrame.Navigate(typeof(RegisterPage));
			}
		}
	}
}
